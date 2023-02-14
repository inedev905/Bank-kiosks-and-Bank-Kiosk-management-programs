using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Drawing.Configuration;

namespace Project_admin
{
    public partial class frmKioskPop : Form
    {
        public KioskDTO KioskInfo //KCODE, BCODE, NAME, AD_IMAGE, BACK_IMAGE, CASH
        {
            get
            {
                return new KioskDTO
                {
                    KCODE = txtKioskCode.Text,
                    BCODE = "BKN01",
                    NAME = txtKioskName.Text,
                    AD_IMAGE = picAdImage.Image,
                    BACK_IMAGE = picBackImage.Image,
                    CASH = decimal.Parse(txtKioskCash.Text)
                };
            }
            set
            {
                txtKioskCode.Text = value.KCODE;
                txtKioskName.Text = value.NAME;
                txtKioskCash.Text = value.CASH.ToString();
                picAdImage.Image = value.AD_IMAGE;
                picBackImage.Image = value.BACK_IMAGE;
            }
        }

        int kcode = 0;

        public frmKioskPop() //추가
        {
            InitializeComponent();
            txtKioskCode.Text = Util.GetIDX("K", 10);
        }

        public frmKioskPop(string kCode) //수정
        {
            InitializeComponent();
            txtKioskCode.Text = kCode;
            KioskDAO kioskDAO = new KioskDAO();
            KioskInfo = kioskDAO.GetKioskInfoRow(kCode);
            kioskDAO.Dispose();
        }

        private void btnAdImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg files (*.jpg)|*.jpg;*.jpeg|png files (*.png)|*.png|bmp files (*.bmp)|*.bmp|All files (*.*)|*.*"; ;
            if (ofd.ShowDialog() == DialogResult.OK)
                picAdImage.Image = Image.FromFile(ofd.FileName);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtKioskCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKioskName.Text))
            {
                MessageBox.Show("키오스크 이름은 필수 입력항목입니다.");
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void btnBackImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg files (*.jpg)|*.jpg;*.jpeg|png files (*.png)|*.png|bmp files (*.bmp)|*.bmp|All files (*.*)|*.*"; ;
            if (ofd.ShowDialog() == DialogResult.OK)
                picBackImage.Image = Image.FromFile(ofd.FileName);
        }
    }
}