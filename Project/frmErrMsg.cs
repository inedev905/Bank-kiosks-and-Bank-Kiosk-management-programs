using System;
using System.Windows.Forms;

namespace Project
{
    public partial class frmErrMsg : Form
    {
        Timer timer = new Timer();
        int WaitTime = 5;

        public frmErrMsg()
        {
            InitializeComponent();

            panErr1.Visible = true;
            Road();

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        public void Road()
        {
            if (Core.XPWD > 0 && Core.XPWD < 5)
            {
                lblErrMsg.Text = $"비밀번호 {Core.XPWD}회 오류입니다. \n 비밀번호를 다시 입력해주세요.";
                lblErrMsg2.Text = "(5회 오류 시 계좌가 정지됩니다.)";
            }
            else if (Core.XPWD == 5)
            {
                lblErrMsg.Text = $"비밀번호 {Core.XPWD}회 오류입니다. \n 귀하의 계좌가 정지되었습니다.";
                lblErrMsg2.Text = "(가까운 영업점에 문의하시기 바랍니다.)";

                AccountDAO adao = new AccountDAO();
                adao.AccountBreak();  //계좌 정지 처리
                adao.Dispose();
            }
            else if (Core.XID == 1)
            {
                lblErrMsg.Text = $"입력하신 계좌번호는 \n 유효한 계좌번호가 아닙니다.";
                lblErrMsg2.Text = "(계좌번호를 정확하게 입력해주시기 바랍니다.)";
            }
            else if (Core.STATUS == "Y")
            {
                lblErrMsg.Text = $"귀하의 계좌는 \n 거래가 정지된 계좌입니다.";
                lblErrMsg2.Text = "(가까운 영업점에 문의하시기 바랍니다.)";
            }
            else if (Core.TRANS_INFO == "TNS06")
            {
                lblErrMsg.Text = $"입력하신 관리자번호는 \n 유효한 관리자번호가 아닙니다.";
                lblErrMsg2.Text = "(관리자번호를 정확하게 입력해주시기 바랍니다.)";
            }
            else
                btnHome.PerformClick();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            WaitTime -= 1;
            labWait.Text = $">> {WaitTime}초 후 이전화면으로 이동합니다.";
            if (WaitTime == 0)
            {
                timer.Stop();
                btnRe_Click(sender, e);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Core.pMain.Controls.Clear();
            frmMain frm = new frmMain();
            Core.pMain.Controls.Add(frm.panBankMain);
            this.Close();
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Core.pMain.Controls.Clear();
            if (Core.XID == 1)   //없는계좌
            {
                frmEnterAccount frmac = new frmEnterAccount();
                Core.pMain.Controls.Add(frmac.panAccount);
            }
            else if ((Core.XPWD > 0 && Core.XPWD < 5) || Core.TRANS_INFO == "TNS06")  //비번오류
            {
                frmEnterPwd frmpwd = new frmEnterPwd();
                Core.pMain.Controls.Add(frmpwd.panPwd);
            }
            else
            {
                frmMain frmMain = new frmMain();
                Core.pMain.Controls.Add(frmMain.panBankMain);
            }
            this.Close();
        }
    }
}
