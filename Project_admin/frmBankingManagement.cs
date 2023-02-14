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
    public partial class frmBankingManagement : Form
    {
        public BankDTO BankInfo
        {
            get
            {
                return new BankDTO
                {
                    Name = txtBankName.Text,
                    PWD = txtPWD1.Text,
                    Cash = decimal.Parse(lblCash.Text),
                    Asset = decimal.Parse(lblAsset.Text)
                };
            }
            set
            {
                txtBankName.Text = value.Name;
                txtPWD1.Text = value.PWD.ToString();
                lblCash.Text = value.Cash.ToString();
                lblAsset.Text = value.Asset.ToString();
            }
        }

        public frmBankingManagement()
        {
            InitializeComponent();
            string BCODE = "BKN01";
            BankDAO dao = new BankDAO();
            BankDTO dto = dao.BankSelect(BCODE);
            lblCash.Text = string.Format("{0:#,##0}", dto.Cash);
            lblAsset.Text = string.Format("{0:#,##0}", dto.Asset);

            txtBankName.Text = dto.Name.ToString();
            txtPWD1.Text = dto.PWD.ToString();
            dao.Dispose();
        }

        private void frm_04_1_은행관리_Load(object sender, EventArgs e)
        {
            lblPWD1.Visible = false;
            lblPWD2.Visible = false;
        }

        private void txtPWD1_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPWD1.Text))
                lblPWD1.Visible = true;
        }

        private void txtPWD2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPWD2.Text))
                lblPWD2.Visible = true;
            else if (txtPWD1.Text != txtPWD2.Text)
            {
                lblPWD2.Visible = true;
                lblPWD2.Text = "*비밀번호를 동일하게 입력해주십시오.";
            }
            else
                lblPWD2.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPWD1.Text)
                || string.IsNullOrWhiteSpace(txtPWD2.Text))
            {
                MessageBox.Show("패스워드를 입력해주세요.");
                return;
            }

            if (txtPWD1.Text != txtPWD2.Text)
            {
                MessageBox.Show("비밀번호가 서로 다릅니다. 다시 입력해주세요.");
                return;
            }

            string name = txtBankName.Text;
            string pwd = txtPWD1.Text;

            BankDAO dao = new BankDAO();
            bool result = dao.Bank(name, pwd);
            dao.Dispose();
            if (result)
                MessageBox.Show("등록성공");
            else
                MessageBox.Show("등록실패");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["frm_00_데시보드"];
            if (form == null)
                form = new frmDeciboard();

            form.WindowState = FormWindowState.Maximized;
            form.Show();
            form.Activate();
            form.BringToFront();
            this.Close();
            DialogResult = DialogResult.Cancel;
        }

        private void txtPWD1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtPWD2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;

            if (e.KeyChar == 13)
                btnSave.PerformClick();
        }

        private void txtPWD1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPWD1.Text))
                lblPWD2.Visible = true;
        }
    }
}