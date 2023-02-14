using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Project_admin
{
    class KioskDAO : IDisposable
    {
        string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        MySqlConnection conn = null;

        public KioskDAO()
        {
            conn = new MySqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public DataTable GetKioskInfo(string SearchText)
        {
            DataTable dt = new DataTable();
            string sql = @"select KCODE, BCODE, NAME, CASH, CDATE 
                            from Kiosk WHERE DELETED = 'N'";
            if (!string.IsNullOrEmpty(SearchText))
                sql += $" AND NAME LIKE @SearchText";
            sql += $" ORDER BY NAME";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + SearchText + "%");
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public bool KioskInsert(KioskDTO ci) //KCODE, BCODE, NAME, AD_IMAGE, BACK_IMAGE, CASH
        {
            string sql = @"INSERT INTO Kiosk (KCODE, BCODE, NAME, AD_IMAGE, BACK_IMAGE, CASH)
                                     VALUES (@KCODE, @BCODE, @NAME, @AD_IMAGE, @BACK_IMAGE,@CASH)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@KCODE", ci.KCODE);
            cmd.Parameters.AddWithValue("@BCODE", ci.BCODE);
            cmd.Parameters.AddWithValue("@NAME", ci.NAME);
            cmd.Parameters.AddWithValue("@AD_IMAGE", Util.ImageToByte(ci.AD_IMAGE));
            cmd.Parameters.AddWithValue("@BACK_IMAGE", Util.ImageToByte(ci.BACK_IMAGE));
            cmd.Parameters.AddWithValue("@CASH", ci.CASH);
            conn.Open();
            int iRowAffect = cmd.ExecuteNonQuery();
            conn.Close();
            return (iRowAffect > 0);
        }


        public KioskDTO GetKioskInfoRow(string kCode)
        {
            KioskDTO rtn = new KioskDTO();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            string sql = $@"select KCODE, BCODE, NAME, CASH from Kiosk WHERE KCODE = @kCode";
            da.SelectCommand = new MySqlCommand(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@kCode", kCode);
            da.Fill(ds, "customer");
            conn.Close();

            DataRow dr = ds.Tables[0].Rows[0];
            rtn.KCODE = dr["KCODE"].ToString();
            rtn.BCODE = dr["BCODE"].ToString();
            rtn.NAME = dr["NAME"].ToString();
            //rtn.AD_IMAGE = Util.ByteToImage((dr["AD_IMAGE"] as byte[]));
            //rtn.BACK_IMAGE = Util.ByteToImage((dr["BACK_IMAGE"] as byte[]));
            rtn.AD_IMAGE = Util.ByteToImage(SelectByte($"SELECT AD_IMAGE FROM Kiosk WHERE KCODE = '{kCode}'"));
            rtn.BACK_IMAGE = Util.ByteToImage(SelectByte($"SELECT BACK_IMAGE FROM Kiosk WHERE KCODE = '{kCode}'"));
            rtn.CASH = decimal.Parse(dr["CASH"].ToString());
            return rtn;
        }



        public byte[] SelectByte(string Query)
        {
            byte[] data = null;
            try
            {
                MySqlCommand cmd = new MySqlCommand(Query, conn);
                conn.Open();
                MySqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                    if (sdr[0] != null)
                        data = (byte[])sdr[0];
                sdr.Close();
                conn.Close();
            }
            catch (Exception)
            {
                return null;
            }
            return data;
        }

        public bool KioskUpdate(KioskDTO cu)
        { //KCODE, BCODE, NAME, AD_IMAGE, BACK_IMAGE, CASH
            string sql = @"UPDATE Kiosk
                            SET Name = @Name
	                            , AD_IMAGE = @AD_IMAGE
	                            , BACK_IMAGE = @BACK_IMAGE
	                            , CASH = @CASH
                            WHERE KCODE = @KCODE";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@KCODE", cu.KCODE);
            cmd.Parameters.AddWithValue("@BCODE", cu.BCODE);
            cmd.Parameters.AddWithValue("@NAME", cu.NAME);
            cmd.Parameters.AddWithValue("@AD_IMAGE", Util.ImageToByte(cu.AD_IMAGE));
            cmd.Parameters.AddWithValue("@BACK_IMAGE", Util.ImageToByte(cu.BACK_IMAGE));
            cmd.Parameters.AddWithValue("@CASH", cu.CASH);
            conn.Open();
            int iRowAffect = cmd.ExecuteNonQuery();
            conn.Close();
            return (iRowAffect > 0);
        }



        public int KioskDelete(string kCODE)
        {
            string sql = @"UPDATE Kiosk SET DELETED = 'Y' WHERE kCODE = @kCODE; 
                           UPDATE Kiosk_History SET DELETED = 'Y' WHERE kCODE = @kCODE";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kCODE", kCODE);
            conn.Open();
            int iRowAffect = cmd.ExecuteNonQuery();
            conn.Close();
            return iRowAffect;
        }

        public DataTable GatKioskHistoryRow(string kCode, string sDate, string eDate)
        {
            DataTable dt = new DataTable();
            //구분 현금 일시
            string sql = $@"    SELECT A.TRANS_INFO, B.CNAME AS TRANS_INFO_NAME, A.CASH, A.CDATE 
                                  FROM kiosk_history A 
                             LEFT JOIN common_code B
                                    ON A.TRANS_INFO = B.CCODE
                                 WHERE A.kCODE = @kCode
                                   AND B.GCODE = 'TRANSCODE'
                                   AND A.cdate Between STR_TO_DATE(@sDate, '%Y-%m-%d') AND STR_TO_DATE(@eDate, '%Y-%m-%d')
                                ORDER BY CDATE DESC";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@kCode", kCode);
            da.SelectCommand.Parameters.AddWithValue("@sDate", sDate);
            da.SelectCommand.Parameters.AddWithValue("@eDate", eDate);
            da.Fill(dt);
            conn.Close();
            return dt;
        }


    }

}