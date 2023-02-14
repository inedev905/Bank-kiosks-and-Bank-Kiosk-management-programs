namespace Project_admin
{
    partial class frmBankingManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankingManagement));
            this.lblCash = new System.Windows.Forms.Label();
            this.lblAsset = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.txtPWD1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPWD2 = new System.Windows.Forms.Label();
            this.lblPWD1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPWD2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCash
            // 
            this.lblCash.Font = new System.Drawing.Font("나눔고딕OTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCash.Location = new System.Drawing.Point(319, 127);
            this.lblCash.Margin = new System.Windows.Forms.Padding(0);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(301, 24);
            this.lblCash.TabIndex = 19;
            this.lblCash.Text = "999,999,999,999";
            this.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAsset
            // 
            this.lblAsset.Font = new System.Drawing.Font("나눔고딕OTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAsset.Location = new System.Drawing.Point(319, 166);
            this.lblAsset.Margin = new System.Windows.Forms.Padding(0);
            this.lblAsset.Name = "lblAsset";
            this.lblAsset.Size = new System.Drawing.Size(301, 24);
            this.lblAsset.TabIndex = 18;
            this.lblAsset.Text = "999,999,999,999,999";
            this.lblAsset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕OTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(271, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "구디 은행";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕OTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(146, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "은행 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕OTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(113, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 31);
            this.label6.TabIndex = 24;
            this.label6.Text = "은행 명 :";
            // 
            // txtBankName
            // 
            this.txtBankName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankName.Font = new System.Drawing.Font("나눔고딕OTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBankName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtBankName.Location = new System.Drawing.Point(271, 90);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(255, 41);
            this.txtBankName.TabIndex = 0;
            // 
            // txtPWD1
            // 
            this.txtPWD1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPWD1.Font = new System.Drawing.Font("나눔고딕OTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPWD1.Location = new System.Drawing.Point(271, 58);
            this.txtPWD1.MaxLength = 4;
            this.txtPWD1.Name = "txtPWD1";
            this.txtPWD1.PasswordChar = '*';
            this.txtPWD1.Size = new System.Drawing.Size(255, 41);
            this.txtPWD1.TabIndex = 1;
            this.txtPWD1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPWD1_KeyPress);
            this.txtPWD1.Leave += new System.EventHandler(this.txtPWD1_Leave);
            this.txtPWD1.Validated += new System.EventHandler(this.txtPWD1_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕OTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(94, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 31);
            this.label7.TabIndex = 26;
            this.label7.Text = "비밀번호 :";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("나눔스퀘어 네오 OTF Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(107, 666);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(221, 46);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblPWD2);
            this.groupBox1.Controls.Add(this.lblPWD1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPWD2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPWD1);
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕OTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(48, 427);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 209);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "관리프로그램 재설정";
            // 
            // lblPWD2
            // 
            this.lblPWD2.Font = new System.Drawing.Font("나눔고딕OTF", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPWD2.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPWD2.Location = new System.Drawing.Point(295, 109);
            this.lblPWD2.Name = "lblPWD2";
            this.lblPWD2.Size = new System.Drawing.Size(231, 16);
            this.lblPWD2.TabIndex = 31;
            this.lblPWD2.Text = "*패스워드를 입력해주십시오.";
            this.lblPWD2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPWD1
            // 
            this.lblPWD1.Font = new System.Drawing.Font("나눔고딕OTF", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPWD1.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPWD1.Location = new System.Drawing.Point(295, 39);
            this.lblPWD1.Name = "lblPWD1";
            this.lblPWD1.Size = new System.Drawing.Size(231, 16);
            this.lblPWD1.TabIndex = 30;
            this.lblPWD1.Text = "*패스워드를 입력해주십시오.";
            this.lblPWD1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕OTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(35, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 31);
            this.label8.TabIndex = 28;
            this.label8.Text = "비밀번호 확인 :";
            // 
            // txtPWD2
            // 
            this.txtPWD2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPWD2.Font = new System.Drawing.Font("나눔고딕OTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPWD2.Location = new System.Drawing.Point(271, 128);
            this.txtPWD2.MaxLength = 4;
            this.txtPWD2.Name = "txtPWD2";
            this.txtPWD2.PasswordChar = '*';
            this.txtPWD2.Size = new System.Drawing.Size(255, 41);
            this.txtPWD2.TabIndex = 2;
            this.txtPWD2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPWD2_KeyPress);
            this.txtPWD2.Leave += new System.EventHandler(this.txtPWD2_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBankName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("나눔고딕OTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(48, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(604, 159);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "은행정보";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("나눔스퀘어 네오 OTF Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(349, 666);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(221, 46);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕OTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(239, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 28);
            this.label9.TabIndex = 31;
            this.label9.Text = "보유고:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔고딕OTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(262, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 28);
            this.label10.TabIndex = 32;
            this.label10.Text = "자산:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(622, 128);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 24);
            this.label11.TabIndex = 34;
            this.label11.Text = "원";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(622, 167);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 24);
            this.label12.TabIndex = 35;
            this.label12.Text = "원";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // frm_04_1_은행관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(721, 764);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.lblAsset);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_04_1_은행관리";
            this.Text = "은행관리";
            this.Load += new System.EventHandler(this.frm_04_1_은행관리_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblAsset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.TextBox txtPWD1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPWD2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPWD2;
        private System.Windows.Forms.Label lblPWD1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}