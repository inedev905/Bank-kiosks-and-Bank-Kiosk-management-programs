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
    public partial class frmAdminPwd : Form
    {
        public frmAdminPwd()
        {
            InitializeComponent();
        }

        private void frm_01_관리자pw입력_Load(object sender, EventArgs e)
        {
            txtAdminPWD.Focus();
        }

        private void txtAdminPWD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnOK.PerformClick();
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdminPWD.Text))
            {
                MessageBox.Show("패스워드를 입력해주십시오.", "패스워드 확인");
                return;
            }

            string BCODE = "BKN01";
            BankDAO dao = new BankDAO();
            BankDTO dto = dao.BankSelect(BCODE);

            //암호체크
            if (txtAdminPWD.Text == dto.PWD)
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show("패스워드가 일치하지 않습니다.", "패스워드 오류");
            dao.Dispose();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}