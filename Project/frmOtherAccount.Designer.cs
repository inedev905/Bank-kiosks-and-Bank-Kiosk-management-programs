
namespace Project
{
    partial class frmOtherAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panMsg = new System.Windows.Forms.Panel();
            this.lblErrMsg = new System.Windows.Forms.Label();
            this.panCustomer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.panAccount = new System.Windows.Forms.Panel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.panOther = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOtherName = new System.Windows.Forms.TextBox();
            this.txtOtherMsg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnKeyOff = new System.Windows.Forms.Button();
            this.btnKeyOn = new System.Windows.Forms.Button();
            this.panMsg.SuspendLayout();
            this.panCustomer.SuspendLayout();
            this.panAccount.SuspendLayout();
            this.panOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMsg
            // 
            this.panMsg.Controls.Add(this.lblErrMsg);
            this.panMsg.Controls.Add(this.panCustomer);
            this.panMsg.Controls.Add(this.panAccount);
            this.panMsg.Controls.Add(this.panOther);
            this.panMsg.Controls.Add(this.btnCancel);
            this.panMsg.Controls.Add(this.btnOK);
            this.panMsg.Location = new System.Drawing.Point(11, 6);
            this.panMsg.Name = "panMsg";
            this.panMsg.Size = new System.Drawing.Size(1274, 928);
            this.panMsg.TabIndex = 0;
            // 
            // lblErrMsg
            // 
            this.lblErrMsg.AutoSize = true;
            this.lblErrMsg.Font = new System.Drawing.Font("나눔스퀘어 네오 OTF ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblErrMsg.Location = new System.Drawing.Point(25, 792);
            this.lblErrMsg.Name = "lblErrMsg";
            this.lblErrMsg.Size = new System.Drawing.Size(20, 30);
            this.lblErrMsg.TabIndex = 28;
            this.lblErrMsg.Text = " ";
            // 
            // panCustomer
            // 
            this.panCustomer.Controls.Add(this.label2);
            this.panCustomer.Controls.Add(this.txtMsg);
            this.panCustomer.Controls.Add(this.btnKeyOn);
            this.panCustomer.Controls.Add(this.btnKeyOff);
            this.panCustomer.Location = new System.Drawing.Point(106, 543);
            this.panCustomer.Name = "panCustomer";
            this.panCustomer.Size = new System.Drawing.Size(1008, 139);
            this.panCustomer.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(164, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 33);
            this.label2.TabIndex = 27;
            this.label2.Text = "내 통장 표시";
            // 
            // txtMsg
            // 
            this.txtMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMsg.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMsg.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtMsg.Location = new System.Drawing.Point(164, 61);
            this.txtMsg.MaxLength = 6;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(462, 63);
            this.txtMsg.TabIndex = 1;
            // 
            // panAccount
            // 
            this.panAccount.Controls.Add(this.lblAmount);
            this.panAccount.Controls.Add(this.lblBank);
            this.panAccount.Controls.Add(this.lblAccount);
            this.panAccount.Location = new System.Drawing.Point(106, 75);
            this.panAccount.Name = "panAccount";
            this.panAccount.Size = new System.Drawing.Size(1008, 195);
            this.panAccount.TabIndex = 40;
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAmount.ForeColor = System.Drawing.Color.Black;
            this.lblAmount.Location = new System.Drawing.Point(133, 109);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(737, 69);
            this.lblAmount.TabIndex = 34;
            this.lblAmount.Text = "999,999원";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBank.Location = new System.Drawing.Point(24, 10);
            this.lblBank.Margin = new System.Windows.Forms.Padding(0);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(106, 31);
            this.lblBank.TabIndex = 30;
            this.lblBank.Text = "GD구디";
            this.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccount
            // 
            this.lblAccount.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAccount.Location = new System.Drawing.Point(24, 44);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(385, 41);
            this.lblAccount.TabIndex = 31;
            this.lblAccount.Text = "1234-12-456";
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panOther
            // 
            this.panOther.Controls.Add(this.label1);
            this.panOther.Controls.Add(this.txtOtherName);
            this.panOther.Controls.Add(this.txtOtherMsg);
            this.panOther.Controls.Add(this.label3);
            this.panOther.Location = new System.Drawing.Point(106, 283);
            this.panOther.Name = "panOther";
            this.panOther.Size = new System.Drawing.Size(1008, 254);
            this.panOther.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(164, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "받는분";
            // 
            // txtOtherName
            // 
            this.txtOtherName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtherName.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtOtherName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtOtherName.Location = new System.Drawing.Point(164, 60);
            this.txtOtherName.MaxLength = 6;
            this.txtOtherName.Name = "txtOtherName";
            this.txtOtherName.Size = new System.Drawing.Size(462, 63);
            this.txtOtherName.TabIndex = 0;
            // 
            // txtOtherMsg
            // 
            this.txtOtherMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtherMsg.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtOtherMsg.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtOtherMsg.Location = new System.Drawing.Point(164, 181);
            this.txtOtherMsg.MaxLength = 6;
            this.txtOtherMsg.Name = "txtOtherMsg";
            this.txtOtherMsg.Size = new System.Drawing.Size(462, 63);
            this.txtOtherMsg.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(164, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 33);
            this.label3.TabIndex = 29;
            this.label3.Text = "받는 분 통장 표시";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(249, 748);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(288, 105);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOK.Location = new System.Drawing.Point(543, 748);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(460, 105);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // btnKeyOff
            // 
            this.btnKeyOff.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnKeyOff.Location = new System.Drawing.Point(888, 54);
            this.btnKeyOff.Name = "btnKeyOff";
            this.btnKeyOff.Size = new System.Drawing.Size(108, 70);
            this.btnKeyOff.TabIndex = 26;
            this.btnKeyOff.Text = "키보드 OFF";
            this.btnKeyOff.UseVisualStyleBackColor = true;
            this.btnKeyOff.Click += new System.EventHandler(this.btnKeyOff_Click);
            // 
            // btnKeyOn
            // 
            this.btnKeyOn.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnKeyOn.Location = new System.Drawing.Point(774, 54);
            this.btnKeyOn.Name = "btnKeyOn";
            this.btnKeyOn.Size = new System.Drawing.Size(108, 70);
            this.btnKeyOn.TabIndex = 25;
            this.btnKeyOn.Text = "키보드 ON";
            this.btnKeyOn.UseVisualStyleBackColor = true;
            this.btnKeyOn.Click += new System.EventHandler(this.btnKeyOn_Click);
            // 
            // frm대상계좌주
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 922);
            this.Controls.Add(this.panMsg);
            this.Name = "frm대상계좌주";
            this.Text = "frm대상계좌주";
            this.panMsg.ResumeLayout(false);
            this.panMsg.PerformLayout();
            this.panCustomer.ResumeLayout(false);
            this.panCustomer.PerformLayout();
            this.panAccount.ResumeLayout(false);
            this.panAccount.PerformLayout();
            this.panOther.ResumeLayout(false);
            this.panOther.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtOtherName;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panMsg;
        private System.Windows.Forms.Button btnKeyOff;
        private System.Windows.Forms.Button btnKeyOn;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtOtherMsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panOther;
        private System.Windows.Forms.Panel panCustomer;
        private System.Windows.Forms.Panel panAccount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblErrMsg;
    }
}