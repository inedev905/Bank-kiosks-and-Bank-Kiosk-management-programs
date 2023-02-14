using System;
using System.Linq;
using System.Windows.Forms;

namespace Project_admin
{
    public partial class frmAssetManagement : Form
    {
        public BankDTO BankInfo
        {
            get
            {
                return new BankDTO
                {
                    Cash = decimal.Parse(txtCash.Text),
                    Asset = decimal.Parse(txtAsset.Text)
                };
            }
            set
            {
                txtCash.Text = value.Cash.ToString();
                txtAsset.Text = value.Asset.ToString();
            }
        }

        public frmAssetManagement()
        {
            InitializeComponent();

            string BCODE = "BKN01";
            BankDAO dao = new BankDAO();
            BankDTO dto = dao.BankSelect(BCODE);
            txtCash.Text = dto.Cash.ToString();
            txtAsset.Text = dto.Asset.ToString();
            dao.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCash.Text))
                MessageBox.Show("보유고를 입력해주세요.");
            else if (string.IsNullOrWhiteSpace(txtAsset.Text))
                MessageBox.Show("자산을 입력해주세요.");

            BankDAO dao = new BankDAO();
            bool result = dao.Asset(BankInfo);
            dao.Dispose();

            if (result)
                MessageBox.Show("등록성공");
            else
                MessageBox.Show("등록실패");

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

        private void txtAsset_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;

            if (e.KeyChar == 13)
                btnSave.PerformClick();
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            txtCash.Select(txtCash.Text.Length, 0);
        }

        private void txtAsset_TextChanged(object sender, EventArgs e)
        {
            txtCash.Select(txtCash.Text.Length, 0);
        }
    }
}
