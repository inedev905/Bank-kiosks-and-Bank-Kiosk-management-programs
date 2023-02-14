namespace Project_admin
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsrBankInfo = new System.Windows.Forms.ToolStripButton();
            this.tsrAssetInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsrCustomerInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsrKioskInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("나눔고딕OTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(5);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbHome,
            this.toolStripSeparator3,
            this.tsrBankInfo,
            this.tsrAssetInfo,
            this.toolStripSeparator1,
            this.tsrCustomerInfo,
            this.toolStripSeparator2,
            this.tsrKioskInfo,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1460, 29);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbHome
            // 
            this.tsbHome.Image = ((System.Drawing.Image)(resources.GetObject("tsbHome.Image")));
            this.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHome.Name = "tsbHome";
            this.tsbHome.Size = new System.Drawing.Size(48, 26);
            this.tsbHome.Text = "홈";
            this.tsbHome.Click += new System.EventHandler(this.tsbHome_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 29);
            // 
            // tsrBankInfo
            // 
            this.tsrBankInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsrBankInfo.Image")));
            this.tsrBankInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsrBankInfo.Name = "tsrBankInfo";
            this.tsrBankInfo.Size = new System.Drawing.Size(102, 26);
            this.tsrBankInfo.Text = "은행관리";
            this.tsrBankInfo.Click += new System.EventHandler(this.tsrBankInfo_Click);
            // 
            // tsrAssetInfo
            // 
            this.tsrAssetInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsrAssetInfo.Image")));
            this.tsrAssetInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsrAssetInfo.Name = "tsrAssetInfo";
            this.tsrAssetInfo.Size = new System.Drawing.Size(102, 26);
            this.tsrAssetInfo.Text = "자산관리";
            this.tsrAssetInfo.Click += new System.EventHandler(this.tsrAssetInfo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // tsrCustomerInfo
            // 
            this.tsrCustomerInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsrCustomerInfo.Image")));
            this.tsrCustomerInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsrCustomerInfo.Name = "tsrCustomerInfo";
            this.tsrCustomerInfo.Size = new System.Drawing.Size(156, 26);
            this.tsrCustomerInfo.Text = "고객및계좌관리";
            this.tsrCustomerInfo.Click += new System.EventHandler(this.tsrCustomerInfo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // tsrKioskInfo
            // 
            this.tsrKioskInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsrKioskInfo.Image")));
            this.tsrKioskInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsrKioskInfo.Name = "tsrKioskInfo";
            this.tsrKioskInfo.Size = new System.Drawing.Size(138, 26);
            this.tsrKioskInfo.Text = "키오스크관리";
            this.tsrKioskInfo.Click += new System.EventHandler(this.tsrKioskInfo_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(66, 26);
            this.toolStripButton6.Text = "종료";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1460, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // frm_02_메인화면
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1460, 1012);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_02_메인화면";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "메인화면";
            this.Load += new System.EventHandler(this.frm_02_메인화면_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsrBankInfo;
        private System.Windows.Forms.ToolStripButton tsrAssetInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsrCustomerInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsrKioskInfo;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton tsbHome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}