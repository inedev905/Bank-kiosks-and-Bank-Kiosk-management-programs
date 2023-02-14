using System;
using System.Data;
using System.Windows.Forms;

namespace Project
{
    public partial class frmTransaction : Form
    {
        int ErrCnt = 0;

        public frmTransaction()
        {
            InitializeComponent();
            panVisible();
            Road();
        }

        public void panVisible()
        {
            if (Core.TRANS_INFO == "TNS01" || Core.TRANS_INFO == "TNS02")
            {
                panCheck3.Visible = false;
                panCheck1.Location = panCheck2.Location;
                panCheck2.Location = panCheck3.Location;
            }

            if (Core.TRANS_INFO == "TNS04")
            {
                panCheck2.Visible = false;
                panCheck1.Location = panCheck2.Location;
            }
        }

        public void Road()
        {
            if (Core.OTHER_BCODE != "구디은행" && Core.OTHER_BCODE != "") Core.FEE = 500;

            if (Core.TRANS_INFO == "TNS01" || Core.TRANS_INFO == "TNS02")
                lblMainMsg1.Text = $"{Core.NAME}님";
            else
                lblMainMsg1.Text = $"{Core.OTHER_ANAME}님께";

            switch (Core.STYPE)
            {
                case "거래확인":

                    lblFee.Text = Core.FEE.ToString();
                    lblTitle.Text = Core.STYPE;
                    lblMainMsg2.Text = $"{string.Format("{0:#,##0}", Core.AMOUNT)}원을\n{Util.Tns()}합니다.";
                    lblTotAsset2.Text = $"잔액";
                    lblMsg.Text = "맞으시면 '다음' 아니시면 '취소'를 눌러주세요.";
                    btnOK.Text = "다음";
                    btnCancel.Text = "취소";
                    break;

                case "거래완료":
                    AccountDAO dao = new AccountDAO();
                    try
                    {
                        if (Core.OTHER_BCODE == "구디은행")
                        {
                            DataTable dt = dao.GetAccountInfo(Core.OTHER_ACODE, null);
                            if (dt.Rows.Count > 0)
                                dao.SameBank();
                        }
                        dao.TranInsert();  //DB에 INSERT

                        if (Core.TRANS_INFO == "TNS01" || Core.TRANS_INFO == "TNS02" || Core.TRANS_INFO == "TNS03")  // 무통장,관리자 아니면
                        {
                            Core.TotAsset = dao.GetAsset();
                            lblTotAsset.Text = string.Format("{0:#,##0}", Core.TotAsset);
                        }
                    }
                    catch
                    {
                        Road();
                        ErrCnt++;
                        if (ErrCnt > 5)
                        {
                            MessageBox.Show("오류");
                            btnOK.PerformClick();
                        }
                    }
                    finally
                    {
                        dao.Dispose();
                        lblTitle.Text = Core.STYPE;
                        lblTotAsset2.Text = $"{Util.Tns()}후 잔액";
                        lblMainMsg2.Text = $"{string.Format("{0:#,##0}", Core.AMOUNT)}원\n{Util.Tns()}이 완료되었습니다.";
                        lblMsg.Text = "명세표출력을 원하시면 '명세표출력'을 눌러주세요.";
                        btnOK.Text = "확인";
                        btnCancel.Text = "명세표 출력";
                    }
                    break;
            };

            lblTnsInfo.Text = Util.Tns();
            lblTnsInfo2.Text = $"{Util.Tns()}계좌";
            lblTotAsset.Text = string.Format("{0:#,##0}", Core.TotAsset);
            lblAmount.Text = string.Format("{0:#,##0}", Core.AMOUNT);
            lblFee.Text = string.Format("{0:#,##0}", Core.FEE);
            lblAccount.Text = lblAccount2.Text = Core.ACODE;
            lblOtherAccount.Text = Core.OTHER_ACODE;
            lblOtherName.Text = Core.OTHER_ANAME;
            lblMemo.Text = Core.MSG;
            lblOtherMsg.Text = Core.OTHER_MSG;
        }

        private void btnok_click(object sender, EventArgs e)
        {
            Core.pMain.Controls.Clear();
            switch (Core.STYPE)
            {
                case "거래확인":
                    frmOngoing frm = new frmOngoing();
                    Core.pMain.Controls.Add(frm.panMsg);
                    Core.STYPE = "거래완료";
                    break;

                case "거래완료":
                    frmMain frm1 = new frmMain();
                    Core.pMain.Controls.Add(frm1.panBankMain);
                    break;
            };
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Core.pMain.Controls.Clear();
            if (btnCancel.Text == "취소")
            {
                frmMain frm = new frmMain();
                Core.pMain.Controls.Add(frm.panBankMain);
            }
            else
            {
                frmReceipt frmm = new frmReceipt();
                Core.pMain.Controls.Add(frmm.panPrint);
            }
            this.Close();
        }
    }
}
