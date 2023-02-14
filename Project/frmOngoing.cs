using System;
using System.Windows.Forms;

namespace Project
{
    public partial class frmOngoing : Form
    {
        Timer timer = new Timer();
        int WaitTime = 5;

        public frmOngoing()
        {
            InitializeComponent();

            lblTns.Text = Util.Tns();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            WaitTime -= 1;
            labWait.Text = $">> {WaitTime}초 후 거래확인 화면으로 이동합니다."; 
            if(WaitTime == 0)
            {
                timer.Stop();   
                btnOK_Click(sender, e);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Core.pMain.Controls.Clear();
            frmTransaction frm = new frmTransaction();
            Core.pMain.Controls.Add(frm.panCheck);               
            this.Close();
        }
    }
}
