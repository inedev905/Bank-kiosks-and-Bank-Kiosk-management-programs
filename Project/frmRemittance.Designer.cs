namespace Project
{
    partial class frmRemittance
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
            this.lblTns = new System.Windows.Forms.Label();
            this.btnTns03 = new System.Windows.Forms.Button();
            this.btnTns04 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panTns = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panTns.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTns
            // 
            this.lblTns.AutoSize = true;
            this.lblTns.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 65.24999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTns.Location = new System.Drawing.Point(220, 149);
            this.lblTns.Name = "lblTns";
            this.lblTns.Size = new System.Drawing.Size(828, 200);
            this.lblTns.TabIndex = 2;
            this.lblTns.Text = "송금 또는 무통장입금\r\n선택하세요.";
            this.lblTns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTns03
            // 
            this.btnTns03.Font = new System.Drawing.Font("나눔스퀘어 네오 OTF Heavy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTns03.Location = new System.Drawing.Point(178, 442);
            this.btnTns03.Name = "btnTns03";
            this.btnTns03.Size = new System.Drawing.Size(344, 178);
            this.btnTns03.TabIndex = 4;
            this.btnTns03.Text = "송금";
            this.btnTns03.UseVisualStyleBackColor = true;
            this.btnTns03.Click += new System.EventHandler(this.btnTns03_Click);
            // 
            // btnTns04
            // 
            this.btnTns04.Font = new System.Drawing.Font("나눔스퀘어 네오 OTF Heavy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTns04.Location = new System.Drawing.Point(683, 442);
            this.btnTns04.Name = "btnTns04";
            this.btnTns04.Size = new System.Drawing.Size(344, 178);
            this.btnTns04.TabIndex = 5;
            this.btnTns04.Text = "무통장입금";
            this.btnTns04.UseVisualStyleBackColor = true;
            this.btnTns04.Click += new System.EventHandler(this.btnTns04_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHome.Location = new System.Drawing.Point(334, 745);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(594, 109);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "업무종료";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panTns
            // 
            this.panTns.Controls.Add(this.lblTns);
            this.panTns.Controls.Add(this.btnHome);
            this.panTns.Controls.Add(this.button2);
            this.panTns.Controls.Add(this.btnTns03);
            this.panTns.Controls.Add(this.button1);
            this.panTns.Controls.Add(this.btnTns04);
            this.panTns.Location = new System.Drawing.Point(2, 3);
            this.panTns.Name = "panTns";
            this.panTns.Size = new System.Drawing.Size(1274, 928);
            this.panTns.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(683, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 178);
            this.button1.TabIndex = 5;
            this.button1.Text = "무통장입금";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnTns04_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(178, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(344, 178);
            this.button2.TabIndex = 4;
            this.button2.Text = "송금";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnTns03_Click);
            // 
            // frm04_1_송금
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 922);
            this.Controls.Add(this.panTns);
            this.Name = "frm04_1_송금";
            this.Text = "송금";
            this.panTns.ResumeLayout(false);
            this.panTns.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTns;
        private System.Windows.Forms.Button btnTns03;
        private System.Windows.Forms.Button btnTns04;
        private System.Windows.Forms.Button btnHome;
        public System.Windows.Forms.Panel panTns;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}