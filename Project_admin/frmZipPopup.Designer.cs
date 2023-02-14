namespace Project_admin
{
    partial class frmZipPopup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZipPopup));
            this.btnJibun = new System.Windows.Forms.Button();
            this.txtJibunAddr2 = new System.Windows.Forms.TextBox();
            this.txtJibunAddr1 = new System.Windows.Forms.TextBox();
            this.txtJibunZip = new System.Windows.Forms.TextBox();
            this.btnRoad = new System.Windows.Forms.Button();
            this.txtRoadAddr2 = new System.Windows.Forms.TextBox();
            this.txtRoadAddr1 = new System.Windows.Forms.TextBox();
            this.txtRoadZip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvZip = new System.Windows.Forms.DataGridView();
            this.zipNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roadAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readAddrPart1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roadAddrPart2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jibunAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJibun
            // 
            this.btnJibun.Font = new System.Drawing.Font("나눔고딕OTF", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnJibun.Location = new System.Drawing.Point(37, 721);
            this.btnJibun.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnJibun.Name = "btnJibun";
            this.btnJibun.Size = new System.Drawing.Size(160, 53);
            this.btnJibun.TabIndex = 54;
            this.btnJibun.Text = "지번주소 확인";
            this.btnJibun.UseVisualStyleBackColor = true;
            this.btnJibun.Click += new System.EventHandler(this.btnJibun_Click);
            // 
            // txtJibunAddr2
            // 
            this.txtJibunAddr2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJibunAddr2.Font = new System.Drawing.Font("나눔고딕OTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtJibunAddr2.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtJibunAddr2.Location = new System.Drawing.Point(343, 754);
            this.txtJibunAddr2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtJibunAddr2.Name = "txtJibunAddr2";
            this.txtJibunAddr2.Size = new System.Drawing.Size(393, 29);
            this.txtJibunAddr2.TabIndex = 53;
            this.txtJibunAddr2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJibunAddr2_KeyPress);
            // 
            // txtJibunAddr1
            // 
            this.txtJibunAddr1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJibunAddr1.Font = new System.Drawing.Font("나눔고딕OTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtJibunAddr1.Location = new System.Drawing.Point(220, 720);
            this.txtJibunAddr1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtJibunAddr1.Name = "txtJibunAddr1";
            this.txtJibunAddr1.ReadOnly = true;
            this.txtJibunAddr1.Size = new System.Drawing.Size(516, 29);
            this.txtJibunAddr1.TabIndex = 52;
            // 
            // txtJibunZip
            // 
            this.txtJibunZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJibunZip.Font = new System.Drawing.Font("나눔고딕OTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtJibunZip.Location = new System.Drawing.Point(220, 754);
            this.txtJibunZip.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtJibunZip.Name = "txtJibunZip";
            this.txtJibunZip.ReadOnly = true;
            this.txtJibunZip.Size = new System.Drawing.Size(119, 29);
            this.txtJibunZip.TabIndex = 51;
            this.txtJibunZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRoad
            // 
            this.btnRoad.Font = new System.Drawing.Font("나눔고딕OTF", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRoad.Location = new System.Drawing.Point(37, 630);
            this.btnRoad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRoad.Name = "btnRoad";
            this.btnRoad.Size = new System.Drawing.Size(160, 53);
            this.btnRoad.TabIndex = 50;
            this.btnRoad.Text = "도로명주소 확인";
            this.btnRoad.UseVisualStyleBackColor = true;
            this.btnRoad.Click += new System.EventHandler(this.btnRoad_Click);
            // 
            // txtRoadAddr2
            // 
            this.txtRoadAddr2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoadAddr2.Font = new System.Drawing.Font("나눔고딕OTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRoadAddr2.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtRoadAddr2.Location = new System.Drawing.Point(343, 664);
            this.txtRoadAddr2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRoadAddr2.Name = "txtRoadAddr2";
            this.txtRoadAddr2.Size = new System.Drawing.Size(393, 29);
            this.txtRoadAddr2.TabIndex = 49;
            this.txtRoadAddr2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRoadAddr2_KeyPress);
            // 
            // txtRoadAddr1
            // 
            this.txtRoadAddr1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoadAddr1.Font = new System.Drawing.Font("나눔고딕OTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRoadAddr1.Location = new System.Drawing.Point(220, 630);
            this.txtRoadAddr1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRoadAddr1.Name = "txtRoadAddr1";
            this.txtRoadAddr1.ReadOnly = true;
            this.txtRoadAddr1.Size = new System.Drawing.Size(516, 29);
            this.txtRoadAddr1.TabIndex = 48;
            // 
            // txtRoadZip
            // 
            this.txtRoadZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoadZip.Font = new System.Drawing.Font("나눔고딕OTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRoadZip.Location = new System.Drawing.Point(220, 664);
            this.txtRoadZip.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRoadZip.Name = "txtRoadZip";
            this.txtRoadZip.ReadOnly = true;
            this.txtRoadZip.Size = new System.Drawing.Size(119, 29);
            this.txtRoadZip.TabIndex = 47;
            this.txtRoadZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕OTF", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(87, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 23);
            this.label6.TabIndex = 46;
            this.label6.Text = "도로명(지번) 주소검색";
            // 
            // dgvZip
            // 
            this.dgvZip.AllowUserToAddRows = false;
            this.dgvZip.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕OTF", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvZip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zipNo,
            this.roadAddr,
            this.bdNm,
            this.readAddrPart1,
            this.roadAddrPart2,
            this.jibunAddr});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZip.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvZip.Location = new System.Drawing.Point(35, 165);
            this.dgvZip.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvZip.Name = "dgvZip";
            this.dgvZip.ReadOnly = true;
            this.dgvZip.RowHeadersVisible = false;
            this.dgvZip.RowHeadersWidth = 20;
            this.dgvZip.RowTemplate.Height = 23;
            this.dgvZip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZip.Size = new System.Drawing.Size(701, 436);
            this.dgvZip.TabIndex = 45;
            this.dgvZip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZip_CellClick);
            // 
            // zipNo
            // 
            this.zipNo.DataPropertyName = "zipNo";
            this.zipNo.HeaderText = "우편번호";
            this.zipNo.Name = "zipNo";
            this.zipNo.ReadOnly = true;
            this.zipNo.Width = 120;
            // 
            // roadAddr
            // 
            this.roadAddr.DataPropertyName = "roadAddr";
            this.roadAddr.HeaderText = "도로명주소";
            this.roadAddr.Name = "roadAddr";
            this.roadAddr.ReadOnly = true;
            this.roadAddr.Width = 300;
            // 
            // bdNm
            // 
            this.bdNm.DataPropertyName = "bdNm";
            this.bdNm.HeaderText = "건물명";
            this.bdNm.Name = "bdNm";
            this.bdNm.ReadOnly = true;
            this.bdNm.Width = 250;
            // 
            // readAddrPart1
            // 
            this.readAddrPart1.DataPropertyName = "roadAddrPart1";
            this.readAddrPart1.HeaderText = "도로명주소1";
            this.readAddrPart1.Name = "readAddrPart1";
            this.readAddrPart1.ReadOnly = true;
            this.readAddrPart1.Visible = false;
            // 
            // roadAddrPart2
            // 
            this.roadAddrPart2.DataPropertyName = "roadAddrPart2";
            this.roadAddrPart2.HeaderText = "도로명주소2";
            this.roadAddrPart2.Name = "roadAddrPart2";
            this.roadAddrPart2.ReadOnly = true;
            this.roadAddrPart2.Visible = false;
            // 
            // jibunAddr
            // 
            this.jibunAddr.DataPropertyName = "jibunAddr";
            this.jibunAddr.HeaderText = "지번주소";
            this.jibunAddr.Name = "jibunAddr";
            this.jibunAddr.ReadOnly = true;
            this.jibunAddr.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("나눔고딕OTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(581, 114);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 34);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeyword.Font = new System.Drawing.Font("나눔고딕OTF", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtKeyword.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtKeyword.Location = new System.Drawing.Point(293, 116);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(280, 30);
            this.txtKeyword.TabIndex = 43;
            this.txtKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyword_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("나눔고딕OTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(241, 801);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 34);
            this.button1.TabIndex = 56;
            this.button1.Text = "창 닫기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmZipPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 860);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnJibun);
            this.Controls.Add(this.txtJibunAddr2);
            this.Controls.Add(this.txtJibunAddr1);
            this.Controls.Add(this.txtJibunZip);
            this.Controls.Add(this.btnRoad);
            this.Controls.Add(this.txtRoadAddr2);
            this.Controls.Add(this.txtRoadAddr1);
            this.Controls.Add(this.txtRoadZip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvZip);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtKeyword);
            this.Name = "frmZipPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "우편번호 찾기";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJibun;
        private System.Windows.Forms.TextBox txtJibunAddr2;
        private System.Windows.Forms.TextBox txtJibunAddr1;
        private System.Windows.Forms.TextBox txtJibunZip;
        private System.Windows.Forms.Button btnRoad;
        private System.Windows.Forms.TextBox txtRoadAddr2;
        private System.Windows.Forms.TextBox txtRoadAddr1;
        private System.Windows.Forms.TextBox txtRoadZip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvZip;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn roadAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn readAddrPart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roadAddrPart2;
        private System.Windows.Forms.DataGridViewTextBoxColumn jibunAddr;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}