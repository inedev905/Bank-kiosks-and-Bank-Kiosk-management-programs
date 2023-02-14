using System;
using System.Windows.Forms;
using System.Drawing;

namespace Project_admin
{
    public partial class frmAccountPop : Form
    {
        public AccountDTO AccountInfoAdd
        {
            get
            {
                return new AccountDTO
                {   //계좌번호 비밀번호 카드번호 카드비밀번호 계좌정지유무
                    Pcode = txtPcode.Text,
                    Acode = txtAccount.Text,
                    Pwd = txtPwd1.Text,
                    CardNo = txtCardNo.Text,
                    CardPwd = txtCardPwd1.Text
                };
            }
            set
            {
                txtPcode.Text = value.Pcode.ToString();
            }
        }

        public AccountDTO AccountInfoEdit
        {
            get
            {
                return new AccountDTO
                {   //계좌번호 비밀번호 카드번호 카드비밀번호 계좌정지유무
                    Pcode = txtPcode.Text,
                    Acode = txtAccount.Text,
                    Pwd = txtCardPwd1.Text,
                    Status = chkBreak.Checked, // ????
                    CardNo = txtCardNo.Text,
                    CardPwd = txtCardPwd1.Text
                };
            }
            set
            {
                txtPcode.Text = value.Pcode.ToString();
                txtAccount.Text = value.Acode.ToString();
                txtPwd1.Text = value.Pwd.ToString();
                chkBreak.Checked = value.Status;
                txtCardNo.Text = value.CardNo.ToString();
                txtCardPwd1.Text = value.CardPwd.ToString();
                txtCardPwd2.Text = value.CardPwd.ToString();
                txtAccount.Enabled = false;
            }
        }

        public frmAccountPop(string pCODE) //string pCODE //추가 시
        {
            InitializeComponent();
            CustomerDAO dao = new CustomerDAO();
            CustomerDTO cu = dao.GetCustomerInfoRow(pCODE);
            txtPcode.Text = pCODE;
            txtName.Text = cu.Name;
            dao.Dispose();
        }

        public frmAccountPop(string pCODE, string aCODE)    //수정 시
        {
            InitializeComponent();
            CustomerDAO dao = new CustomerDAO();
            CustomerDTO cu = dao.GetCustomerInfoRow(pCODE);
            txtName.Text = cu.Name;
            AccountInfoEdit = dao.GetAccountInfoRow(aCODE);   //pCODE, aCODE
            dao.Dispose();

            txtAccount.Enabled = false;
            btnAccountCk.Visible = false;
            lblAccPwdLength.Visible = false;
        }

        private void txtPwd1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtCardNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }


        private void txtAccount_TextChanged(object sender, EventArgs e)
        {
            if (txtAccount.Text.Length == 10)
            {
                lblAccountLength.Text = "*중복확인 버튼을 눌러주십시오.";
                lblAccountLength.ForeColor = Color.DimGray;
            }
        }

        private void txtCardNo_TextChanged(object sender, EventArgs e)
        {
            if (txtCardNo.Text.Length == 8)
            {
                lblCardLength.Text = "*중복확인 버튼을 눌러주십시오.";
                lblCardLength.ForeColor = Color.DimGray;
            }
        }

        private void txtAccount_Leave(object sender, EventArgs e)
        {
            if (txtAccount.Text.Length != 10)
            {
                lblAccountLength.Visible = true;
                lblAccountLength.Text = "*계좌번호 10자리를 입력해주십시오.";
                lblAccountLength.ForeColor = Color.IndianRed;
            }
            else if (lblAccountLength.Text != "*등록가능한 계좌번호입니다.")
            {
                lblAccountLength.ForeColor = Color.IndianRed;
                txtAccount.Focus();
            }
        }

        private void txtCardNo_Leave(object sender, EventArgs e)
        {
            if (txtCardNo.Text.Length != 8)
            {
                lblCardLength.Visible = true;
                lblCardLength.Text = "*카드번호 8자리를 입력해주십시오.";
                lblCardLength.ForeColor = Color.IndianRed;
            }
            else if (lblCardLength.Text != "*등록가능한 카드번호입니다.")
            {
                lblCardLength.ForeColor = Color.IndianRed;
                txtCardNo.Focus();
            }
        }

        private void txtPwd1_Leave(object sender, EventArgs e)
        {
            if (txtPwd1.Text.Length != 4)
            {
                lblAccPwdLength.ForeColor = Color.IndianRed;
            }
            else
                lblAccPwdLength.Visible = false;
        }

        private void txtCardPwd1_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCardNo.Text) && txtCardPwd1.Text.Length != 4)
            {
                lblCardPwdLength.ForeColor = Color.IndianRed;
                lblCardPwdLength.Visible = true;
            }
            else
                lblAccPwdLength.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccount.Text))
            {
                MessageBox.Show("계좌번호는 필수 입력항목입니다.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPwd1.Text))
            {
                MessageBox.Show("비밀번호는 필수 입력항목입니다.");
                return;
            }

            if (txtPwd1.Text != txtPwd2.Text)
            {
                MessageBox.Show("비밀번호를 다시 확인해주세요.");
                txtPwd2.Clear();
                txtPwd2.Focus();
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtCardNo.Text))
            {
                if (string.IsNullOrWhiteSpace(txtCardPwd1.Text))
                {
                    MessageBox.Show("카드비밀번호를 필수 입력항목입니다.");
                    return;
                }

                if (txtCardPwd1.Text != txtCardPwd2.Text)
                {
                    MessageBox.Show("카드비밀번호를 다시 확인해주세요.");
                    txtCardPwd2.Clear();
                    txtCardPwd2.Focus();
                    return;
                }
            }
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtCardPwd1_TextChanged(object sender, EventArgs e)
        {
            if (txtCardPwd1.Text.Length == 4)
                lblCardPwdLength.Visible = false;
        }

        private void btnAccountCk_Click(object sender, EventArgs e) //계좌번호 중복확인
        {
            CustomerDAO dao = new CustomerDAO();
            bool result = dao.GetAccountcheck(txtAccount.Text);
            if (result)
            {
                lblAccountLength.Visible = true;
                lblAccountLength.Text = "*이미 존재하는 계좌번호입니다. 계좌번호를 다시 입력해주십시오.";
                lblAccountLength.ForeColor = Color.IndianRed;
                txtAccount.Clear();
                txtAccount.Focus();
                return;
            }
            else
            {
                lblAccountLength.Visible = true;
                lblAccountLength.Text = "*등록가능한 계좌번호입니다.";
                lblAccountLength.ForeColor = Color.MidnightBlue;
                txtPwd1.Focus();
            }
            dao.Dispose();
        }

        private void btnCardNoCk_Click(object sender, EventArgs e)
        {
            CustomerDAO dao = new CustomerDAO();
            bool result = dao.GetAccountcheck(txtCardNo.Text);
            if (result)
            {
                lblCardLength.Visible = true;
                lblCardLength.Text = "*이미 존재하는 카드번호입니다. 카드번호를 다시 입력해주십시오.";
                lblCardLength.ForeColor = Color.IndianRed;
                txtCardNo.Clear();
                txtCardNo.Focus();
                return;
            }
            else
            {
                lblCardLength.Visible = true;
                lblCardLength.Text = "*등록가능한 카드번호입니다.";
                lblCardLength.ForeColor = Color.MidnightBlue;
                txtCardPwd1.Focus();
            }
            dao.Dispose();
        }

        private void txtPwd2_Leave(object sender, EventArgs e)
        {
            if (txtPwd1.Text != txtPwd2.Text)
            {
                lblAccPwdLength.Text = "동일한 비밀번호를 입력해주십시오.";
                lblAccPwdLength.Visible = true;
                lblAccPwdLength.ForeColor = Color.IndianRed;
            }
            else
                lblAccPwdLength.Visible = false;
        }

        private void txtCardPwd2_Leave(object sender, EventArgs e)
        {
            if (txtCardPwd1.Text != txtCardPwd2.Text)
            {
                lblCardPwdLength.Text = "동일한 카드비밀번호를 입력해주십시오.";
                lblCardPwdLength.Visible = true;
                lblCardPwdLength.ForeColor = Color.IndianRed;
            }
            else
                lblCardPwdLength.Visible = false;
        }
    }
}