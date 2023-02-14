namespace Project
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTns01 = new System.Windows.Forms.Button();
            this.btnTns02 = new System.Windows.Forms.Button();
            this.btnTns03 = new System.Windows.Forms.Button();
            this.btnTns05 = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.lblBankName = new System.Windows.Forms.Label();
            this.lblBankAddrName = new System.Windows.Forms.Label();
            this.panBankMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panAD = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panBankMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTns01
            // 
            this.btnTns01.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTns01.FlatAppearance.BorderSize = 0;
            this.btnTns01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTns01.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTns01.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTns01.Location = new System.Drawing.Point(85, 156);
            this.btnTns01.Name = "btnTns01";
            this.btnTns01.Size = new System.Drawing.Size(255, 164);
            this.btnTns01.TabIndex = 0;
            this.btnTns01.Text = "입금";
            this.btnTns01.UseVisualStyleBackColor = false;
            this.btnTns01.Click += new System.EventHandler(this.btnTns01_Click);
            // 
            // btnTns02
            // 
            this.btnTns02.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTns02.FlatAppearance.BorderSize = 0;
            this.btnTns02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTns02.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTns02.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTns02.Location = new System.Drawing.Point(366, 156);
            this.btnTns02.Name = "btnTns02";
            this.btnTns02.Size = new System.Drawing.Size(255, 164);
            this.btnTns02.TabIndex = 1;
            this.btnTns02.Text = "출금";
            this.btnTns02.UseVisualStyleBackColor = false;
            this.btnTns02.Click += new System.EventHandler(this.btnTns02_Click);
            // 
            // btnTns03
            // 
            this.btnTns03.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTns03.FlatAppearance.BorderSize = 0;
            this.btnTns03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTns03.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTns03.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTns03.Location = new System.Drawing.Point(647, 156);
            this.btnTns03.Name = "btnTns03";
            this.btnTns03.Size = new System.Drawing.Size(255, 164);
            this.btnTns03.TabIndex = 2;
            this.btnTns03.Text = "송금\r\n무통장입금";
            this.btnTns03.UseVisualStyleBackColor = false;
            this.btnTns03.Click += new System.EventHandler(this.btnTns03_Click);
            // 
            // btnTns05
            // 
            this.btnTns05.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTns05.FlatAppearance.BorderSize = 0;
            this.btnTns05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTns05.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTns05.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTns05.Location = new System.Drawing.Point(928, 156);
            this.btnTns05.Name = "btnTns05";
            this.btnTns05.Size = new System.Drawing.Size(255, 164);
            this.btnTns05.TabIndex = 3;
            this.btnTns05.Text = "이력조회";
            this.btnTns05.UseVisualStyleBackColor = false;
            this.btnTns05.Click += new System.EventHandler(this.btnTns04_Click);
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("나눔고딕OTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblText.ForeColor = System.Drawing.Color.Black;
            this.lblText.Location = new System.Drawing.Point(352, 389);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(553, 78);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "반갑습니다. 구디은행입니다.\r\n원하시는 거래를 선택하여 주십시오.";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.Font = new System.Drawing.Font("나눔고딕OTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBankName.Location = new System.Drawing.Point(35, 51);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(104, 28);
            this.lblBankName.TabIndex = 6;
            this.lblBankName.Text = "구디은행";
            // 
            // lblBankAddrName
            // 
            this.lblBankAddrName.AutoSize = true;
            this.lblBankAddrName.Font = new System.Drawing.Font("나눔고딕OTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBankAddrName.Location = new System.Drawing.Point(35, 80);
            this.lblBankAddrName.Name = "lblBankAddrName";
            this.lblBankAddrName.Size = new System.Drawing.Size(173, 28);
            this.lblBankAddrName.TabIndex = 7;
            this.lblBankAddrName.Text = "구디아카데미점";
            // 
            // panBankMain
            // 
            this.panBankMain.BackColor = System.Drawing.Color.Transparent;
            this.panBankMain.Controls.Add(this.panel1);
            this.panBankMain.Controls.Add(this.lblText);
            this.panBankMain.Controls.Add(this.btnTns01);
            this.panBankMain.Controls.Add(this.btnTns02);
            this.panBankMain.Controls.Add(this.lblBankName);
            this.panBankMain.Controls.Add(this.lblBankAddrName);
            this.panBankMain.Controls.Add(this.btnAdmin);
            this.panBankMain.Controls.Add(this.btnTns05);
            this.panBankMain.Controls.Add(this.btnTns03);
            this.panBankMain.Font = new System.Drawing.Font("나눔스퀘어 네오 OTF Heavy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panBankMain.Location = new System.Drawing.Point(0, 0);
            this.panBankMain.Name = "panBankMain";
            this.panBankMain.Size = new System.Drawing.Size(1274, 928);
            this.panBankMain.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panAD);
            this.panel1.Location = new System.Drawing.Point(60, 517);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 343);
            this.panel1.TabIndex = 10;
            // 
            // panAD
            // 
            this.panAD.BackColor = System.Drawing.Color.Transparent;
            this.panAD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panAD.Location = new System.Drawing.Point(0, 0);
            this.panAD.Name = "panAD";
            this.panAD.Size = new System.Drawing.Size(1137, 341);
            this.panAD.TabIndex = 9;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("나눔고딕OTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAdmin.Location = new System.Drawing.Point(1107, 865);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(91, 32);
            this.btnAdmin.TabIndex = 8;
            this.btnAdmin.Text = "관리자";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // frm01_메인
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1268, 922);
            this.Controls.Add(this.panBankMain);
            this.DoubleBuffered = true;
            this.Name = "frm01_메인";
            this.Text = "메인";
            this.panBankMain.ResumeLayout(false);
            this.panBankMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTns01;
        private System.Windows.Forms.Button btnTns02;
        private System.Windows.Forms.Button btnTns03;
        private System.Windows.Forms.Button btnTns05;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.Label lblBankAddrName;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel panAD;
        public System.Windows.Forms.Panel panBankMain;
        private System.Windows.Forms.Panel panel1;
    }
}

