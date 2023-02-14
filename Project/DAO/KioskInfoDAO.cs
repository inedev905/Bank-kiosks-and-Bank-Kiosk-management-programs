using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Project
{
    internal class KioskInfoDAO : IDisposable
    {
        string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        MySqlConnection conn = null;

        public KioskInfoDAO()
        {
            conn = new MySqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public string GetBank()
        {
            DataTable dt = new DataTable();
            string sql = $@"SELECT NAME FROM BANK WHERE BCODE = 'BKN01'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);
            conn.Close();
            return dt.Rows[0][0].ToString();
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


        public bool admin()
        {
            Core.FHCODE = Util.GetIDX("KH", 10);
            string sql = "";

            switch (Core.TRANS_INFO)
            {
                case "TNS06": // 관리자 입금 
                    sql = $@"START TRANSACTION;
                            INSERT INTO KIOSK_HISTORY(KHCODE, KCODE, TRANS_INFO, CASH)
                            VALUES (@FHCODE , @KCode, @TRANS_INFO, @AMOUNT);
                            UPDATE KIOSK SET CASH = CASH + @AMOUNT WHERE KCODE = @KCode;
                            COMMIT;";   
                    break;

                case "TNS07": // 관리자 인출
                    sql = $@"START TRANSACTION;
                            INSERT INTO KIOSK_HISTORY(KHCODE, KCODE, TRANS_INFO, CASH)
                            VALUES (@FHCODE, @KCode, @TRANS_INFO, @AMOUNT);
                            UPDATE KIOSK SET CASH = CASH - @AMOUNT WHERE KCODE = @KCode;
                            COMMIT;";   
                    break;
            }

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@FHCODE", Core.FHCODE);
            cmd.Parameters.AddWithValue("@KCode", Core.KCode);
            cmd.Parameters.AddWithValue("@TRANS_INFO", Core.TRANS_INFO);
            cmd.Parameters.AddWithValue("@AMOUNT", Core.AMOUNT);
            conn.Open();
            int iRowAffect = cmd.ExecuteNonQuery();
            conn.Close();
            return (iRowAffect > 0);
        }
    }
}
