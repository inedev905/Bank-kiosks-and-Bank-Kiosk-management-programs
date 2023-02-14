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
    public partial class frmKioskManagement : Form
    {
        private int SelRow = -1;
        private int kSelRow = -1;
        int ErrCnt = 0;

        public frmKioskManagement()
        {
            InitializeComponent();
            dtpHistoryDate1.Value = DateTime.Now.AddMonths(-1);
            dtpHistoryDate2.Value = DateTime.Now;
        }

        private void LoadData()
        {
            KioskDAO dao = new KioskDAO();
            DataTable dt = dao.GetKioskInfo(txtKiosk.Text);
            dgvKiosk.DataSource = dt;
            dao.Dispose();
            if (dgvKiosk.Rows.Count > 0)
            {
                SelRow = 0;
                string kCODE = dgvKiosk.Rows[SelRow].Cells["kCODE"].Value.ToString();
                KioskLoadData(kCODE);
            }
            else
                SelRow = -1;
        }

        private void txtKiosk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnKioskSearch.PerformClick();
        }

        private void frm_05_1_KIOSK관리_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmKioskPop pop = new frmKioskPop();
            if (pop.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    KioskDAO dao = new KioskDAO();
                    bool result = dao.KioskInsert(pop.KioskInfo);
                    dao.Dispose();
                    if (result)
                    {
                        LoadData();
                        MessageBox.Show("성공적으로 등록되었습니다.");
                    }
                }
                catch
                {
                    ErrCnt++;
                    if (ErrCnt > 5)
                        return;
                    btnSave.PerformClick();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (SelRow > -1)
            {
                string kCODE = dgvKiosk.Rows[SelRow].Cells["kCODE"].Value.ToString();
                frmKioskPop pop = new frmKioskPop(kCODE);
                if (pop.ShowDialog() == DialogResult.OK)
                {
                    KioskDAO dao = new KioskDAO();
                    bool result = dao.KioskUpdate(pop.KioskInfo);
                    dao.Dispose();
                    if (result)
                    {
                        LoadData();
                        MessageBox.Show("성공적으로 수정되었습니다.");
                    }
                    else
                        MessageBox.Show("수정중 오류가 발생했습니다. 다시 시도하여 주십시오.");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;
            else
            {
                DataGridViewSelectedRowCollection dr = dgvKiosk.SelectedRows;
                int rcnt = 0;
                foreach (DataGridViewRow drRow in dr)
                {
                    string kcode = drRow.Cells["kCODE"].Value.ToString();
                    KioskDAO dao = new KioskDAO();
                    rcnt += dao.KioskDelete(kcode);
                    dao.Dispose();
                }
                if (rcnt > 0)
                    MessageBox.Show($"{rcnt} 개가 성공적으로 삭제되었습니다.");
                else
                    MessageBox.Show("삭제중 오류가 발생했습니다. 다시 시도하여 주십시오.");

                LoadData();
                if (SelRow > -1 && kSelRow > -1)
                {
                    dgvKioskHistory.Rows.Clear();
                    LoadData();
                }
            }
        }

        private void dgvKiosk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            SelRow = e.RowIndex;
            string kCODE = dgvKiosk.Rows[e.RowIndex].Cells["kCODE"].Value.ToString();
            KioskLoadData(kCODE);
            if (dgvKioskHistory.Rows.Count > 0)
                kSelRow = 0;
            else
                kSelRow = -1;
        }

        private void KioskLoadData(string kCODE)
        {
            KioskDAO dao = new KioskDAO();
            DataTable dt = dao.GatKioskHistoryRow(kCODE, dtpHistoryDate1.Value.ToString("yyyy-MM-dd"), dtpHistoryDate2.Value.ToString("yyyy-MM-dd"));
            dgvKioskHistory.DataSource = dt;
            dao.Dispose();
        }

        private void btnKioskSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnKHistorySearch_Click(object sender, EventArgs e)
        {
            string kCODE = dgvKiosk.Rows[SelRow].Cells["kCODE"].Value.ToString();
            KioskLoadData(kCODE);
        }

        private void txtKiosk_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoadData();

            if (e.KeyCode == Keys.Escape)
            {
                txtKiosk.Text = "";
                LoadData();
            }
            txtKiosk.Focus();
        }

        private void dgvKiosk_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != (sender as DataGridView).NewRowIndex)
            {
                switch (e.ColumnIndex)
                {
                    case 3:
                        string num = e.Value.ToString();
                        int intNum;
                        if (Int32.TryParse(num, out intNum))
                        {
                            e.Value = string.Format("{0:#,##0}", intNum);
                            if (intNum < 1000000)
                                e.CellStyle.BackColor = Color.FromArgb(252, 219, 216);
                        }
                        else
                            e.Value = num;
                        break;

                    case 4:
                        string strDate = e.Value.ToString();
                        DateTime dateTime;
                        try
                        {
                            dateTime = DateTime.ParseExact(strDate, "yyyyMMdd", null);
                            e.Value = dateTime.ToString("yyyy년 MM월 dd일");
                        }
                        catch
                        {
                            e.Value = strDate;
                        }
                        break;
                }
            }
        }

        private void dgvKioskHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != (sender as DataGridView).NewRowIndex)
            {
                switch (e.ColumnIndex)
                {
                    case 2:
                        string num = e.Value.ToString();
                        int intNum;
                        if (Int32.TryParse(num, out intNum))
                            e.Value = string.Format("{0:#,##0}", intNum);
                        else
                            e.Value = num;
                        break;

                    case 3:
                        string strDate = e.Value.ToString();
                        DateTime dateTime;
                        try
                        {
                            dateTime = DateTime.ParseExact(strDate, "yyyyMMdd", null);
                            e.Value = dateTime.ToString("yyyy년 MM월 dd일");
                        }
                        catch
                        {
                            e.Value = strDate;
                        }
                        break;
                }
            }

        }

        private void frm_05_1_KIOSK관리_Shown(object sender, EventArgs e)
        {
            dgvKiosk.CurrentCell = null;
            dgvKioskHistory.CurrentCell = null;
        }
    }
}