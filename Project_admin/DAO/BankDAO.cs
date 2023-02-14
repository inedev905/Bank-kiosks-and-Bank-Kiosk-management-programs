using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

namespace Project_admin
{
    public class BankDAO : IDisposable
    {
        string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        MySqlConnection conn = null;

        public BankDAO()
        {
            conn = new MySqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public bool Bank(string name, string pwd)
        {
            string sql = @"UPDATE bank
                            SET Name = @Name, pwd = @pwd";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@PWD", pwd);
            conn.Open();
            int iRowAffect = cmd.ExecuteNonQuery();
            conn.Close();
            return (iRowAffect > 0);
        }

        public bool Asset(BankDTO bank)
        {
            string sql = @"UPDATE bank
                            SET CASH = @CASH, ASSET = @ASSET";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CASH", bank.Cash);
            cmd.Parameters.AddWithValue("@ASSET", bank.Asset);
            conn.Open();
            int iRowAffect = cmd.ExecuteNonQuery();
            conn.Close();
            return (iRowAffect > 0);
        }

        public BankDTO BankSelect(string bankCode) // 1 개만
        {
            BankDTO rtn = new BankDTO();
            DataTable dt = new DataTable();
            string sql = $@"SELECT A.BCODE AS BANK_CODE, B.CNAME AS BANK_NAME, A.NAME, A.CASH, A.ASSET, A.PWD 
                              FROM BANK A
                            LEFT JOIN common_code B
                                   ON A.BCODE = B.CCODE
                                WHERE A.BCODE = @bankCode
                                  AND B.GCODE = 'BANKCODE'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@bankCode", bankCode);
            da.Fill(dt);
            conn.Close();

            DataRow dr = dt.Rows[0];
            rtn.BankCode = dr["BANK_CODE"].ToString();
            rtn.BankName = dr["BANK_NAME"].ToString();
            rtn.Name = dr["NAME"].ToString();
            rtn.Cash = decimal.Parse(dr["CASH"].ToString());
            rtn.Asset = decimal.Parse(dr["ASSET"].ToString());
            rtn.PWD = dr["PWD"].ToString();
            return rtn;
        }

        public DataTable TodayInfo(string ti)   //금일 입출금
        {
            DataTable dt = new DataTable();
            string sql = $@"SELECT C.NAME as NAME, A.ACODE, A.ASSET FROM financial_history A
						   LEFT JOIN ACCOUNT B 
                                  ON A.ACODE = B.ACODE             
                           LEFT JOIN CUSTOMER C   
							   	  ON B.PCODE = C.PCODE 
							   WHERE DATE_FORMAT(A.CDATE, '%Y-%m-%d') = CURDATE() 
                                 AND A.TRANS_INFO = @ti";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@ti", ti);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public BankDTO TodaySum(string ti)
        {
            BankDTO rtn = new BankDTO();
            DataTable dt = new DataTable();
            string sql = $@"SELECT SUM(ASSET) SUM
                            FROM financial_history
                            WHERE DATE_FORMAT(CDATE, '%Y-%m-%d') = CURDATE() 
                            AND TRANS_INFO = @ti";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@ti", ti);
            da.Fill(dt);
            conn.Close();

            DataRow dr = dt.Rows[0];
            try
            {
                rtn.SUM = int.Parse(dr["SUM"].ToString());
            }
            catch
            {
                rtn.SUM = 0;
            }
            return rtn;
        }

        public bool AdImageBLOB(int kcode, byte[] imaData)
        {
            string sql = @"INSERT INTO kiosk (KCODE, AD_IMAGE)
                                        VALUES (@KCODE, @AD_IMAGE)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("KCODE", kcode);
            cmd.Parameters.AddWithValue("@AD_IMAGE", imaData);
            conn.Open();
            int iRowAffect = cmd.ExecuteNonQuery();
            conn.Close();
            return (iRowAffect > 0);
        }

        public DataTable Week_Chart(string tansinfo) //tansinfo: 거래유형 //day: n일전
        {
            DataTable dt = new DataTable();
            string sql = $@"SELECT DATE_FORMAT(CDATE,'%Y-%m-%d') CDATE, IFNULL(SUM(ASSET),0) AS TOTASSET
                              FROM FINANCIAL_HISTORY
                              WHERE TRANS_INFO = @tansinfo
                           GROUP BY 1
                           ORDER BY 1
                              LIMIT 8";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@tansinfo", tansinfo);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
