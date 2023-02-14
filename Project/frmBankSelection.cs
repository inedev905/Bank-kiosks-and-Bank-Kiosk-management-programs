using System;
using System.Windows.Forms;

namespace Project
{
    public partial class frmBankSelection : Form
    {
        public frmBankSelection()
        {
            InitializeComponent();
        }

        private void btnBkn01_Click(object sender, EventArgs e)
        {
            Core.OTHER_BCODE = (sender as Button).Text;

            if (Core.TRANS_INFO == "TNS33")   //송금
            {
                Core.TRANS_INFO = "TNS03";
                Core.pMain.Controls.Clear();
                frmEnterAccount frm = new frmEnterAccount();
                Core.pMain.Controls.Add(frm.panAccount);
                this.Close();
            }

            if (Core.TRANS_INFO == "TNS04")    //무통장입금
            {
                Core.pMain.Controls.Clear();
                frmEnterAccount frm = new frmEnterAccount();
                Core.pMain.Controls.Add(frm.panAccount);
                this.Close();
            }
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
