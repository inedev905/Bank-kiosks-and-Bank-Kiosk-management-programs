namespace Project_admin
{
    partial class frmAccountPop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountPop));
            this.label5 = new System.Windows.Forms.Label();
            this.txtCardPwd1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPwd1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkBreak = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCardLength = new System.Windows.Forms.Label();
            this.btnCardNoCk = new System.Windows.Forms.Button();
            this.btnAccountCk = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCardPwdLength = new System.Windows.Forms.Label();
            this.lblAccPwdLength = new System.Windows.Forms.Label();
            this.lblAccountLength = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCardPwd2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPwd2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(76, 568);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "계좌정지유무";
            // 
            // txtCardPwd1
            // 
            this.txtCardPwd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCardPwd1.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCardPwd1.Location = new System.Drawing.Point(226, 453);
            this.txtCardPwd1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCardPwd1.MaxLength = 4;
            this.txtCardPwd1.Name = "txtCardPwd1";
            this.txtCardPwd1.PasswordChar = '*';
            this.txtCardPwd1.Size = new System.Drawing.Size(129, 32);
            this.txtCardPwd1.TabIndex = 4;
            this.txtCardPwd1.TextChanged += new System.EventHandler(this.txtCardPwd1_TextChanged);
            this.txtCardPwd1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPwd1_KeyPress);
            this.txtCardPwd1.Leave += new System.EventHandler(this.txtCardPwd1_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(76, 455);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "카드비밀번호";
            // 
            // txtCardNo
            // 
            this.txtCardNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCardNo.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCardNo.Location = new System.Drawing.Point(226, 399);
            this.txtCardNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCardNo.MaxLength = 8;
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(241, 32);
            this.txtCardNo.TabIndex = 3;
            this.txtCardNo.TextChanged += new System.EventHandler(this.txtCardNo_TextChanged);
            this.txtCardNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardNo_KeyPress);
            this.txtCardNo.Leave += new System.EventHandler(this.txtCardNo_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(116, 401);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "카드번호";
            // 
            // txtPwd1
            // 
            this.txtPwd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPwd1.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPwd1.Location = new System.Drawing.Point(226, 284);
            this.txtPwd1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPwd1.MaxLength = 4;
            this.txtPwd1.Name = "txtPwd1";
            this.txtPwd1.PasswordChar = '*';
            this.txtPwd1.Size = new System.Drawing.Size(129, 32);
            this.txtPwd1.TabIndex = 1;
            this.txtPwd1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPwd1_KeyPress);
            this.txtPwd1.Leave += new System.EventHandler(this.txtPwd1_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(116, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "비밀번호";
            // 
            // txtAccount
            // 
            this.txtAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccount.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtAccount.Location = new System.Drawing.Point(226, 221);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccount.MaxLength = 10;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(241, 32);
            this.txtAccount.TabIndex = 0;
            this.txtAccount.TextChanged += new System.EventHandler(this.txtAccount_TextChanged);
            this.txtAccount.Leave += new System.EventHandler(this.txtAccount_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(116, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "계좌번호";
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOK.Location = new System.Drawing.Point(95, 635);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(221, 41);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkBreak
            // 
            this.chkBreak.AutoSize = true;
            this.chkBreak.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkBreak.Location = new System.Drawing.Point(226, 566);
            this.chkBreak.Name = "chkBreak";
            this.chkBreak.Size = new System.Drawing.Size(297, 28);
            this.chkBreak.TabIndex = 6;
            this.chkBreak.Text = "계좌정지 (체크시 정지상태임)";
            this.chkBreak.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCardLength);
            this.groupBox1.Controls.Add(this.btnCardNoCk);
            this.groupBox1.Controls.Add(this.btnAccountCk);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.lblCardPwdLength);
            this.groupBox1.Controls.Add(this.lblAccPwdLength);
            this.groupBox1.Controls.Add(this.lblAccountLength);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPcode);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtCardPwd2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPwd2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkBreak);
            this.groupBox1.Controls.Add(this.txtAccount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.txtCardPwd1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPwd1);
            this.groupBox1.Controls.Add(this.txtCardNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 725);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // lblCardLength
            // 
            this.lblCardLength.AutoSize = true;
            this.lblCardLength.Font = new System.Drawing.Font("나눔고딕OTF", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCardLength.ForeColor = System.Drawing.Color.DimGray;
            this.lblCardLength.Location = new System.Drawing.Point(226, 433);
            this.lblCardLength.Name = "lblCardLength";
            this.lblCardLength.Size = new System.Drawing.Size(170, 13);
            this.lblCardLength.TabIndex = 109;
            this.lblCardLength.Text = "*카드번호 8자리를 입력해주십시오.";
            // 
            // btnCardNoCk
            // 
            this.btnCardNoCk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCardNoCk.Font = new System.Drawing.Font("나눔고딕OTF", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCardNoCk.Location = new System.Drawing.Point(479, 401);
            this.btnCardNoCk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCardNoCk.Name = "btnCardNoCk";
            this.btnCardNoCk.Size = new System.Drawing.Size(96, 31);
            this.btnCardNoCk.TabIndex = 106;
            this.btnCardNoCk.Text = "중복확인";
            this.btnCardNoCk.UseVisualStyleBackColor = true;
            this.btnCardNoCk.Click += new System.EventHandler(this.btnCardNoCk_Click);
            // 
            // btnAccountCk
            // 
            this.btnAccountCk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountCk.Font = new System.Drawing.Font("나눔고딕OTF", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAccountCk.Location = new System.Drawing.Point(479, 221);
            this.btnAccountCk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccountCk.Name = "btnAccountCk";
            this.btnAccountCk.Size = new System.Drawing.Size(96, 31);
            this.btnAccountCk.TabIndex = 105;
            this.btnAccountCk.Text = "중복확인";
            this.btnAccountCk.UseVisualStyleBackColor = true;
            this.btnAccountCk.Click += new System.EventHandler(this.btnAccountCk_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // lblCardPwdLength
            // 
            this.lblCardPwdLength.AutoSize = true;
            this.lblCardPwdLength.Font = new System.Drawing.Font("나눔고딕OTF", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCardPwdLength.ForeColor = System.Drawing.Color.DimGray;
            this.lblCardPwdLength.Location = new System.Drawing.Point(226, 486);
            this.lblCardPwdLength.Name = "lblCardPwdLength";
            this.lblCardPwdLength.Size = new System.Drawing.Size(190, 13);
            this.lblCardPwdLength.TabIndex = 40;
            this.lblCardPwdLength.Text = "*카드비밀번호 4자리를 입력해주십시오.";
            // 
            // lblAccPwdLength
            // 
            this.lblAccPwdLength.AutoSize = true;
            this.lblAccPwdLength.Font = new System.Drawing.Font("나눔고딕OTF", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAccPwdLength.ForeColor = System.Drawing.Color.DimGray;
            this.lblAccPwdLength.Location = new System.Drawing.Point(226, 318);
            this.lblAccPwdLength.Name = "lblAccPwdLength";
            this.lblAccPwdLength.Size = new System.Drawing.Size(180, 13);
            this.lblAccPwdLength.TabIndex = 39;
            this.lblAccPwdLength.Text = "*비밀번호는 4자리를 입력해주십시오.";
            // 
            // lblAccountLength
            // 
            this.lblAccountLength.AutoSize = true;
            this.lblAccountLength.Font = new System.Drawing.Font("나눔고딕OTF", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAccountLength.ForeColor = System.Drawing.Color.DimGray;
            this.lblAccountLength.Location = new System.Drawing.Point(226, 257);
            this.lblAccountLength.Name = "lblAccountLength";
            this.lblAccountLength.Size = new System.Drawing.Size(187, 13);
            this.lblAccountLength.TabIndex = 38;
            this.lblAccountLength.Text = "*계좌번호는 10자리를 입력해주십시오.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(331, 147);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 24);
            this.label9.TabIndex = 37;
            this.label9.Text = "고객코드";
            // 
            // txtPcode
            // 
            this.txtPcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPcode.Enabled = false;
            this.txtPcode.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPcode.Location = new System.Drawing.Point(422, 143);
            this.txtPcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPcode.Name = "txtPcode";
            this.txtPcode.ReadOnly = true;
            this.txtPcode.Size = new System.Drawing.Size(203, 32);
            this.txtPcode.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(36, 147);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 24);
            this.label8.TabIndex = 35;
            this.label8.Text = "고객명";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(108, 143);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(203, 32);
            this.txtName.TabIndex = 34;
            // 
            // txtCardPwd2
            // 
            this.txtCardPwd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCardPwd2.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCardPwd2.Location = new System.Drawing.Point(226, 507);
            this.txtCardPwd2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCardPwd2.MaxLength = 4;
            this.txtCardPwd2.Name = "txtCardPwd2";
            this.txtCardPwd2.PasswordChar = '*';
            this.txtCardPwd2.Size = new System.Drawing.Size(129, 32);
            this.txtCardPwd2.TabIndex = 5;
            this.txtCardPwd2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPwd1_KeyPress);
            this.txtCardPwd2.Leave += new System.EventHandler(this.txtCardPwd2_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(31, 509);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "카드비밀번호 확인";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(345, 635);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(221, 41);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(71, 337);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "비밀번호 확인";
            // 
            // txtPwd2
            // 
            this.txtPwd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPwd2.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPwd2.Location = new System.Drawing.Point(226, 335);
            this.txtPwd2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPwd2.MaxLength = 4;
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.PasswordChar = '*';
            this.txtPwd2.Size = new System.Drawing.Size(129, 32);
            this.txtPwd2.TabIndex = 2;
            this.txtPwd2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPwd1_KeyPress);
            this.txtPwd2.Leave += new System.EventHandler(this.txtPwd2_Leave);
            // 
            // frm_03_3_계좌등록수정
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(704, 753);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_03_3_계좌등록수정";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "계좌등록 및 수정";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCardPwd1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPwd1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chkBreak;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCardPwd2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPwd2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPcode;
        private System.Windows.Forms.Label lblAccountLength;
        private System.Windows.Forms.Label lblCardPwdLength;
        private System.Windows.Forms.Label lblAccPwdLength;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCardNoCk;
        private System.Windows.Forms.Button btnAccountCk;
        private System.Windows.Forms.Label lblCardLength;
    }
}