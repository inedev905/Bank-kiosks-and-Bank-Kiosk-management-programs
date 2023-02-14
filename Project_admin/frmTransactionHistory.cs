using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_admin
{
    public partial class frmTransactionHistory : Form
    {
        string aCodee = "";
        public frmTransactionHistory(string aCode)
        {
            InitializeComponent();
            aCodee = aCode;
            dtpHistoryDate1.Value = DateTime.Now.AddMonths(-1);
            dtpHistoryDate2.Value = DateTime.Now;
            btnSearch.PerformClick();
        }

        private void dgvAccountHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != (sender as DataGridView).NewRowIndex)
            {
                switch (e.ColumnIndex)
                {
                    case 3:
                        string num = e.Value.ToString();
                        int intNum;
                        if (Int32.TryParse(num, out intNum))
                            e.Value = string.Format("{0:#,###}", intNum);
                        else
                            e.Value = num;
                        break;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)        //날짜검색버튼
        {
            CustomerDAO dao = new CustomerDAO();
            DataTable result = dao.AccountHistoryInfo(aCodee, dtpHistoryDate1.Value.ToString("yyyy-MM-dd"), dtpHistoryDate2.Value.AddDays(1).ToString("yyyy-MM-dd"));
            AccountDTO dto = dao.GetAccountInfoRow(aCodee);
            dgvAccountHistory.DataSource = result;
            lblAccountAsset.Text = $"{string.Format("{0:#,##0}", dto.Asset)}원";
            txtAcode.Text = dto.Acode;
            dao.Dispose();

            txtAcode.Text = txtAcode.Text.Substring(0, 4) + "-" + txtAcode.Text.Substring(4, 2) + "-" + txtAcode.Text.Substring(6, 4);
        }

        private void frm_03_4_거래이력_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void frm_03_4_거래이력_Shown(object sender, EventArgs e)
        {
            dgvAccountHistory.CurrentCell = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("이력조회를 종료하시겠습니까?", "이력조회 종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;
            this.Close();
        }
    }
}