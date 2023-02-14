using System;
using System.Windows.Forms;
using System.Drawing;

using System.Runtime.InteropServices;

namespace Project
{
    public partial class frmMain : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public frmMain()
        {
            InitializeComponent();

            panAD.BackgroundImage = Core.ADImage;
            lblBankName.Text = "구디은행";
            lblBankAddrName.Text = Core.KName;
            reset();
            road();
        }

        private void road()
        {
            btnTns01.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnTns01.Width, btnTns01.Height, 50, 50));
            btnTns02.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnTns02.Width, btnTns02.Height, 50, 50));
            btnTns03.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnTns03.Width, btnTns03.Height, 50, 50));
            btnTns05.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnTns05.Width, btnTns05.Height, 50, 50));
            btnAdmin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAdmin.Width, btnAdmin.Height, 30, 30));
        }

        private void btnTns01_Click(object sender, EventArgs e) //입금버튼
        {
            Core.TRANS_INFO = "TNS01";
            Core.pMain.Controls.Clear();
            frmEnterAccount frm = new frmEnterAccount();
            Core.pMain.Controls.Add(frm.panAccount);
            this.Close();
        }

        private void btnTns02_Click(object sender, EventArgs e) //출금버튼
        {
            Core.TRANS_INFO = "TNS02";
            Core.pMain.Controls.Clear();
            frmEnterAccount frm = new frmEnterAccount();
            Core.pMain.Controls.Add(frm.panAccount);
            this.Close();
        }

        private void btnTns03_Click(object sender, EventArgs e) //송금버튼
        {
            Core.TRANS_INFO = "TNS33";
            Core.pMain.Controls.Clear();
            frmRemittance frm = new frmRemittance();
            Core.pMain.Controls.Add(frm.panTns);
            this.Close();
        }

        private void btnTns04_Click(object sender, EventArgs e) //이력조회버튼
        {
            Core.TRANS_INFO = "TNS05";
            Core.pMain.Controls.Clear();
            frmEnterAccount frm = new frmEnterAccount();
            Core.pMain.Controls.Add(frm.panAccount);
            this.Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e) //관리자버튼
        {
            Core.TRANS_INFO = "TNS06";
            Core.pMain.Controls.Clear();
            frmEnterPwd frm = new frmEnterPwd();
            Core.pMain.Controls.Add(frm.panPwd);
            this.Close();
        }

        public void reset()
        {
            Core.TRANS_INFO = "";
            Core.PCODE = "";
            Core.NAME = "";
            Core.ACODE = "";
            Core.PWD = "";
            Core.AMOUNT = 0;
            Core.TotAsset = 0;

            Core.OTHER_ANAME = "";
            Core.OTHER_BCODE = "";
            Core.OTHER_ACODE = "";
            Core.FEE = 0;
            Core.MSG = "";

            Core.STATUS = "";
            Core.XPWD = 0;  //비밀번호 오류횟수

            Core.STYPE = "거래확인";
            Core.FHCODE = "";
        }
    }
}
