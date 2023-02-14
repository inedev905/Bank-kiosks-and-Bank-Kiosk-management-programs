namespace Project
{
    partial class frmAdmin
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
            this.btnInput = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblBankName = new System.Windows.Forms.Label();
            this.lblbankAddr = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.panAdmin = new System.Windows.Forms.Panel();
            this.lblTotAsset = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.panAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInput
            // 
            this.btnInput.Font = new System.Drawing.Font("나눔고딕OTF", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInput.Location = new System.Drawing.Point(109, 285);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(457, 169);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "현금입금";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Font = new System.Drawing.Font("나눔고딕OTF", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOutput.Location = new System.Drawing.Point(600, 285);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(457, 169);
            this.btnOutput.TabIndex = 1;
            this.btnOutput.Text = "현금인출";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("나눔고딕OTF", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMode.Location = new System.Drawing.Point(53, 124);
            this.lblMode.Margin = new System.Windows.Forms.Padding(0);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(151, 29);
            this.lblMode.TabIndex = 2;
            this.lblMode.Text = "[관리자모드]";
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.Font = new System.Drawing.Font("나눔고딕OTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBankName.Location = new System.Drawing.Point(53, 62);
            this.lblBankName.Margin = new System.Windows.Forms.Padding(0);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(82, 22);
            this.lblBankName.TabIndex = 8;
            this.lblBankName.Text = "구디은행";
            // 
            // lblbankAddr
            // 
            this.lblbankAddr.AutoSize = true;
            this.lblbankAddr.Font = new System.Drawing.Font("나눔고딕OTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblbankAddr.Location = new System.Drawing.Point(53, 93);
            this.lblbankAddr.Margin = new System.Windows.Forms.Padding(0);
            this.lblbankAddr.Name = "lblbankAddr";
            this.lblbankAddr.Size = new System.Drawing.Size(136, 22);
            this.lblbankAddr.TabIndex = 9;
            this.lblbankAddr.Text = "구디아카데미점";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHome.Location = new System.Drawing.Point(336, 758);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(565, 105);
            this.btnHome.TabIndex = 23;
            this.btnHome.Text = "작업종료";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panAdmin
            // 
            this.panAdmin.Controls.Add(this.lblTotAsset);
            this.panAdmin.Controls.Add(this.lblMsg);
            this.panAdmin.Controls.Add(this.btnHome);
            this.panAdmin.Controls.Add(this.lblBankName);
            this.panAdmin.Controls.Add(this.lblbankAddr);
            this.panAdmin.Controls.Add(this.lblMode);
            this.panAdmin.Controls.Add(this.btnOutput);
            this.panAdmin.Controls.Add(this.btnInput);
            this.panAdmin.Location = new System.Drawing.Point(2, 2);
            this.panAdmin.Name = "panAdmin";
            this.panAdmin.Size = new System.Drawing.Size(1274, 928);
            this.panAdmin.TabIndex = 24;
            // 
            // lblTotAsset
            // 
            this.lblTotAsset.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotAsset.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotAsset.Location = new System.Drawing.Point(53, 165);
            this.lblTotAsset.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblTotAsset.Name = "lblTotAsset";
            this.lblTotAsset.Size = new System.Drawing.Size(738, 40);
            this.lblTotAsset.TabIndex = 34;
            this.lblTotAsset.Text = "출금가능금액";
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMsg.Location = new System.Drawing.Point(165, 474);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(942, 268);
            this.lblMsg.TabIndex = 40;
            this.lblMsg.Text = "원하시는 관리자업무를 선택하여 주십시오.";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm관리자현금입출
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 922);
            this.Controls.Add(this.panAdmin);
            this.Name = "frm관리자현금입출";
            this.Text = "관리자현금입출";
            this.panAdmin.ResumeLayout(false);
            this.panAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.Label lblbankAddr;
        private System.Windows.Forms.Button btnHome;
        public System.Windows.Forms.Panel panAdmin;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblTotAsset;
    }
}