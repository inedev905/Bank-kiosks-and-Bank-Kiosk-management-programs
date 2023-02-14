using System;
using System.Data;
using System.Windows.Forms;

namespace Project
{
    public partial class frmHistoryCheck : Form
    {
        public frmHistoryCheck()
        {
            InitializeComponent();

            txtAcode.Text = Core.ACODE.Substring(0, 4) + "-" + Core.ACODE.Substring(4, 2) + "-" + Core.ACODE.Substring(6, 4);
            lblName.Text = Core.NAME;
            dtpDate1.Value = DateTime.Now.AddMonths(-1);
            dtpDate2.Value = DateTime.Now;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Core.pMain.Controls.Clear();
            frmMain frm = new frmMain();
            Core.pMain.Controls.Add(frm.panBankMain);
            this.Close();
        }

        private void LoadData()
        {
            AccountDAO dao = new AccountDAO();
            DataTable dt = dao.GetAccountHistory(dtpDate1.Value.ToString("yyyy-MM-dd"), dtpDate2.Value.AddDays(1).ToString("yyyy-MM-dd"));
            dao.Dispose();

            if (dt.Rows.Count > 0)
                dgvTns05.DataSource = dt;
            else
            {
                dgvTns05.AutoGenerateColumns = false;
                dgvTns05.Columns[0].HeaderText = "데이터가 없습니다.";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)        //날짜검색 버튼
        {
            LoadData();
        }

        private void frm05_이력조회_Shown(object sender, EventArgs e)
        {
            dgvTns05.CurrentCell = null;
        }
    }
}
