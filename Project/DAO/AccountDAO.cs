using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace Project
{
    internal class AccountDAO : IDisposable
    {
        string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        MySqlConnection conn = null;

        public AccountDAO()
        {
            conn = new MySqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public DataTable GetAccountInfo(string txtaccount, string txtpwd)
        {
            DataTable dt = new DataTable();

            string sql = $@"SELECT A.PCODE, B.NAME, A.ACODE, A.PWD, A.ASSET, A.STATUS, A.CARD_NO, A.CARD_PWD
                             FROM ACCOUNT A LEFT JOIN CUSTOMER B ON A.PCODE = B.PCODE
                             WHERE ( A.ACODE = @txtaccount or A.CARD_NO = @txtaccount )"; // AND A.DELETED = 'N'";

            if (!string.IsNullOrEmpty(txtpwd))
                sql += $" AND A.PWD = @txtpwd";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@txtaccount", txtaccount);
            da.SelectCommand.Parameters.AddWithValue("@txtpwd", txtpwd);
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public Decimal GetAsset()
        {
            DataTable dt = new DataTable();
            string sql = $@"SELECT ASSET FROM ACCOUNT WHERE PCODE = @PCODE AND ACODE = @ACODE";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@PCODE", Core.PCODE);
            da.SelectCommand.Parameters.AddWithValue("@ACODE", Core.ACODE);
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return decimal.Parse(dt.Rows[0][0].ToString());
        }

        public DataTable GetAccountHistory(string sDate, string eDate)    //이력조회
        {
            DataTable dt = new DataTable();

            string sql = $@"SELECT A.CDATE, B.CNAME AS TRANS_INFO, A.OTHER_ANAME, A.OTHER_BCODE, A.OTHER_ACODE, A.CASH, A.ASSET, A.FEE, A.MEMO 
                            FROM financial_history A LEFT JOIN common_code B ON A.TRANS_INFO = B.CCODE
                            WHERE ACODE = @ACODE AND B.GCODE = 'TRANSCODE'
                             AND A.cdate Between STR_TO_DATE(@sDate, '%Y-%m-%d') AND STR_TO_DATE(@eDate, '%Y-%m-%d')
                            ORDER BY 1 DESC";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@sDate", sDate);
            da.SelectCommand.Parameters.AddWithValue("@eDate", eDate);
            da.SelectCommand.Parameters.AddWithValue("@ACODE", Core.ACODE);
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public bool TranInsert()
        {
            string sql = "";
            Core.FHCODE = Util.GetIDX("FH", 10);

            switch (Core.TRANS_INFO)
            {
                case "TNS01": // 입금 
                    sql = $@"START TRANSACTION;
                            INSERT INTO financial_history(FHCODE, TRANS_INFO, KCODE, ACODE, ASSET, CASH, MEMO) 
                            VALUES(@FHCODE, @TRANS_INFO, @KCode, @ACODE,@AMOUNT, @AMOUNT, @MSG); -- 입금이력 (financial_history)
                            UPDATE ACCOUNT SET ASSET = ASSET + @AMOUNT WHERE PCODE = @PCODE AND ACODE = @ACODE;       -- 개인자산추가
                            UPDATE BANK SET CASH = CASH + @AMOUNT, ASSET = ASSET + @AMOUNT WHERE BCODE = 'BKN01';           -- 은행 현금추가, 자산추가
                            UPDATE KIOSK SET CASH = CASH + @AMOUNT WHERE KCODE = @KCode AND BCODE = 'BKN01';                -- 키오스크 현금추가
                            COMMIT;";
                    break;

                case "TNS02": // 출금
                    sql = $@"START TRANSACTION;
                            INSERT INTO financial_history(FHCODE, TRANS_INFO, KCODE, ACODE, ASSET, CASH, MEMO) 
                            VALUES(@FHCODE, @TRANS_INFO, @KCode, @ACODE,@AMOUNT, @AMOUNT, @MSG); -- 출금이력 (financial_history)
                            UPDATE ACCOUNT SET ASSET = ASSET - @AMOUNT WHERE PCODE = @PCODE AND ACODE = @ACODE;       -- 개인자산 마이너스
                            UPDATE BANK SET CASH = CASH - @AMOUNT, ASSET = ASSET - @AMOUNT WHERE BCODE = 'BKN01';           -- 은행 현금마이너스, 자산마이너스
                            UPDATE KIOSK SET CASH = CASH - @AMOUNT WHERE KCODE = @KCode AND BCODE = 'BKN01';                -- 키오스크 현금마이너스
                            COMMIT;";
                    break;

                case "TNS03": // 송금
                    sql = $@"START TRANSACTION;
                            INSERT INTO financial_history (FHCODE, TRANS_INFO, KCODE, ACODE, OTHER_ANAME, OTHER_BCODE, OTHER_ACODE, ASSET, FEE, MEMO)
                            VALUES(@FHCODE, @TRANS_INFO, @KCode, @ACODE, 
                            @OTHER_ANAME, @OTHER_BCODE, @OTHER_ACODE, @AMOUNT, @FEE, @MSG);        -- 송금이력 (financial_history)                            
                            UPDATE ACCOUNT SET ASSET = ASSET - @AMOUNT + @FEE WHERE PCODE = @PCODE AND ACODE = @ACODE;  -- 개인자산 마이너스
                            UPDATE BANK SET ASSET = ASSET - @AMOUNT + @FEE WHERE BCODE = 'BKN01';                                       -- 은행자산 마이너스
                            COMMIT;";
                    break;

                case "TNS04":   // 무통장
                    sql = $@"START TRANSACTION;
                            INSERT INTO financial_history (FHCODE, TRANS_INFO, KCODE, OTHER_ANAME, OTHER_BCODE, OTHER_ACODE, FEE, MEMO)
                            VALUES (@FHCODE, @TRANS_INFO, @KCode, 
                            @OTHER_ANAME, @OTHER_BCODE, @OTHER_ACODE, @FEE, @MSG);    -- 무통장이력 (financial_history)
                            UPDATE BANK SET CASH = CASH + @AMOUNT + @FEE, ASSET = ASSET - @AMOUNT - @FEE WHERE BCODE = 'BKN01';     -- 은행현금추가, 은행자산마이너스
                            UPDATE KIOSK SET CASH = CASH + @AMOUNT + @FEE WHERE KCODE = @KCode AND BCODE = 'BKN01';         -- 키오스크 현금추가
                            COMMIT;";
                    break;
            };

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@FHCODE", Core.FHCODE);
            cmd.Parameters.AddWithValue("@TRANS_INFO", Core.TRANS_INFO);
            cmd.Parameters.AddWithValue("@KCode", Core.KCode);
            cmd.Parameters.AddWithValue("@ACODE", Core.ACODE);
            cmd.Parameters.AddWithValue("@AMOUNT", Core.AMOUNT);
            cmd.Parameters.AddWithValue("@MSG", Core.MSG);
            cmd.Parameters.AddWithValue("@PCODE", Core.PCODE);
            cmd.Parameters.AddWithValue("@OTHER_ANAME", Core.OTHER_ANAME);
            cmd.Parameters.AddWithValue("@OTHER_BCODE", Core.OTHER_BCODE);
            cmd.Parameters.AddWithValue("@OTHER_ACODE", Core.OTHER_ACODE);
            cmd.Parameters.AddWithValue("@FEE", Core.FEE);
            conn.Open();
            int iRowAffect = cmd.ExecuteNonQuery();
            conn.Close();
            return (iRowAffect > 0);
        }

        public bool SameBank()
        {
            string sql = $"UPDATE ACCOUNT SET ASSET = ASSET + @AMOUNT WHERE ACODE = @OTHER_ACODE";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@AMOUNT", Core.AMOUNT);
            cmd.Parameters.AddWithValue("@OTHER_ACODE", Core.OTHER_ACODE);
            conn.Open();
            int iRowAffect = cmd.ExecuteNonQuery();
            conn.Close();
            return (iRowAffect > 0);
        }

        public bool AccountBreak()  //계좌정지
        {
            string sql = $@"UPDATE ACCOUNT SET STATUS = 'Y' WHERE ACODE = @ACODE"; //PCODE = '{Core.PCODE}'
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ACODE", Core.ACODE);
            conn.Open();
            int iRowAffect = cmd.ExecuteNonQuery();
            conn.Close();
            return (iRowAffect > 0);
        }
    }
}
