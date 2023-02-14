namespace Project
{
    partial class frmEnterAccount
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
            this.panAccount = new System.Windows.Forms.Panel();
            this.cur키패드1 = new Project.cur키패드();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.panAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panAccount
            // 
            this.panAccount.Controls.Add(this.cur키패드1);
            this.panAccount.Controls.Add(this.btnCancel);
            this.panAccount.Controls.Add(this.btnOK);
            this.panAccount.Controls.Add(this.txtAccount);
            this.panAccount.Controls.Add(this.lblAccount);
            this.panAccount.Location = new System.Drawing.Point(1, 3);
            this.panAccount.Name = "panAccount";
            this.panAccount.Size = new System.Drawing.Size(1274, 928);
            this.panAccount.TabIndex = 27;
            // 
            // cur키패드1
            // 
            this.cur키패드1.Location = new System.Drawing.Point(762, 72);
            this.cur키패드1.Name = "cur키패드1";
            this.cur키패드1.Size = new System.Drawing.Size(402, 538);
            this.cur키패드1.TabIndex = 49;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(110, 762);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(480, 105);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOK.Location = new System.Drawing.Point(605, 762);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(480, 105);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccount.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtAccount.Location = new System.Drawing.Point(201, 638);
            this.txtAccount.MaxLength = 15;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(768, 81);
            this.txtAccount.TabIndex = 13;
            this.txtAccount.Text = "1084911791";
            this.txtAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAccount
            // 
            this.lblAccount.Font = new System.Drawing.Font("나눔고딕OTF", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAccount.Location = new System.Drawing.Point(120, 177);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(535, 328);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "계좌번호 \r\n또는\r\n카드번호를 \r\n입력해주세요.\r\n";
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm09_1_계좌입력
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 922);
            this.Controls.Add(this.panAccount);
            this.Name = "frm09_1_계좌입력";
            this.Text = "계좌입력";
            this.panAccount.ResumeLayout(false);
            this.panAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lblAccount;
        public System.Windows.Forms.Panel panAccount;
        private cur키패드 cur키패드1;
    }
}