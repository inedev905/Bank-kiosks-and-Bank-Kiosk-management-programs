using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Net; //URL관련
using System.Xml;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Drawing;

namespace Project_admin
{
    public partial class frmCustomerPop : Form
    {
        public CustomerDTO CustomerInfo
        {
            get
            {
                return new CustomerDTO
                {
                    Pcode = txtPcode.Text,
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Nbr = txtNbr.Text,
                    Email = txtEmail.Text,
                    Zip = txtZip.Text,
                    Addr = txtAddr1.Text,
                    Addrs = txtAddr2.Text
                };
            }
            set
            {
                txtPcode.Text = value.Pcode.ToString();
                txtName.Text = value.Name.ToString();
                txtPhone.Text = value.Phone.ToString();
                txtNbr.Text = value.Nbr.ToString();
                txtEmail.Text = value.Email.ToString();
                txtZip.Text = value.Zip.ToString();
                txtAddr1.Text = value.Addr.ToString();
                txtAddr2.Text = value.Addrs.ToString();
            }
        }

        public frmCustomerPop()
        {
            InitializeComponent();
            txtPcode.Text = Util.GetIDX("P", 10);
        }

        public frmCustomerPop(string pCode)    //수정 시
        {
            InitializeComponent();
            CustomerDAO dao = new CustomerDAO();
            CustomerInfo = dao.GetCustomerInfoRow(pCode);
            dao.Dispose();
            txtNbr.Enabled = false;
            btnNbrCk.Visible = false;
            lblNbrLength.Visible = false;
        }

        private void txtNbr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnNbrCk.PerformClick();
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtAddr3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnOK.PerformClick();
        }

        private void txtNbr_TextChanged(object sender, EventArgs e)
        {
            if (txtNbr.Text.Length == 13)
            {
                lblNbrLength.Text = "*중복확인 버튼을 눌러주십시오.";
                lblNbrLength.ForeColor = Color.DimGray;
            }
        }

        private void txtNbr_Leave(object sender, EventArgs e)
        {
            if (txtNbr.Text.Length != 13)
            {
                lblNbrLength.Visible = true;
                lblNbrLength.Text = "*주민등록번호 13자리를 입력해주십시오.";
                lblNbrLength.ForeColor = Color.IndianRed;
            }
            else if (lblNbrLength.Text != "*등록가능한 고객입니다.")
                lblNbrLength.ForeColor = Color.IndianRed;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (IsValidEmail(txtEmail.Text) == false)
            {
                lblEmailCheck.Visible = true;
                lblEmailCheck.Text = "*이메일형식에 맞추어서 입력해주십시오.";
                lblEmailCheck.ForeColor = Color.IndianRed;
                txtEmail.Clear();
            }
            else
                lblEmailCheck.Visible = false;
        }

        private void btnNbrCk_Click(object sender, EventArgs e) //주민번호 중복체크
        {
            if (txtNbr.Text.Length != 13)
                lblNbrLength.ForeColor = Color.IndianRed;
            else
            {
                CustomerDAO dao = new CustomerDAO();
                bool result = dao.GetCustomercheck(txtNbr.Text);
                if (result)
                {
                    lblNbrLength.Visible = true;
                    lblNbrLength.Text = "*이미 존재하는 회원입니다. 주민등록번호를 다시 입력해주십시오.";
                    lblNbrLength.ForeColor = Color.IndianRed;
                    txtNbr.Clear();
                    txtNbr.Focus();
                    return;
                }
                else
                {
                    lblNbrLength.Visible = true;
                    lblNbrLength.Text = "*등록가능한 고객입니다.";
                    lblNbrLength.ForeColor = Color.MidnightBlue;
                    txtPhone.Focus();
                }
                dao.Dispose();
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (IsValidEmail(txtEmail.Text) == true)
            {
                lblEmailCheck.Visible = false;
            }
        }

        private void btnAddrSearch_Click(object sender, EventArgs e)
        {
            frmZipPopup pop = new frmZipPopup();
            if (pop.ShowDialog() == DialogResult.OK)
            {
                txtZip.Text = pop.ZipCode;
                txtAddr1.Text = pop.Addr1;
                txtAddr2.Text = pop.Addr2;

                txtAddr1.Focus();
            }
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("고객명은 필수 입력항목입니다.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNbr.Text))
            {
                MessageBox.Show("주민등록번호는 필수 입력항목입니다.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("연락처는 필수 입력항목입니다.");
                return;
            }

            if (txtName.Text.Length < 3)
                MessageBox.Show("고객명은 3자 이상이어야 합니다.");

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            //메인창으로 이동
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();
                    string domainName = idn.GetAscii(match.Groups[2].Value);
                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}