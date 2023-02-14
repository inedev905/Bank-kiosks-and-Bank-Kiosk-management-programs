using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Project
{
    public partial class frmReceipt : Form
    {
        Timer timer = new Timer();
        int WaitTime = 20;
        PrintDocument pdt = new PrintDocument();

        public PrintDTO PrintInfo
        {
            get
            {
                return new PrintDTO
                {
                    Tnsinfo = lblTns.Text,
                    Cash = decimal.Parse(lblCash.Text),
                    State = lblState.Text,
                    TotAsset = decimal.Parse(lblTotAsset.Text),
                    Fee = decimal.Parse(lblFee.Text),
                    Cdate = lblCdate.Text,
                    Name = lblName.Text,
                    OtherAcode = lblOtherAcode.Text,
                    BankAddr = lblBankAddr.Text,
                    AName = lblAName.Text,
                    State2 = lblState.Text
                };
            }
            set
            {
                lblTns.Text = value.Tnsinfo.ToString();
                lblCash.Text = value.Cash.ToString();
                lblState.Text = value.TotAsset.ToString();
                lblTotAsset.Text = value.TotAsset.ToString();
                lblFee.Text = value.Fee.ToString();
                lblCdate.Text = value.Cdate.ToString();
                lblName.Text = value.Name.ToString();
                lblOtherAcode.Text = value.OtherAcode.ToString();
                lblBankAddr.Text = value.BankAddr.ToString();
                lblAName.Text = value.AName.ToString();
                lblState.Text = value.State2.ToString();
            }
        }

        public frmReceipt()
        {
            InitializeComponent();

            lblTns.Text = Util.Tns();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            lblBankName.Text = "구디은행";
            lblTns.Text = lblTns2.Text = $"[{Util.Tns()}]";
            lblCash.Text = lblCash2.Text = string.Format("{0:#,##0}", Core.AMOUNT); //금액
            lblState.Text = lblState2.Text = Core.PASS;

            if (Core.TRANS_INFO == "TNS01" || Core.TRANS_INFO == "TNS02" || Core.TRANS_INFO == "TNS03")
            {
                lblTotAsset.Text = lblTotAsset2.Text = string.Format("{0:#,##0}", Core.TotAsset); //잔액
            }
            else //무통장
            {
                lblTotAsset.Visible = false;
                lblTotAsset2.Visible = false;
                lblTotAssets.Visible = false;
                lblTotAssets2.Visible = false;
                lblWon.Visible = false;
                lblWon2.Visible = false;
            }

            lblFee.Text = lblFee2.Text = string.Format("{0:#,##0}", Core.FEE);  //수수료
            lblCdate.Text = lblCdate2.Text = DateTime.Now.ToString();           //거래일시
            lblName.Text = lblName2.Text = Core.NAME; //이름
            lblHFcode.Text = lblHFcode2.Text = Core.FHCODE;                     //거래코드
            lblOtherAcode.Text = lblOtherAcode2.Text = Core.OTHER_ACODE;
            lblBankAddr.Text = lblBankAddr2.Text = Core.Bname;                  //점포명
            lblAName.Text = lblAName2.Text = Core.OTHER_ANAME;
            lblStates.Text = lblStates2.Text = $"{Core.PASS}되었습니다. 감사합니다.";

            btnPrint.PerformClick();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            WaitTime -= 1;
            labWait.Text = $">> {WaitTime}초 후 메인화면으로 이동합니다.";
            if (WaitTime == 0)
            {
                timer.Stop();
                btnOK_Click(sender, e);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Core.pMain.Controls.Clear();
            frmMain frm = new frmMain();
            Core.pMain.Controls.Add(frm.panBankMain);
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)  //인쇄하기 버튼
        {
            timer.Stop();
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            pdt.PrintPage += Pd_PrintPage;
            ppd.Document = pdt;
            ppd.ShowDialog();
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap btp = new Bitmap(panVV.Width, panVV.Height);  //dgv 넓이와 높이만큼 만들어라
            Rectangle rg = new Rectangle(0, 0, panVV.Width, panVV.Height);

            panVV.DrawToBitmap(btp, rg); //dgv를 (이미지화해서) bitmap으로 그려라 //범위
            //e.Graphics.DrawImage(btp, this.Left, this.Top);
            e.Graphics.DrawImage(btp, e.MarginBounds.Left, e.MarginBounds.Top);
        }

        private void btnSet_Click(object sender, EventArgs e)  //페이지설정 버튼
        {
            timer.Stop();
            PageSetupDialog psd = new PageSetupDialog();
            //pdt = new PrintDocument();
            psd.Document = pdt;
            psd.ShowDialog();
        }
    }
}
