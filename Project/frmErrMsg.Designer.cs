namespace Project
{
    partial class frmErrMsg
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
            this.lblErrMsg = new System.Windows.Forms.Label();
            this.lblErrMsg2 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.panErrMsg = new System.Windows.Forms.Panel();
            this.btnRe = new System.Windows.Forms.Button();
            this.labWait = new System.Windows.Forms.Label();
            this.panErr1 = new System.Windows.Forms.Panel();
            this.panErrMsg.SuspendLayout();
            this.panErr1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblErrMsg
            // 
            this.lblErrMsg.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblErrMsg.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrMsg.Location = new System.Drawing.Point(89, 36);
            this.lblErrMsg.Name = "lblErrMsg";
            this.lblErrMsg.Size = new System.Drawing.Size(960, 173);
            this.lblErrMsg.TabIndex = 1;
            this.lblErrMsg.Text = "비밀번호 n회 오류입니다.\r\n비밀번호를 다시 입력해주세요.";
            this.lblErrMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrMsg2
            // 
            this.lblErrMsg2.Font = new System.Drawing.Font("나눔고딕OTF", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblErrMsg2.Location = new System.Drawing.Point(89, 218);
            this.lblErrMsg2.Name = "lblErrMsg2";
            this.lblErrMsg2.Size = new System.Drawing.Size(960, 39);
            this.lblErrMsg2.TabIndex = 2;
            this.lblErrMsg2.Text = "(5회 오류 시 계좌가 정지됩니다.)";
            this.lblErrMsg2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHome.Location = new System.Drawing.Point(635, 709);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(543, 102);
            this.btnHome.TabIndex = 26;
            this.btnHome.Text = "업무종료";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panErrMsg
            // 
            this.panErrMsg.Controls.Add(this.btnRe);
            this.panErrMsg.Controls.Add(this.labWait);
            this.panErrMsg.Controls.Add(this.panErr1);
            this.panErrMsg.Controls.Add(this.btnHome);
            this.panErrMsg.Location = new System.Drawing.Point(1, 1);
            this.panErrMsg.Name = "panErrMsg";
            this.panErrMsg.Size = new System.Drawing.Size(1274, 928);
            this.panErrMsg.TabIndex = 37;
            // 
            // btnRe
            // 
            this.btnRe.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRe.Location = new System.Drawing.Point(74, 709);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(543, 102);
            this.btnRe.TabIndex = 42;
            this.btnRe.Text = "돌아가기";
            this.btnRe.UseVisualStyleBackColor = true;
            this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
            // 
            // labWait
            // 
            this.labWait.Font = new System.Drawing.Font("나눔고딕OTF", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labWait.Location = new System.Drawing.Point(133, 638);
            this.labWait.Name = "labWait";
            this.labWait.Size = new System.Drawing.Size(981, 35);
            this.labWait.TabIndex = 39;
            this.labWait.Text = ">> 5초 후 이전화면으로 이동합니다.";
            this.labWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panErr1
            // 
            this.panErr1.Controls.Add(this.lblErrMsg2);
            this.panErr1.Controls.Add(this.lblErrMsg);
            this.panErr1.Location = new System.Drawing.Point(61, 201);
            this.panErr1.Name = "panErr1";
            this.panErr1.Size = new System.Drawing.Size(1124, 307);
            this.panErr1.TabIndex = 37;
            // 
            // frm09_2_2_오류메세지
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 922);
            this.Controls.Add(this.panErrMsg);
            this.Name = "frm09_2_2_오류메세지";
            this.Text = "오류메세지";
            this.panErrMsg.ResumeLayout(false);
            this.panErr1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblErrMsg;
        private System.Windows.Forms.Label lblErrMsg2;
        private System.Windows.Forms.Button btnHome;
        public System.Windows.Forms.Panel panErrMsg;
        private System.Windows.Forms.Panel panErr1;
        private System.Windows.Forms.Label labWait;
        private System.Windows.Forms.Button btnRe;
    }
}