using System;
using System.Data;
using System.Windows.Forms;

namespace Project
{
    public partial class frmEnterPwd : Form
    {
        public frmEnterPwd()
        {
            InitializeComponent();
            txtPwd.Focus();
            cur키패드1.InputTextBox = txtPwd;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Core.TRANS_INFO == "TNS06")
            {
                if (txtPwd.Text == Core.AdminPwd)
                {
                    Core.pMain.Controls.Clear();
                    frmAdmin frmadmin = new frmAdmin();
                    Core.pMain.Controls.Add(frmadmin.panAdmin);
                    this.Close();
                }
                else
                    ErrMsg();
            }
            else
            {
                AccountDAO dao = new AccountDAO();
                DataTable dt = dao.GetAccountInfo(Core.ACODE, txtPwd.Text);

                if (dt.Rows.Count > 0)
                {
                    Core.PWD = dt.Rows[0]["PWD"].ToString();
                    Core.PCODE = dt.Rows[0]["PCODE"].ToString();
                    Core.NAME = dt.Rows[0]["NAME"].ToString();
                    Core.TotAsset = dao.GetAsset();

                    if (Core.TRANS_INFO == "TNS01" || Core.TRANS_INFO == "TNS02")   //입출금
                    {
                        Core.pMain.Controls.Clear();
                        frm09_4금액선택화면 frmCash = new frm09_4금액선택화면();
                        Core.pMain.Controls.Add(frmCash.panCash1);
                        this.Close();
                    }
                    else if (Core.TRANS_INFO == "TNS33" || Core.TRANS_INFO == "TNS04")    //송금 //무통장
                    {
                        Core.pMain.Controls.Clear();
                        frmBankSelection frmbk = new frmBankSelection();
                        Core.pMain.Controls.Add(frmbk.panBank);
                        this.Close();
                    }
                    else if (Core.TRANS_INFO == "TNS05") //이력조회
                    {
                        Core.pMain.Controls.Clear();
                        frmHistoryCheck frmHist = new frmHistoryCheck();
                        Core.pMain.Controls.Add(frmHist.panHistory);
                        frmHist.btnSearch.PerformClick();
                        this.Close();
                    }
                    dao.Dispose();
                }
                else
                {
                    Core.XPWD++;    //오류횟수를 더해줌
                    ErrMsg();
                }
            }
        }

        public void ErrMsg()
        {
            Core.pMain.Controls.Clear();
            frmErrMsg frmerr = new frmErrMsg();
            Core.pMain.Controls.Add(frmerr.panErrMsg);
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Core.pMain.Controls.Clear();
            frmMain frm = new frmMain();
            Core.pMain.Controls.Add(frm.panBankMain);
            this.Close();
        }
    }
}
