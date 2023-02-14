namespace Project
{
    partial class frmAmountEnter
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
            this.panCash2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotAsset = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.cur키패드1 = new Project.cur키패드();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblCashSelf = new System.Windows.Forms.Label();
            this.panCash2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panCash2
            // 
            this.panCash2.Controls.Add(this.panel1);
            this.panCash2.Controls.Add(this.lblLimit);
            this.panCash2.Controls.Add(this.cur키패드1);
            this.panCash2.Controls.Add(this.txtCash);
            this.panCash2.Controls.Add(this.label2);
            this.panCash2.Controls.Add(this.btnCancel);
            this.panCash2.Controls.Add(this.btnOK);
            this.panCash2.Controls.Add(this.lblCashSelf);
            this.panCash2.Location = new System.Drawing.Point(2, 0);
            this.panCash2.Name = "panCash2";
            this.panCash2.Size = new System.Drawing.Size(1274, 928);
            this.panCash2.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotAsset);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblAccount);
            this.panel1.Location = new System.Drawing.Point(48, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 145);
            this.panel1.TabIndex = 39;
            // 
            // lblTotAsset
            // 
            this.lblTotAsset.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotAsset.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotAsset.Location = new System.Drawing.Point(24, 101);
            this.lblTotAsset.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotAsset.Name = "lblTotAsset";
            this.lblTotAsset.Size = new System.Drawing.Size(700, 30);
            this.lblTotAsset.TabIndex = 33;
            this.lblTotAsset.Text = "출금가능금액";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(24, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 31);
            this.label4.TabIndex = 30;
            this.label4.Text = "GD구디";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccount
            // 
            this.lblAccount.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAccount.Location = new System.Drawing.Point(24, 44);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(341, 41);
            this.lblAccount.TabIndex = 31;
            this.lblAccount.Text = "1234-12-456";
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLimit
            // 
            this.lblLimit.Font = new System.Drawing.Font("나눔스퀘어 네오 OTF ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLimit.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLimit.Location = new System.Drawing.Point(108, 482);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(563, 130);
            this.lblLimit.TabIndex = 38;
            this.lblLimit.Text = "*현금부족메세지";
            this.lblLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cur키패드1
            // 
            this.cur키패드1.InputTextBox = this.txtCash;
            this.cur키패드1.Location = new System.Drawing.Point(828, 201);
            this.cur키패드1.Name = "cur키패드1";
            this.cur키패드1.Size = new System.Drawing.Size(402, 526);
            this.cur키패드1.TabIndex = 37;
            // 
            // txtCash
            // 
            this.txtCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCash.Font = new System.Drawing.Font("나눔스퀘어 네오 OTF Regular", 48F, System.Drawing.FontStyle.Bold);
            this.txtCash.Location = new System.Drawing.Point(46, 645);
            this.txtCash.MaxLength = 10;
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(679, 78);
            this.txtCash.TabIndex = 13;
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(731, 649);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 74);
            this.label2.TabIndex = 36;
            this.label2.Text = "원";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(120, 768);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(460, 105);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOK.Location = new System.Drawing.Point(602, 768);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(460, 105);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblCashSelf
            // 
            this.lblCashSelf.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCashSelf.Location = new System.Drawing.Point(86, 311);
            this.lblCashSelf.Name = "lblCashSelf";
            this.lblCashSelf.Size = new System.Drawing.Size(606, 171);
            this.lblCashSelf.TabIndex = 0;
            this.lblCashSelf.Text = "금액을\r\n입력해주세요.";
            this.lblCashSelf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm09_3_2_금액직접입력
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 922);
            this.Controls.Add(this.panCash2);
            this.Name = "frm09_3_2_금액직접입력";
            this.Text = "금액직접입력";
            this.panCash2.ResumeLayout(false);
            this.panCash2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label lblCashSelf;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panCash2;
        private cur키패드 cur키패드1;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotAsset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAccount;
    }
}