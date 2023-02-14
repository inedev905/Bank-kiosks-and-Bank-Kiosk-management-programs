namespace Project
{
    partial class frmOngoing
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
            this.lblTnsMsg = new System.Windows.Forms.Label();
            this.panMsg = new System.Windows.Forms.Panel();
            this.lblTns = new System.Windows.Forms.Label();
            this.labWait = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.panMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTnsMsg
            // 
            this.lblTnsMsg.AutoSize = true;
            this.lblTnsMsg.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTnsMsg.Location = new System.Drawing.Point(385, 416);
            this.lblTnsMsg.Name = "lblTnsMsg";
            this.lblTnsMsg.Size = new System.Drawing.Size(533, 84);
            this.lblTnsMsg.TabIndex = 1;
            this.lblTnsMsg.Text = "\"진행중입니다.\"";
            this.lblTnsMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panMsg
            // 
            this.panMsg.Controls.Add(this.lblTns);
            this.panMsg.Controls.Add(this.labWait);
            this.panMsg.Controls.Add(this.btnOK);
            this.panMsg.Controls.Add(this.lblTnsMsg);
            this.panMsg.Location = new System.Drawing.Point(1, 2);
            this.panMsg.Name = "panMsg";
            this.panMsg.Size = new System.Drawing.Size(1274, 928);
            this.panMsg.TabIndex = 2;
            // 
            // lblTns
            // 
            this.lblTns.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTns.Location = new System.Drawing.Point(138, 200);
            this.lblTns.Name = "lblTns";
            this.lblTns.Size = new System.Drawing.Size(972, 163);
            this.lblTns.TabIndex = 4;
            this.lblTns.Text = "입금";
            this.lblTns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labWait
            // 
            this.labWait.Font = new System.Drawing.Font("나눔고딕OTF", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labWait.Location = new System.Drawing.Point(2, 685);
            this.labWait.Name = "labWait";
            this.labWait.Size = new System.Drawing.Size(1244, 35);
            this.labWait.TabIndex = 3;
            this.labWait.Text = ">> 5초 후 거래확인 화면으로 이동합니다.";
            this.labWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("나눔고딕OTF", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOK.Location = new System.Drawing.Point(441, 743);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(366, 43);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frm02_진행중
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 922);
            this.Controls.Add(this.panMsg);
            this.Name = "frm02_진행중";
            this.Text = "진행중";
            this.panMsg.ResumeLayout(false);
            this.panMsg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTnsMsg;
        public System.Windows.Forms.Panel panMsg;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label labWait;
        private System.Windows.Forms.Label lblTns;
    }
}