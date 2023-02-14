using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Project_admin
{
    public partial class frmCustomerAccountManagement : Form
    {
        private int SelRow = -1;
        private int ASelRow = -1;
        int ErrCnt = 0;

        public frmCustomerAccountManagement()
        {
            InitializeComponent();
            btnHISTORY.BackColor = Color.FromArgb(255, 246, 225);
        }

        private void frm_03_1_고객및계좌관리_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            CustomerDAO dao = new CustomerDAO();
            DataTable dt = dao.GetCustomerInfo(txtCustomer.Text);
            dgvCustmer.DataSource = dt;
            dao.Dispose();
            if (dgvCustmer.Rows.Count > 0)
                SelRow = 0;
            else
                SelRow = -1;
            AccountLoadData(txtCustomer.Text);
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            frmCustomerPop pop = new frmCustomerPop();
            if (pop.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    CustomerDAO dao = new CustomerDAO();
                    bool result = dao.CustomerInsert(pop.CustomerInfo);
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
                    btnCustomerAdd.PerformClick();
                }
            }
        }

        private void btnCustomerEdit_Click(object sender, EventArgs e)
        {
            if (SelRow < 0)
            {
                MessageBox.Show("수정할 고객을 선택해주십시오.");
                return;
            }
            else if (SelRow > -1)
            {
                string pCODE = dgvCustmer.Rows[SelRow].Cells["pPCODE"].Value.ToString();
                frmCustomerPop pop = new frmCustomerPop(pCODE);
                if (pop.ShowDialog() == DialogResult.OK)
                {
                    CustomerDAO dao = new CustomerDAO();
                    bool result = dao.CustomerUpdate(pop.CustomerInfo);
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

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            if (SelRow < 0)
            {
                MessageBox.Show("삭제할 고객을 선택해주십시오.");
                return;
            }
            else if (MessageBox.Show("삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;
            else
            {

                DataGridViewSelectedRowCollection dr = dgvCustmer.SelectedRows;
                int rcnt = 0;
                foreach (DataGridViewRow drRow in dr)
                {
                    string pcode = drRow.Cells["pPCODE"].Value.ToString();
                    CustomerDAO dao = new CustomerDAO();
                    rcnt += dao.CustomerDelete(pcode);
                    dao.Dispose();
                }

                if (rcnt > 0)
                    MessageBox.Show($"{rcnt} 개가 성공적으로 삭제되었습니다.");
                else
                    MessageBox.Show("삭제중 오류가 발생했습니다. 다시 시도하여 주십시오.");

                LoadData();
                if (SelRow > -1 && ASelRow > -1)
                {
                    dgvAccount.Rows.Clear();
                    string pCODE = dgvCustmer.Rows[SelRow].Cells["pPCODE"].Value.ToString();
                    AccountLoadData(pCODE);
                }
            }
        }

        private void btnAccountSearch_Click(object sender, EventArgs e)
        {
            string pCODE = dgvCustmer.Rows[SelRow].Cells["pPCODE"].Value.ToString();
            AccountLoadData(pCODE);
        }

        private void dgvCustmer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvAccount.CurrentCell = null;

            //클릭한 고객의 계좌번호.잔고,정지유무,카드유무를 보여줘야함
            if (e.RowIndex < 0)
                return;

            SelRow = e.RowIndex;
            string pCODE = dgvCustmer.Rows[e.RowIndex].Cells["pPCODE"].Value.ToString();
            AccountLoadData(pCODE);
            if (dgvAccount.Rows.Count > 0)
                ASelRow = 0;
            else
                ASelRow = -1;
        }

        private void AccountLoadData(string pCODE)
        {
            CustomerDAO dao = new CustomerDAO();
            DataTable dt = dao.GetAccountInfo(pCODE, txtAccount.Text);
            dgvAccount.DataSource = dt;
            dao.Dispose();
        }

        private void btnAccountAdd_Click(object sender, EventArgs e)
        {
            if (SelRow < 0)
            {
                MessageBox.Show("계좌를 추가할 고객을 선택해주십시오.");
                return;
            }
            string pCODE = dgvCustmer.Rows[SelRow].Cells["pPCODE"].Value.ToString();
            frmAccountPop pop = new frmAccountPop(pCODE);
            if (pop.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    CustomerDAO dao = new CustomerDAO();
                    bool result = dao.AccountInsert(pop.AccountInfoAdd);
                    dao.Dispose();
                    if (result)
                    {
                        AccountLoadData(pCODE);
                        MessageBox.Show("성공적으로 등록되었습니다.");
                    }
                }
                catch
                {
                    ErrCnt++;
                    if (ErrCnt > 5)
                        return;
                    btnAccountAdd.PerformClick();
                }
            }
        }

        private void btnAccountEdit_Click(object sender, EventArgs e)
        {
            if (SelRow < 0 && ASelRow <= 0)
            {
                MessageBox.Show("계좌를 수정할 고객을 선택해주십시오.");
                return;
            }
            else if (ASelRow < 0)
            {
                MessageBox.Show("수정할 계좌를 선택해주십시오.");
            }
            else if (SelRow > -1 && ASelRow > -1)
            {
                string pCODE = dgvCustmer.Rows[SelRow].Cells["pPCODE"].Value.ToString();
                string aCODE = dgvAccount.Rows[ASelRow].Cells["aACODE"].Value.ToString();

                frmAccountPop pop = new frmAccountPop(pCODE, aCODE);
                if (pop.ShowDialog() == DialogResult.OK)
                {
                    CustomerDAO dao = new CustomerDAO();
                    bool result = dao.AccountUpdate(pop.AccountInfoEdit);
                    dao.Dispose();
                    if (result)
                        MessageBox.Show("성공적으로 수정되었습니다.");
                    else
                        MessageBox.Show("수정중 오류가 발생했습니다. 다시 시도하여 주십시오.");
                    AccountLoadData(pCODE);
                }
            }
        }

        private void btnAccountDelete_Click(object sender, EventArgs e)
        {
            if (SelRow < 0 && ASelRow <= 0)
            {
                MessageBox.Show("계좌를 삭제할 고객을 선택해주십시오.");
                return;
            }
            else if (ASelRow < 0)
            {
                MessageBox.Show("삭제할 계좌를 선택해주십시오.");
                return;
            }
            else if (MessageBox.Show("삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;
            else
            {
                string pCODE = dgvCustmer.Rows[SelRow].Cells["pPCODE"].Value.ToString();
                DataGridViewSelectedRowCollection dr = dgvAccount.SelectedRows;
                int rcnt = 0;
                foreach (DataGridViewRow drRow in dr)
                {
                    string aCode = drRow.Cells["aACODE"].Value.ToString();
                    CustomerDAO dao = new CustomerDAO();
                    rcnt += dao.AccountDelete(aCode);
                    dao.Dispose();
                }
                if (rcnt > 0)
                    MessageBox.Show($"{rcnt} 개가 성공적으로 삭제되었습니다.");
                else
                    MessageBox.Show("삭제중 오류가 발생했습니다. 다시 시도하여 주십시오.");
                AccountLoadData(pCODE);
            }
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ASelRow = e.RowIndex;
        }

        private void btnHISTORY_Click(object sender, EventArgs e)
        {
            if (SelRow > -1 && ASelRow > -1)
            {
                //string pCODE = dgvCustmer.Rows[SelRow].Cells["pPCODE"].Value.ToString();
                string aCODE = dgvAccount.Rows[ASelRow].Cells["aACODE"].Value.ToString();
                frmTransactionHistory frm = new frmTransactionHistory(aCODE);
                frm.ShowDialog();
            }
            else
                MessageBox.Show("이력을 확인 할 계좌를 선택해주십시오.");
        }

        private void dgvAccount_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != (sender as DataGridView).NewRowIndex)
            {
                switch (e.ColumnIndex)
                {
                    //case 1: //계좌번호
                    //    if (e.Value.ToString().Length > 1)
                    //        e.Value = e.Value.ToString().Substring(0, 4) + "-"
                    //            + e.Value.ToString().Substring(4, 2) + "-"
                    //            + e.Value.ToString().Substring(6, 4);
                    //    break;

                    //case 1: //계좌번호
                    //    string str = e.Value.ToString();
                    //    if (str.Length > 1)
                    //        str = str.Substring(0, 4) + "-"
                    //            + str.Substring(4, 2) + "-"
                    //            + str.Substring(6, 4);
                    //    break;

                    case 2: //잔고
                        string num = e.Value.ToString();
                        int intNum;
                        if (Int32.TryParse(num, out intNum))
                            e.Value = string.Format("{0:#,##0}", intNum);
                        else
                            e.Value = num;

                        break;
                }
            }
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtCustomer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoadData();

            if (e.KeyCode == Keys.Escape)
            {
                txtCustomer.Text = txtAccount.Text = "";
                LoadData();
            }
            txtCustomer.Focus();
        }

        private void txtAccount_KeyUp(object sender, KeyEventArgs e)
        {
            string pCODE = dgvCustmer.Rows[SelRow].Cells["pPCODE"].Value.ToString();

            if (e.KeyCode == Keys.Enter)
                AccountLoadData(pCODE);

            if (e.KeyCode == Keys.Escape)
            {
                txtAccount.Text = "";
                AccountLoadData(pCODE);
            }
            txtAccount.Focus();
        }

        private void frm_03_1_고객및계좌관리_Shown(object sender, EventArgs e)
        {
            dgvCustmer.CurrentCell = null;
            dgvAccount.CurrentCell = null;
        }

        private void dgvCustmer_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != (sender as DataGridView).NewRowIndex)
            {
                switch (e.ColumnIndex)
                {
                    case 3: //주민번호
                        if (e.Value.ToString().Length == 13)
                            e.Value = e.Value.ToString().Substring(0, 6) + "-"
                                + e.Value.ToString().Substring(6, 7);
                        break;

                    case 4: //연락처   //***안탄다..
                        if (e.Value.ToString().Length > 1)
                            e.Value = e.Value.ToString().Substring(0, 3) + "-"
                                + e.Value.ToString().Substring(3, 4) + "-"
                                + e.Value.ToString().Substring(7, 4);
                        break;
                }
            }
        }
    }
}
