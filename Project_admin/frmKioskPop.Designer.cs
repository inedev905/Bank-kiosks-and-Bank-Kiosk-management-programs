namespace Project_admin
{
    partial class frmKioskPop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKioskPop));
            this.txtKioskCash = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKioskName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picAdImage = new System.Windows.Forms.PictureBox();
            this.btnAdImage = new System.Windows.Forms.Button();
            this.picBackImage = new System.Windows.Forms.PictureBox();
            this.btnBackImage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtKioskCode = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAdImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKioskCash
            // 
            this.txtKioskCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKioskCash.Font = new System.Drawing.Font("나눔스퀘어 네오 OTF Regular", 15.75F);
            this.txtKioskCash.Location = new System.Drawing.Point(313, 226);
            this.txtKioskCash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKioskCash.Name = "txtKioskCash";
            this.txtKioskCash.Size = new System.Drawing.Size(233, 31);
            this.txtKioskCash.TabIndex = 1;
            this.txtKioskCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKioskCash_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(125, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "키오스크 보유금 :";
            // 
            // txtKioskName
            // 
            this.txtKioskName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKioskName.Font = new System.Drawing.Font("나눔스퀘어 네오 OTF Regular", 15.75F);
            this.txtKioskName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtKioskName.Location = new System.Drawing.Point(313, 173);
            this.txtKioskName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKioskName.Name = "txtKioskName";
            this.txtKioskName.Size = new System.Drawing.Size(233, 31);
            this.txtKioskName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(145, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "키오스크 이름 :";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(86, 721);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(226, 43);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(150, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "키오스크코드 :";
            // 
            // picAdImage
            // 
            this.picAdImage.Image = ((System.Drawing.Image)(resources.GetObject("picAdImage.Image")));
            this.picAdImage.Location = new System.Drawing.Point(56, 292);
            this.picAdImage.Name = "picAdImage";
            this.picAdImage.Size = new System.Drawing.Size(270, 124);
            this.picAdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdImage.TabIndex = 40;
            this.picAdImage.TabStop = false;
            // 
            // btnAdImage
            // 
            this.btnAdImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdImage.Font = new System.Drawing.Font("나눔고딕OTF", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdImage.Location = new System.Drawing.Point(344, 384);
            this.btnAdImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdImage.Name = "btnAdImage";
            this.btnAdImage.Size = new System.Drawing.Size(222, 32);
            this.btnAdImage.TabIndex = 2;
            this.btnAdImage.Text = "광고이미지 찾기";
            this.btnAdImage.UseVisualStyleBackColor = true;
            this.btnAdImage.Click += new System.EventHandler(this.btnAdImage_Click);
            // 
            // picBackImage
            // 
            this.picBackImage.Image = ((System.Drawing.Image)(resources.GetObject("picBackImage.Image")));
            this.picBackImage.Location = new System.Drawing.Point(56, 442);
            this.picBackImage.Name = "picBackImage";
            this.picBackImage.Size = new System.Drawing.Size(270, 243);
            this.picBackImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackImage.TabIndex = 42;
            this.picBackImage.TabStop = false;
            // 
            // btnBackImage
            // 
            this.btnBackImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackImage.Font = new System.Drawing.Font("나눔고딕OTF", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBackImage.Location = new System.Drawing.Point(344, 653);
            this.btnBackImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackImage.Name = "btnBackImage";
            this.btnBackImage.Size = new System.Drawing.Size(222, 32);
            this.btnBackImage.TabIndex = 3;
            this.btnBackImage.Text = "배경이미지 찾기";
            this.btnBackImage.UseVisualStyleBackColor = true;
            this.btnBackImage.Click += new System.EventHandler(this.btnBackImage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.txtKioskCode);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBackImage);
            this.groupBox1.Controls.Add(this.picBackImage);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnAdImage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.picAdImage);
            this.groupBox1.Controls.Add(this.txtKioskName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKioskCash);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 809);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // txtKioskCode
            // 
            this.txtKioskCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKioskCode.Enabled = false;
            this.txtKioskCode.Font = new System.Drawing.Font("나눔스퀘어 네오 OTF Regular", 15.75F);
            this.txtKioskCode.Location = new System.Drawing.Point(313, 118);
            this.txtKioskCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKioskCode.Name = "txtKioskCode";
            this.txtKioskCode.ReadOnly = true;
            this.txtKioskCode.Size = new System.Drawing.Size(179, 31);
            this.txtKioskCode.TabIndex = 45;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(323, 721);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(226, 43);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmKioskPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(702, 856);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKioskPop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.picAdImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtKioskCash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKioskName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picAdImage;
        private System.Windows.Forms.Button btnAdImage;
        private System.Windows.Forms.PictureBox picBackImage;
        private System.Windows.Forms.Button btnBackImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtKioskCode;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}