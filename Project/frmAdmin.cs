using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            road();
        }

        public frmAdmin(decimal Cash)
        {
            InitializeComponent();
            road();
            lblMsg.Text = $"{Util.Tns()} \n {string.Format("{0:#,##0}", Cash)}원 \n 정상처리 되었습니다.";
        }

        public void road()
        {
            KioskInfoDAO kdao = new KioskInfoDAO();
            KioskDTO kdto = kdao.GetKioskInfoRow(Core.KCode);
            Core.KCash = kdto.CASH;
            kdao.Dispose();
            lblTotAsset.Text = $"키오스크 보유금액  {string.Format("{0:#,##0}", Core.KCash)}원";
        }

        private void btnInput_Click(object sender, EventArgs e) //관리자 현금 입금
        {
            Core.TRANS_INFO = "TNS06";
            Core.pMain.Controls.Clear();
            frmAmountEnter frm = new frmAmountEnter();
            Core.pMain.Controls.Add(frm.panCash2);
            this.Close();
        }

        private void btnOutput_Click(object sender, EventArgs e) //관리자 현금 인출
        {
            Core.TRANS_INFO = "TNS07";
            Core.pMain.Controls.Clear();
            frmAmountEnter frm = new frmAmountEnter();
            Core.pMain.Controls.Add(frm.panCash2);
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
