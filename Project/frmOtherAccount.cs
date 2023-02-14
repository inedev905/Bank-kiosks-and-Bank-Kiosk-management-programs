using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public partial class frmOtherAccount : Form
    {
        public frmOtherAccount()
        {
            InitializeComponent();
            lblAmount.Text = $"{string.Format("{0:#,##0}", Core.AMOUNT)}원";
            road();
        }

        public void road()
        {
            panOther.Visible = false;
            if (Core.TRANS_INFO == "TNS03" || Core.TRANS_INFO == "TNS04")
            {
                panOther.Visible = true;
                AccountDAO dao = new AccountDAO();
                DataTable dt = dao.GetAccountInfo(Core.OTHER_ACODE, null);
                if (dt.Rows.Count > 0)
                {
                    txtOtherName.Text = Core.OTHER_ANAME = dt.Rows[0]["NAME"].ToString();
                    txtOtherName.ForeColor = Color.DimGray;
                }
                dao.Dispose();
            }
            else if (Core.TRANS_INFO != "TNS04")
                lblAccount.Text = Core.ACODE.Substring(0, 4) + "-" + Core.ACODE.Substring(4, 2) + "-" + Core.ACODE.Substring(6, 4);
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            Core.OTHER_ANAME = txtOtherName.Text;
            Core.OTHER_MSG = txtOtherMsg.Text;
            Core.MSG = txtMsg.Text;

            if (Core.TRANS_INFO == "TNS03" || Core.TRANS_INFO == "TNS04")
                if (string.IsNullOrEmpty(txtOtherName.Text))
                    lblErrMsg.Text = "받는 분을 입력해주세요.";
                else
                    panCustomer.Location = panOther.Location;

            Core.pMain.Controls.Clear();
            frmTransaction frmch = new frmTransaction();
            Core.pMain.Controls.Add(frmch.panCheck);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Core.pMain.Controls.Clear();
            frmMain frm = new frmMain();
            Core.pMain.Controls.Add(frm.panBankMain);
            this.Close();
        }

        private void btnKeyOn_Click(object sender, EventArgs e) //키보드ON
        {
            VKeyboard.showKeyboard();
            VKeyboard.moveWindow(100, 100, 100, 100);
            txtOtherName.Focus();
        }

        private void btnKeyOff_Click(object sender, EventArgs e) //키보드OFF
        {
            VKeyboard.hideKeyboard();
        }
    }
}
