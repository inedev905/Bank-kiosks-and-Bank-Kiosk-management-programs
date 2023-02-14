using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Project_admin
{
    public class CustomerDAO : IDisposable
    {
        string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        MySqlConnection conn = null;

        public CustomerDAO()
        {
            conn = new MySqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public DataTable GetCustomerInfo(string SearchText)
        {
            DataTable dt = new DataTable();
            string sql = @"select PCODE, NAME, PHONE, NBR from customer WHERE DELETED = 'N'";

            if (!string.IsNullOrEmpty(SearchText))
                sql += $" AND (NAME LIKE @SearchText OR PHONE LIKE @SearchText OR NBR LIKE @SearchText)";

            sql += $" ORDER BY NAME";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + SearchText + "%");
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public bool GetCustomercheck(string Nbr)
        {
            string sql = @"select count(NBR) from customer WHERE NBR = @Nbr";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Nbr", Nbr);
            conn.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            return (cnt > 0);
        }

        public bool GetAccountcheck(string txt)
        {
            string sql = @"select count(ACODE) from account WHERE ACODE = @txt or Card_No = @txt";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@txt", txt);
            conn.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return (cnt > 0);
        }

        public bool CustomerInsert(CustomerDTO ci)
        {
            string sql = @"INSERT INTO customer (PCODE, Name, Phone, Nbr, Email, Zip, Addr, Addrs)
                                     VALUES (@PCODE, @Name, @Phone, @Nbr, @Email, @Zip, @Addr, @Addrs)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@PCODE", ci.Pcode);
            cmd.Parameters.AddWithValue("@Name", ci.Name);
            cmd.Parameters.AddWithValue("@Phone", ci.Phone);
            cmd.Parameters.AddWithValue("@Nbr", ci.Nbr);
            cmd.Parameters.AddWithValue("@Email", ci.Email);
            cmd.Parameters.AddWithValue("@Zip", ci.Zip);
            cmd.Parameters.AddWithValue("@Addr", ci.Addr);
            cmd.Parameters.AddWithValue("@Addrs", ci.Addrs);
            conn.Open();
            int iRowAffect = cmd.ExecuteNonQuery();
            conn.Close();
            return (iRowAffect > 0);
        }


        public CustomerDTO GetCustomerInfoRow(string pCode)
        {
            CustomerDTO rtn = new CustomerDTO();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = $@"select PCODE, NAME, PHONE, NBR, Email, Zip, Addr, Addrs from customer WHERE PCODE = @pCode";
            da.SelectCommand = new MySqlCommand(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@pCode", pCode);
            da.Fill(ds, "customer");

            DataRow dr = ds.Tables[0].Rows[0];
            rtn.Pcode = dr["PCODE"].ToString();
            rtn.Name = dr["NAME"].ToString();
            rtn.Phone = dr["Phone"].ToString();
            rtn.Nbr = dr["Nbr"].ToString();
            rtn.Email = dr["Email"].ToString();
            rtn.Zip = dr["Zip"].ToString();
            rtn.Addr = dr["Addr"].ToString();
            rtn.Addrs = dr["Addrs"].ToString();
            return rtn;
        }

        public bool CustomerUpdate(CustomerDTO cu)
        {
            string sql = @"UPDATE customer
                            SET Name = @Name
	                            , Phone = @Phone
	                            , Nbr = @Nbr
	                            , Email = @Email
	                            , Zip = @Zip
	                            , Addr = @Addr
	                            , Addrs = @Addrs
                            WHERE PCODE = @pcode";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@pcode", cu.Pcode);
            cmd.Parameters.AddWithValue("@Name", cu.Name);
            cmd.Parameters.AddWithValue("@Phone", cu.Phone);
            cmd.Parameters.AddWithValue("@Nbr", cu.Nbr);
            cmd.Parameters.AddWithValue("@Email", cu.Email);
            cmd.Parameters.AddWithValue("@Zip", cu.Zip);
            cmd.Parameters.AddWithValue("@Addr", cu.Addr);
            cmd.Parameters.AddWithValue("@Addrs", cu.Addrs);
            conn.Open();
            int iRowAffect = cmd.ExecuteNonQuery();
            conn.Close();
            return (iRowAffect > 0);
        }

        public int CustomerDelete(string pCODE)
        {
            string sql = @"UPDATE CUSTOMER SET DELETED = 'Y' WHERE PCODE = @PCODE; 
                           UPDATE ACCOUNT SET DELETED = 'Y' WHERE PCODE = @PCODE";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@PCODE", pCODE);
            conn.Open();
            int iRowAffect = cmd.ExecuteNonQuery();
            conn.Close();
            return iRowAffect;
        }

        public AccountDTO GetAccountInfoRow(string aCode) //수정
        { //계좌번호 잔고 정지여부 카드여부
            AccountDTO rtn = new AccountDTO();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            string sql = $@"SELECT ACODE, PCODE, ASSET, PWD, Card_No, Card_Pwd, STATUS AS STATUS_YN
                            FROM ACCOUNT WHERE ACODE = @aCode";


            //string sql = $@"SELECT ACODE, PCODE, ASSET, PWD, Card_No, Card_Pwd, NVL2(STATUS,'N', 'Y') AS STATUS_YN
            //                FROM ACCOUNT WHERE ACODE = @aCode";
            da.SelectCommand = new MySqlCommand(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@aCode", aCode);
            da.Fill(ds, "account");
            DataRow dr = ds.Tables[0].Rows[0];
            rtn.Acode = dr["ACODE"].ToString();
            rtn.Pcode = dr["PCODE"].ToString();
            rtn.Pwd = dr["PWD"].ToString();
            rtn.Asset = decimal.Parse(dr["ASSET"].ToString());
            rtn.Status = dr["STATUS_YN"].ToString() == "Y" ? true : false;
            rtn.CardNo = dr["Card_No"].ToString();
            rtn.CardPwd = dr["Card_Pwd"].ToString();
            return rtn;
        }

        public DataTable GetAccountInfo(string pCode, string SearchText) //AccountLoadData //그리드뷰에 가져오는용도
        {
            DataTable dt = new DataTable();
            string sql = $@"SELECT ACODE, PCODE, ASSET, STATUS AS STATUS_YN,
                            case when CARD_NO = '' then 'N' else 'Y' end as CARD_YN
                            FROM ACCOUNT WHERE PCODE = @pCode  AND DELETED = 'N'";
            if (!string.IsNullOrEmpty(SearchText))
                sql += $" AND (ACODE LIKE @SearchText OR CARD_NO LIKE @SearchText)";

            sql += $" ORDER BY ACODE";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@pCode", pCode);
            da.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + SearchText + "%");
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public bool AccountInsert(AccountDTO ai)
        {
            string sql = @"INSERT INTO Account (pcode, acode, pwd, status, Card_No, CARD_PWD)
                                        VALUES (@pcode, @acode, @pwd, @status, @Card_No, @CARD_PWD)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@pcode", ai.Pcode);
            cmd.Parameters.AddWithValue("@acode", ai.Acode);
            cmd.Parameters.AddWithValue("@pwd", ai.Pwd);
            cmd.Parameters.AddWithValue("@status", ai.Status ? "Y" : "N");
            cmd.Parameters.AddWithValue("@Card_No", ai.CardNo);
            cmd.Parameters.AddWithValue("@CARD_PWD", ai.CardPwd);
            conn.Open();
            int iRowAffect = cmd.ExecuteNonQuery();
            conn.Close();
            return (iRowAffect > 0);
        }


        public bool AccountUpdate(AccountDTO au)
        {
            string sql = @"UPDATE Account 
                              SET pwd =@pwd
                                , status = @status
	                            , Card_No =@Card_No
	                            , CARD_PWD =@CARD_PWD 
                            WHERE Acode = @Acode";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@pcode", au.Pcode);
            cmd.Parameters.AddWithValue("@Acode", au.Acode);
            cmd.Parameters.AddWithValue("@pwd", au.Pwd);
            cmd.Parameters.AddWithValue("@status", au.Status ? "Y" : "N");
            cmd.Parameters.AddWithValue("@Card_No", au.CardNo);
            cmd.Parameters.AddWithValue("@CARD_PWD", au.CardPwd);
            conn.Open();
            int iRowAffect = cmd.ExecuteNonQuery();
            conn.Close();
            return (iRowAffect > 0);
        }

        public int AccountDelete(string Account)
        {
            string sql = @"UPDATE Account SET DELETED = 'Y' WHERE Acode = @Acode;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Acode", Account);
            conn.Open();
            int iRowAffect = cmd.ExecuteNonQuery();
            conn.Close();
            return iRowAffect;
        }

        public DataTable AccountHistoryInfo(string aCODE, string sDate, string eDate)
        {
            DataTable dt = new DataTable();
            string sql = $@"SELECT A.CDATE, B.CNAME AS TRANS_INFO, A.ASSET, A.OTHER_ANAME, A.FEE, A.MEMO 
                              FROM financial_history A 
                         LEFT JOIN common_code B ON A.TRANS_INFO = B.CCODE 
                             WHERE B.GCODE = 'TRANSCODE' 
                               AND A.aCODE = @aCODE 
                               AND DATE(A.cdate) Between @sDate AND @eDate
                             ORDER BY CDATE DESC";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@aCODE", aCODE);
            da.SelectCommand.Parameters.AddWithValue("@sDate", sDate);
            da.SelectCommand.Parameters.AddWithValue("@eDate", eDate);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
