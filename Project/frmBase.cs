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
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            KioskInfoDAO kdao = new KioskInfoDAO();
            KioskDTO kdto = kdao.GetKioskInfoRow(Core.KCode);

            Core.Bname = kdao.GetBank();

            this.BackgroundImage = kdto.BACK_IMAGE;
            Core.ADImage = kdto.AD_IMAGE;
            Core.KName = kdto.NAME;
            Core.KCash = kdto.CASH;

            frmMain frm = new frmMain();
            Core.pMain = panMain;
            panMain.Controls.Add(frm.panBankMain);
            kdao.Dispose();
        }
    }
}
