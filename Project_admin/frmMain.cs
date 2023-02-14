using System;
using System.Windows.Forms;

namespace Project_admin
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void tsrBankInfo_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["은행관리"];
            if (form == null)
                form = new frmBankingManagement();

            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            form.Activate();
            form.BringToFront();
        }

        private void tsrAssetInfo_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["자산관리"];
            if (form == null)
                form = new frmAssetManagement();

            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            form.Activate();
            form.BringToFront();
        }

        private void tsrCustomerInfo_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["고객및계좌관리"];
            if (form == null)
                form = new frmCustomerAccountManagement();

            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            form.Activate();
            form.BringToFront();
        }

        private void tsrKioskInfo_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["KIOSK관리"];
            if (form == null)
                form = new frmKioskManagement();

            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            form.Activate();
            form.BringToFront();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 닫으시겠습니까?", "끝내기", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;

            Application.Exit();
        }

        private void frm_02_메인화면_Load(object sender, EventArgs e)
        {
            this.Visible = false;

            frmAdminPwd login = new frmAdminPwd();
            if (login.ShowDialog(this) == DialogResult.OK)
            {
                this.Visible = true;
                frmDeciboard frm = new frmDeciboard();
                frm.WindowState = FormWindowState.Maximized;
                frm.MdiParent = this;
                frm.Show();
            }
            else
                Application.Exit();
        }

        private void tsbHome_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["데시보드"];
            if (form == null)
                form = new frmDeciboard();

            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            form.Activate();
            form.BringToFront();
        }
    }
}
