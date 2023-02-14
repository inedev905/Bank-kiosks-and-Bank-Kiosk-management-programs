using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Net;
using System.Xml;

namespace Project_admin
{
    public partial class frmZipPopup : Form
    {   //프로퍼티
        public string ZipCode { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }


        public frmZipPopup()
        {
            InitializeComponent();
            dgvZip.AutoGenerateColumns = false;

        }

        private void txtKeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Text;
            string zipAPIKey = ConfigurationManager.AppSettings["zipAPIKey"];
            string apiurl = $"https://business.juso.go.kr/addrlink/addrLinkApi.do?confmKey={zipAPIKey}&currentPage=1&countPerPage=100&keyword={keyword}";

            try
            {
                WebClient wc = new WebClient();
                XmlReader reader = new XmlTextReader(wc.OpenRead(apiurl));   //요청을하고 그 결과를 받아옴

                DataSet ds = new DataSet();
                ds.ReadXml(reader);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0]["errorCode"].ToString() == "0")   //정상이면
                    {
                        if (ds.Tables.Count > 1)
                            dgvZip.DataSource = ds.Tables[1];
                        else
                        {
                            dgvZip.DataSource = null;
                            MessageBox.Show("검색된 결과가 없습니다.");
                        }
                    }
                    else
                        MessageBox.Show(ds.Tables[0].Rows[0]["errorMessage"].ToString());   //에러메세지
                }
                else
                    MessageBox.Show("다시 시도하여 주십시오.", "도로명 API호출 중 오류발생");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvZip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            else
            {
                txtRoadZip.Text = txtJibunZip.Text = dgvZip[0, e.RowIndex].Value.ToString();  //내가클릭한셀의 0번째행의값
                txtRoadAddr1.Text = dgvZip[3, e.RowIndex].Value.ToString();  //내가클릭한셀의 0번째행의값
                txtRoadAddr2.Text = dgvZip[4, e.RowIndex].Value.ToString(); // + " " + dgvZip[2, e.RowIndex].Value.ToString();
                txtJibunAddr1.Text = dgvZip[5, e.RowIndex].Value.ToString();
                txtJibunAddr2.Text = "";
            }
        }

        private void btnRoad_Click(object sender, EventArgs e)
        {
            if (txtRoadZip.Text.Length < 1)
            {
                MessageBox.Show("도로명 검색을 먼저 해주십시오.");
                return;
            }
            ZipCode = txtRoadZip.Text;
            Addr1 = txtRoadAddr1.Text;
            Addr2 = txtRoadAddr2.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void btnJibun_Click(object sender, EventArgs e)
        {
            if (txtRoadZip.Text.Length < 1)
            {
                MessageBox.Show("지번 검색을 먼저 해주십시오.");
                return;
            }
            ZipCode = txtRoadZip.Text;
            Addr1 = txtJibunAddr1.Text;
            Addr2 = txtJibunAddr2.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtRoadAddr2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnRoad.PerformClick();
        }

        private void txtJibunAddr2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnJibun.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
