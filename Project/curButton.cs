using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class cur키패드 : UserControl
    {
        private TextBox iTextBox = new TextBox();   
        public cur키패드()
        {
            InitializeComponent();
        }

        public TextBox InputTextBox
        {
            get { return iTextBox; } 
            set { iTextBox = value; }
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            iTextBox.Text += (sender as Button).Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(iTextBox.Text.Length > 0)
                iTextBox.Text = iTextBox.Text.Substring(0, iTextBox.Text.Length - 1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            iTextBox.Text = "";
        }
    }
}
