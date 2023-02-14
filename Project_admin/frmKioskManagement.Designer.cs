namespace Project_admin
{
    partial class frmKioskManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKioskManagement));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvKiosk = new System.Windows.Forms.DataGridView();
            this.kCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKioskSearch = new System.Windows.Forms.Button();
            this.txtKiosk = new System.Windows.Forms.TextBox();
            this.dgvKioskHistory = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpHistoryDate1 = new System.Windows.Forms.DateTimePicker();
            this.btnKHistorySearch = new System.Windows.Forms.Button();
            this.dtpHistoryDate2 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiosk)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKioskHistory)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(25, 121);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvKiosk);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvKioskHistory);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1368, 787);
            this.splitContainer1.SplitterDistance = 758;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvKiosk
            // 
            this.dgvKiosk.AllowUserToAddRows = false;
            this.dgvKiosk.AllowUserToResizeColumns = false;
            this.dgvKiosk.AllowUserToResizeRows = false;
            this.dgvKiosk.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕OTF", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKiosk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKiosk.ColumnHeadersHeight = 30;
            this.dgvKiosk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kCODE,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKiosk.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvKiosk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKiosk.Location = new System.Drawing.Point(0, 60);
            this.dgvKiosk.Name = "dgvKiosk";
            this.dgvKiosk.ReadOnly = true;
            this.dgvKiosk.RowHeadersVisible = false;
            this.dgvKiosk.RowTemplate.Height = 30;
            this.dgvKiosk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKiosk.Size = new System.Drawing.Size(758, 653);
            this.dgvKiosk.TabIndex = 2;
            this.dgvKiosk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKiosk_CellClick);
            this.dgvKiosk.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvKiosk_CellFormatting);
            // 
            // kCODE
            // 
            this.kCODE.DataPropertyName = "KCODE";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kCODE.DefaultCellStyle = dataGridViewCellStyle2;
            this.kCODE.HeaderText = "번호";
            this.kCODE.Name = "kCODE";
            this.kCODE.ReadOnly = true;
            this.kCODE.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NAME";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "이름";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CASH";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "보유금";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CDATE";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.HeaderText = "등록일";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 220;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "BCODE";
            this.Column6.HeaderText = "BCODE";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("나눔스퀘어 네오 OTF Regular", 10F);
            this.panel3.Location = new System.Drawing.Point(0, 713);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(758, 74);
            this.panel3.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(227, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 48);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEdit.Location = new System.Drawing.Point(114, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 48);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "수정";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(1, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 48);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "추가";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnKioskSearch);
            this.panel1.Controls.Add(this.txtKiosk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 60);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(4, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "키오스크 관리";
            // 
            // btnKioskSearch
            // 
            this.btnKioskSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKioskSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKioskSearch.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnKioskSearch.Location = new System.Drawing.Point(643, 15);
            this.btnKioskSearch.Name = "btnKioskSearch";
            this.btnKioskSearch.Size = new System.Drawing.Size(114, 31);
            this.btnKioskSearch.TabIndex = 1;
            this.btnKioskSearch.Text = "검색";
            this.btnKioskSearch.UseVisualStyleBackColor = true;
            this.btnKioskSearch.Click += new System.EventHandler(this.btnKioskSearch_Click);
            // 
            // txtKiosk
            // 
            this.txtKiosk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKiosk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKiosk.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtKiosk.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtKiosk.Location = new System.Drawing.Point(354, 19);
            this.txtKiosk.Name = "txtKiosk";
            this.txtKiosk.Size = new System.Drawing.Size(277, 26);
            this.txtKiosk.TabIndex = 0;
            this.txtKiosk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKiosk_KeyPress);
            this.txtKiosk.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKiosk_KeyUp);
            // 
            // dgvKioskHistory
            // 
            this.dgvKioskHistory.AllowUserToAddRows = false;
            this.dgvKioskHistory.AllowUserToResizeColumns = false;
            this.dgvKioskHistory.AllowUserToResizeRows = false;
            this.dgvKioskHistory.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("나눔고딕OTF", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKioskHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvKioskHistory.ColumnHeadersHeight = 30;
            this.dgvKioskHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKioskHistory.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvKioskHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKioskHistory.Location = new System.Drawing.Point(0, 60);
            this.dgvKioskHistory.Name = "dgvKioskHistory";
            this.dgvKioskHistory.ReadOnly = true;
            this.dgvKioskHistory.RowHeadersVisible = false;
            this.dgvKioskHistory.RowTemplate.Height = 30;
            this.dgvKioskHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKioskHistory.Size = new System.Drawing.Size(606, 653);
            this.dgvKioskHistory.TabIndex = 3;
            this.dgvKioskHistory.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvKioskHistory_CellFormatting);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TRANS_INFO";
            this.Column4.HeaderText = "구분코드";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            this.Column4.Width = 80;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TRANS_INFO_NAME";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column1.HeaderText = "구분";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CASH";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn2.HeaderText = "현금";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CDATE";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn3.HeaderText = "일시";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 230;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 713);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(606, 74);
            this.panel4.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpHistoryDate1);
            this.panel2.Controls.Add(this.btnKHistorySearch);
            this.panel2.Controls.Add(this.dtpHistoryDate2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 60);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕코딩", 15F);
            this.label4.Location = new System.Drawing.Point(306, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "~";
            // 
            // dtpHistoryDate1
            // 
            this.dtpHistoryDate1.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpHistoryDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHistoryDate1.Location = new System.Drawing.Point(148, 17);
            this.dtpHistoryDate1.Name = "dtpHistoryDate1";
            this.dtpHistoryDate1.Size = new System.Drawing.Size(153, 26);
            this.dtpHistoryDate1.TabIndex = 5;
            // 
            // btnKHistorySearch
            // 
            this.btnKHistorySearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKHistorySearch.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnKHistorySearch.Location = new System.Drawing.Point(492, 15);
            this.btnKHistorySearch.Name = "btnKHistorySearch";
            this.btnKHistorySearch.Size = new System.Drawing.Size(114, 31);
            this.btnKHistorySearch.TabIndex = 7;
            this.btnKHistorySearch.Text = "검색";
            this.btnKHistorySearch.UseVisualStyleBackColor = true;
            this.btnKHistorySearch.Click += new System.EventHandler(this.btnKHistorySearch_Click);
            // 
            // dtpHistoryDate2
            // 
            this.dtpHistoryDate2.CalendarFont = new System.Drawing.Font("나눔스퀘어 네오 OTF Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpHistoryDate2.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpHistoryDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHistoryDate2.Location = new System.Drawing.Point(329, 17);
            this.dtpHistoryDate2.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpHistoryDate2.Name = "dtpHistoryDate2";
            this.dtpHistoryDate2.Size = new System.Drawing.Size(153, 26);
            this.dtpHistoryDate2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // frm_05_1_KIOSK관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1422, 971);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_05_1_KIOSK관리";
            this.Text = "키오스크관리";
            this.Load += new System.EventHandler(this.frm_05_1_KIOSK관리_Load);
            this.Shown += new System.EventHandler(this.frm_05_1_KIOSK관리_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiosk)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKioskHistory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvKiosk;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKioskSearch;
        private System.Windows.Forms.TextBox txtKiosk;
        private System.Windows.Forms.DataGridView dgvKioskHistory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpHistoryDate1;
        private System.Windows.Forms.Button btnKHistorySearch;
        private System.Windows.Forms.DateTimePicker dtpHistoryDate2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn kCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}