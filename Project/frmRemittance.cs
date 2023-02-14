using System;
using System.Windows.Forms;

namespace Project
{
    public partial class frmRemittance : Form
    {
        public frmRemittance()
        {
            InitializeComponent();
        }

        private void btnTns03_Click(object sender, EventArgs e) //송금 클릭
        {
            //Core.TRANS_INFO = "TNS03";
            Core.pMain.Controls.Clear();
            frmEnterAccount frm = new frmEnterAccount();
            Core.pMain.Controls.Add(frm.panAccount);
            this.Close();
        }

        private void btnTns04_Click(object sender, EventArgs e) //무통장입금 클릭
        {
            Core.TRANS_INFO = "TNS04";
            Core.pMain.Controls.Clear();
            frmBankSelection frm = new frmBankSelection();
            Core.pMain.Controls.Add(frm.panBank);
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Core.pMain.Controls.Clear();
            frmMain frm = new frmMain();
            Core.pMain.Controls.Add(frm.panBankMain);
            this.Close();
        }
    }
}
