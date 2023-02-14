namespace Project
{
    partial class frmTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransaction));
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.panCheck2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblTotAsset = new System.Windows.Forms.Label();
            this.lblTotAsset2 = new System.Windows.Forms.Label();
            this.lblTnsInfo2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblMemo = new System.Windows.Forms.Label();
            this.panCheck = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panCheck1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTnsInfo = new System.Windows.Forms.Label();
            this.panCheck3 = new System.Windows.Forms.Panel();
            this.lblOtherMsg = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblOtherName = new System.Windows.Forms.Label();
            this.lblOtherAccount = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAccount2 = new System.Windows.Forms.Label();
            this.lblMainMsg2 = new System.Windows.Forms.Label();
            this.lblMainMsg1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panCheck2.SuspendLayout();
            this.panCheck.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panCheck1.SuspendLayout();
            this.panCheck3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("나눔고딕OTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMsg.Location = new System.Drawing.Point(145, 725);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(958, 60);
            this.lblMsg.TabIndex = 39;
            this.lblMsg.Text = "맞으시면 \'확인버튼\' 아니시면 \'명세표\'을 눌러주세요.";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(43, 789);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(517, 81);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "취소/명세표 출력";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOK.Location = new System.Drawing.Point(566, 789);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(569, 81);
            this.btnOK.TabIndex = 44;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnok_click);
            // 
            // panCheck2
            // 
            this.panCheck2.Controls.Add(this.label3);
            this.panCheck2.Controls.Add(this.lblAccount);
            this.panCheck2.Controls.Add(this.lblTotAsset);
            this.panCheck2.Controls.Add(this.lblTotAsset2);
            this.panCheck2.Controls.Add(this.lblTnsInfo2);
            this.panCheck2.Controls.Add(this.label17);
            this.panCheck2.Controls.Add(this.lblMemo);
            this.panCheck2.Font = new System.Drawing.Font("나눔스퀘어 네오 OTF Regular", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panCheck2.Location = new System.Drawing.Point(6, 144);
            this.panCheck2.Name = "panCheck2";
            this.panCheck2.Size = new System.Drawing.Size(589, 143);
            this.panCheck2.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕OTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(531, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 33);
            this.label3.TabIndex = 46;
            this.label3.Text = "원";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccount
            // 
            this.lblAccount.Font = new System.Drawing.Font("나눔고딕OTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAccount.Location = new System.Drawing.Point(262, 13);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(310, 35);
            this.lblAccount.TabIndex = 38;
            this.lblAccount.Text = "123-4567-8910-11";
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotAsset
            // 
            this.lblTotAsset.Font = new System.Drawing.Font("나눔고딕OTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotAsset.Location = new System.Drawing.Point(261, 56);
            this.lblTotAsset.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotAsset.Name = "lblTotAsset";
            this.lblTotAsset.Size = new System.Drawing.Size(267, 35);
            this.lblTotAsset.TabIndex = 45;
            this.lblTotAsset.Text = "999";
            this.lblTotAsset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotAsset2
            // 
            this.lblTotAsset2.Font = new System.Drawing.Font("나눔고딕OTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotAsset2.Location = new System.Drawing.Point(8, 52);
            this.lblTotAsset2.Name = "lblTotAsset2";
            this.lblTotAsset2.Size = new System.Drawing.Size(198, 39);
            this.lblTotAsset2.TabIndex = 44;
            this.lblTotAsset2.Text = "잔액";
            this.lblTotAsset2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTnsInfo2
            // 
            this.lblTnsInfo2.Font = new System.Drawing.Font("나눔고딕OTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTnsInfo2.Location = new System.Drawing.Point(8, 9);
            this.lblTnsInfo2.Name = "lblTnsInfo2";
            this.lblTnsInfo2.Size = new System.Drawing.Size(198, 39);
            this.lblTnsInfo2.TabIndex = 45;
            this.lblTnsInfo2.Text = "{출금}계좌";
            this.lblTnsInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("나눔고딕OTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(8, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(198, 39);
            this.label17.TabIndex = 57;
            this.label17.Text = "내 통장 표시";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMemo
            // 
            this.lblMemo.Font = new System.Drawing.Font("나눔고딕OTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMemo.Location = new System.Drawing.Point(262, 99);
            this.lblMemo.Margin = new System.Windows.Forms.Padding(0);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(310, 35);
            this.lblMemo.TabIndex = 58;
            this.lblMemo.Text = "메모내용";
            this.lblMemo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panCheck
            // 
            this.panCheck.Controls.Add(this.panel1);
            this.panCheck.Controls.Add(this.pictureBox2);
            this.panCheck.Controls.Add(this.label12);
            this.panCheck.Controls.Add(this.lblAccount2);
            this.panCheck.Controls.Add(this.lblMainMsg2);
            this.panCheck.Controls.Add(this.lblMainMsg1);
            this.panCheck.Controls.Add(this.lblMsg);
            this.panCheck.Controls.Add(this.lblTitle);
            this.panCheck.Controls.Add(this.btnOK);
            this.panCheck.Controls.Add(this.btnCancel);
            this.panCheck.Location = new System.Drawing.Point(3, 2);
            this.panCheck.Name = "panCheck";
            this.panCheck.Size = new System.Drawing.Size(1274, 928);
            this.panCheck.TabIndex = 54;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panCheck1);
            this.panel1.Controls.Add(this.panCheck2);
            this.panel1.Controls.Add(this.panCheck3);
            this.panel1.Location = new System.Drawing.Point(588, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 463);
            this.panel1.TabIndex = 66;
            // 
            // panCheck1
            // 
            this.panCheck1.Controls.Add(this.label9);
            this.panCheck1.Controls.Add(this.lblFee);
            this.panCheck1.Controls.Add(this.label2);
            this.panCheck1.Controls.Add(this.lblAmount);
            this.panCheck1.Controls.Add(this.label1);
            this.panCheck1.Controls.Add(this.lblTnsInfo);
            this.panCheck1.Font = new System.Drawing.Font("나눔스퀘어 네오 OTF Regular", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panCheck1.Location = new System.Drawing.Point(6, 58);
            this.panCheck1.Name = "panCheck1";
            this.panCheck1.Size = new System.Drawing.Size(589, 84);
            this.panCheck1.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕OTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(531, 44);
            this.label9.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 33);
            this.label9.TabIndex = 42;
            this.label9.Text = "원";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFee
            // 
            this.lblFee.Font = new System.Drawing.Font("나눔고딕OTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFee.Location = new System.Drawing.Point(209, 43);
            this.lblFee.Margin = new System.Windows.Forms.Padding(0);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(319, 35);
            this.lblFee.TabIndex = 41;
            this.lblFee.Text = "500";
            this.lblFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕OTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(531, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 33);
            this.label2.TabIndex = 40;
            this.label2.Text = "원";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("나눔고딕OTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAmount.Location = new System.Drawing.Point(209, 4);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(319, 35);
            this.lblAmount.TabIndex = 39;
            this.lblAmount.Text = "999";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("나눔고딕OTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 39);
            this.label1.TabIndex = 38;
            this.label1.Text = "수수료";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTnsInfo
            // 
            this.lblTnsInfo.Font = new System.Drawing.Font("나눔고딕OTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTnsInfo.Location = new System.Drawing.Point(8, 3);
            this.lblTnsInfo.Name = "lblTnsInfo";
            this.lblTnsInfo.Size = new System.Drawing.Size(198, 39);
            this.lblTnsInfo.TabIndex = 37;
            this.lblTnsInfo.Text = "입금";
            this.lblTnsInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panCheck3
            // 
            this.panCheck3.Controls.Add(this.lblOtherMsg);
            this.panCheck3.Controls.Add(this.label11);
            this.panCheck3.Controls.Add(this.label7);
            this.panCheck3.Controls.Add(this.label8);
            this.panCheck3.Controls.Add(this.lblOtherName);
            this.panCheck3.Controls.Add(this.lblOtherAccount);
            this.panCheck3.Font = new System.Drawing.Font("나눔스퀘어 네오 OTF Regular", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panCheck3.Location = new System.Drawing.Point(6, 291);
            this.panCheck3.Name = "panCheck3";
            this.panCheck3.Size = new System.Drawing.Size(589, 131);
            this.panCheck3.TabIndex = 61;
            // 
            // lblOtherMsg
            // 
            this.lblOtherMsg.Font = new System.Drawing.Font("나눔고딕OTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOtherMsg.Location = new System.Drawing.Point(268, 85);
            this.lblOtherMsg.Margin = new System.Windows.Forms.Padding(0);
            this.lblOtherMsg.Name = "lblOtherMsg";
            this.lblOtherMsg.Size = new System.Drawing.Size(304, 35);
            this.lblOtherMsg.TabIndex = 62;
            this.lblOtherMsg.Text = "메모내용";
            this.lblOtherMsg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("나눔고딕OTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(8, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 39);
            this.label11.TabIndex = 61;
            this.label11.Text = "받는 분 통장 표시";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("나눔고딕OTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(8, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 39);
            this.label7.TabIndex = 60;
            this.label7.Text = "대상계좌번호";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("나눔고딕OTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(8, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 39);
            this.label8.TabIndex = 50;
            this.label8.Text = "받는 분";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOtherName
            // 
            this.lblOtherName.Font = new System.Drawing.Font("나눔고딕OTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOtherName.Location = new System.Drawing.Point(268, 47);
            this.lblOtherName.Margin = new System.Windows.Forms.Padding(0);
            this.lblOtherName.Name = "lblOtherName";
            this.lblOtherName.Size = new System.Drawing.Size(304, 35);
            this.lblOtherName.TabIndex = 59;
            this.lblOtherName.Text = "대상이름";
            this.lblOtherName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOtherAccount
            // 
            this.lblOtherAccount.Font = new System.Drawing.Font("나눔고딕OTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOtherAccount.Location = new System.Drawing.Point(268, 7);
            this.lblOtherAccount.Name = "lblOtherAccount";
            this.lblOtherAccount.Size = new System.Drawing.Size(304, 35);
            this.lblOtherAccount.TabIndex = 49;
            this.lblOtherAccount.Text = "123-4567-8910-11";
            this.lblOtherAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(221, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("나눔고딕OTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(1036, 177);
            this.label12.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 35);
            this.label12.TabIndex = 64;
            this.label12.Text = "GD구디";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccount2
            // 
            this.lblAccount2.Font = new System.Drawing.Font("나눔고딕OTF", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAccount2.Location = new System.Drawing.Point(36, 272);
            this.lblAccount2.Name = "lblAccount2";
            this.lblAccount2.Size = new System.Drawing.Size(520, 52);
            this.lblAccount2.TabIndex = 59;
            this.lblAccount2.Text = "123-4567-8910-11";
            this.lblAccount2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMainMsg2
            // 
            this.lblMainMsg2.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMainMsg2.Location = new System.Drawing.Point(33, 433);
            this.lblMainMsg2.Name = "lblMainMsg2";
            this.lblMainMsg2.Size = new System.Drawing.Size(520, 210);
            this.lblMainMsg2.TabIndex = 63;
            this.lblMainMsg2.Text = "20,000 원\r\n이체가 완료되었습니다.";
            this.lblMainMsg2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMainMsg1
            // 
            this.lblMainMsg1.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMainMsg1.Location = new System.Drawing.Point(36, 350);
            this.lblMainMsg1.Name = "lblMainMsg1";
            this.lblMainMsg1.Size = new System.Drawing.Size(520, 76);
            this.lblMainMsg1.TabIndex = 62;
            this.lblMainMsg1.Text = "홍길동 님께";
            this.lblMainMsg1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(1070, 143);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(114, 31);
            this.lblTitle.TabIndex = 36;
            this.lblTitle.Text = "거래확인";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frm09_4_1_거래업무
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 922);
            this.Controls.Add(this.panCheck);
            this.Name = "frm09_4_1_거래업무";
            this.Text = "거래업무";
            this.panCheck2.ResumeLayout(false);
            this.panCheck2.PerformLayout();
            this.panCheck.ResumeLayout(false);
            this.panCheck.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panCheck1.ResumeLayout(false);
            this.panCheck1.PerformLayout();
            this.panCheck3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panCheck2;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Panel panCheck1;
        private System.Windows.Forms.Label lblTnsInfo;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Panel panCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotAsset;
        private System.Windows.Forms.Label lblTotAsset2;
        private System.Windows.Forms.Label lblTnsInfo2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOtherName;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblOtherAccount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panCheck3;
        private System.Windows.Forms.Label lblMainMsg2;
        private System.Windows.Forms.Label lblMainMsg1;
        private System.Windows.Forms.Label lblOtherMsg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAccount2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}