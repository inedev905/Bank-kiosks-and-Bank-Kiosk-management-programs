using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public partial class frmEnterAccount : Form
    {
        public frmEnterAccount()
        {
            InitializeComponent();

            cur키패드1.InputTextBox = txtAccount;
            txtAccount.Focus();

            if (Core.TRANS_INFO == "TNS03" || Core.TRANS_INFO == "TNS04")   //송금//무통장입금
            {
                Font ft = new Font("나눔스퀘어 네오 OTF ExtraBold", 50);
                lblAccount.Font = ft;
                lblAccount.Text = "받으실 분의 \n 계좌번호를 \n 입력해주십시오.";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Core.TRANS_INFO == "TNS03" || Core.TRANS_INFO == "TNS04")    //송금 //무통장입금
            {
                Core.OTHER_ACODE = txtAccount.Text;
                Core.pMain.Controls.Clear();
                frm09_4금액선택화면 frmOther = new frm09_4금액선택화면();
                Core.pMain.Controls.Add(frmOther.panCash1);
                this.Close();
            }
            else
            {
                AccountDAO dao = new AccountDAO();
                DataTable dt = dao.GetAccountInfo(txtAccount.Text, null);
                if (dt.Rows.Count > 0)
                {
                    Core.ACODE = dt.Rows[0]["ACODE"].ToString();
                    Core.STATUS = dt.Rows[0]["STATUS"].ToString();
                    if (Core.STATUS == "Y")
                    {
                        Core.pMain.Controls.Clear();
                        frmErrMsg frmErr = new frmErrMsg();
                        Core.pMain.Controls.Add(frmErr.panErrMsg);
                        this.Close();
                    }
                    else //정상
                    {
                        Core.pMain.Controls.Clear();
                        frmEnterPwd frmPwd = new frmEnterPwd();
                        Core.pMain.Controls.Add(frmPwd.panPwd);
                        this.Close();
                    }
                }
                else
                {   //없는 계좌번호                    
                    Core.XID = 1;
                    Core.pMain.Controls.Clear();
                    frmErrMsg frmErr = new frmErrMsg();
                    Core.pMain.Controls.Add(frmErr.panErrMsg);
                    this.Close();
                }
                dao.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Core.pMain.Controls.Clear();
            frmMain frm = new frmMain();
            Core.pMain.Controls.Add(frm.panBankMain);
            this.Close();
        }
    }
}