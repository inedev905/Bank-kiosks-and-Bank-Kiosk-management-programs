namespace Project
{
    partial class frmEnterPwd
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
            this.panPwd = new System.Windows.Forms.Panel();
            this.cur키패드1 = new Project.cur키패드();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.panPwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panPwd
            // 
            this.panPwd.Controls.Add(this.cur키패드1);
            this.panPwd.Controls.Add(this.BtnCancel);
            this.panPwd.Controls.Add(this.btnOK);
            this.panPwd.Controls.Add(this.txtPwd);
            this.panPwd.Controls.Add(this.lblPwd);
            this.panPwd.Location = new System.Drawing.Point(2, 2);
            this.panPwd.Name = "panPwd";
            this.panPwd.Size = new System.Drawing.Size(1274, 928);
            this.panPwd.TabIndex = 28;
            // 
            // cur키패드1
            // 
            this.cur키패드1.Location = new System.Drawing.Point(707, 110);
            this.cur키패드1.Name = "cur키패드1";
            this.cur키패드1.Size = new System.Drawing.Size(402, 538);
            this.cur키패드1.TabIndex = 16;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnCancel.Location = new System.Drawing.Point(75, 730);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(496, 105);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOK.Location = new System.Drawing.Point(587, 730);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(496, 105);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPwd.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPwd.Location = new System.Drawing.Point(176, 554);
            this.txtPwd.MaxLength = 4;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '●';
            this.txtPwd.Size = new System.Drawing.Size(453, 81);
            this.txtPwd.TabIndex = 13;
            this.txtPwd.Text = "3333";
            this.txtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPwd.Location = new System.Drawing.Point(168, 270);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(471, 168);
            this.lblPwd.TabIndex = 0;
            this.lblPwd.Text = "비밀번호를 \r\n입력해주세요.";
            this.lblPwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm09_2_1_비밀번호입력
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 922);
            this.Controls.Add(this.panPwd);
            this.Name = "frm09_2_1_비밀번호입력";
            this.Text = "비밀번호입력";
            this.panPwd.ResumeLayout(false);
            this.panPwd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblPwd;
        public System.Windows.Forms.Panel panPwd;
        private cur키패드 cur키패드1;
    }
}