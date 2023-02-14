using System;
using System.Windows.Forms;

namespace Project
{
    public partial class frmAmountEnter : Form
    {
        public frmAmountEnter()
        {
            InitializeComponent();
            cur키패드1.InputTextBox = txtCash;
            lblLimit.Visible = false;
            lblTotAsset.Text = $"계좌잔고  {string.Format("{0:#,##0}", Core.TotAsset)}";
            Road();
        }

        public void Road()
        {
            if (Core.TRANS_INFO == "TNS04")
            {
                lblAccount.Visible = false;
                lblTotAsset.Visible = false;
            }
            else if (Core.TRANS_INFO == "TNS06" || Core.TRANS_INFO == "TNS07")
            {
                lblTotAsset.Text = $"키오스크 보유금액  {string.Format("{0:#,##0}", Core.KCash)}원";
                lblAccount.Visible = false;
            }
            else
                lblAccount.Text = Core.ACODE.Substring(0, 4) + "-" + Core.ACODE.Substring(4, 2) + "-" + Core.ACODE.Substring(6, 4);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Core.TRANS_INFO == "TNS06" || Core.TRANS_INFO == "TNS07")
            {
                Core.AMOUNT = decimal.Parse(txtCash.Text);
                KioskInfoDAO kidao = new KioskInfoDAO();
                kidao.admin();
                kidao.Dispose();

                Core.pMain.Controls.Clear();
                frmAdmin frmadmin = new frmAdmin(decimal.Parse(txtCash.Text));
                Core.pMain.Controls.Add(frmadmin.panAdmin);
                this.Close();
            }
            else if (decimal.Parse(txtCash.Text) > Core.TotAsset && Core.TRANS_INFO == "TNS03"
                || decimal.Parse(txtCash.Text) > Core.TotAsset && Core.TRANS_INFO == "TNS02")
            {
                lblLimit.Text = $"잔액이 부족합니다.\n{string.Format("{0:#,##0}", Core.TotAsset)}원 이하 {Util.Tns()} 가능합니다.\n다시 입력하여 주십시오.";
                lblLimit.Visible = true;
                txtCash.Focus();
                txtCash.Clear();
                return;
            }
            else if (Core.TRANS_INFO == "TNS02" && decimal.Parse(txtCash.Text) > Core.KCash)
            {
                lblLimit.Text = $"키오스크의 현금이 부족하여\n{string.Format("{0:#,##0}", Core.KCash)}원 이하 {Util.Tns()} 가능합니다.\n죄송합니다. 다시 입력하여 주십시오.";
                lblLimit.Visible = true;
                txtCash.Clear();
                txtCash.Focus();
                return;
            }
            else
            {
                //Core.AMOUNT = decimal.Parse((sender as Button).Text.Replace("만원", "0000"));
                Core.pMain.Controls.Clear();
                frmOtherAccount frm = new frmOtherAccount();
                Core.pMain.Controls.Add(frm.panMsg);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)    //업무종료
        {
            Core.pMain.Controls.Clear();
            frmMain frm = new frmMain();
            Core.pMain.Controls.Add(frm.panBankMain);
            this.Close();
        }
    }
}
