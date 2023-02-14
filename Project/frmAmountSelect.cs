using System;
using System.Windows.Forms;

namespace Project
{
    public partial class frm09_4금액선택화면 : Form
    {
        public frm09_4금액선택화면()
        {
            InitializeComponent();
            lblLimit.Visible = false;
            lblTotAsset2.Text = "계좌잔고";
            lblTotAsset.Text = string.Format("{0:#,##0}", Core.TotAsset);
            Road();
        }

        public void Road()
        {
            if (Core.TRANS_INFO == "TNS04")
            {
                lblAccount.Visible = false;
                lblTotAsset.Visible = false;
                lblTotAsset2.Visible = false;
            }
            else
                lblAccount.Text = Core.ACODE.Substring(0, 4) + "-" + Core.ACODE.Substring(4, 2) + "-" + Core.ACODE.Substring(6, 4);
        }

        private void btnCash1_Click(object sender, EventArgs e)
        {
            decimal btncash = decimal.Parse((sender as Button).Text.Replace("만원", "0000"));

            if (btncash > Core.TotAsset && Core.TRANS_INFO == "TNS03"
                || btncash > Core.TotAsset && Core.TRANS_INFO == "TNS02")
            {
                string totasset = string.Format("{0:#,##0}", Core.TotAsset);
                lblLimit.Text = $"잔액이 부족합니다.\n{totasset}원 이하\n{Util.Tns()} 가능합니다.\n다시 입력하여 주십시오.";
                lblLimit.Visible = true;
                return;
            }
            else if (Core.TRANS_INFO == "TNS02" && btncash > Core.KCash)
            {
                string kcash = string.Format("{0:#,##0}", Core.KCash);
                lblLimit.Text = $"키오스크의 현금이 부족하여\n{kcash}원 이하\n{Util.Tns()} 가능합니다.\n죄송합니다. 다시 입력하여 주십시오.";
                lblLimit.Visible = true;
                return;
            }
            else
            {
                Core.AMOUNT = decimal.Parse((sender as Button).Text.Replace("만원", "0000"));
                Core.pMain.Controls.Clear();
                frmOtherAccount frm = new frmOtherAccount();
                Core.pMain.Controls.Add(frm.panMsg);
                this.Close();
            }
        }

        private void btnCashSelf_Click(object sender, EventArgs e)  //직접입력
        {
            Core.pMain.Controls.Clear();
            frmAmountEnter frm = new frmAmountEnter();
            Core.pMain.Controls.Add(frm.panCash2);
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)  //업무종료
        {
            Core.pMain.Controls.Clear();
            frmMain frm = new frmMain();
            Core.pMain.Controls.Add(frm.panBankMain);
            this.Close();
        }
    }
}