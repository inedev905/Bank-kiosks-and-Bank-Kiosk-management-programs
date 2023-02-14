namespace Project_admin
{
    partial class frmCustomerAccountManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerAccountManagement));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvCustmer = new System.Windows.Forms.DataGridView();
            this.pPCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNBR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerEdit = new System.Windows.Forms.Button();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.aPCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aACODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHISTORY = new System.Windows.Forms.Button();
            this.btnAccountDelete = new System.Windows.Forms.Button();
            this.btnAccountEdit = new System.Windows.Forms.Button();
            this.btnAccountAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAccountSearch = new System.Windows.Forms.Button();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustmer)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(26, 118);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvCustmer);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvAccount);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1348, 787);
            this.splitContainer1.SplitterDistance = 585;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvCustmer
            // 
            this.dgvCustmer.AllowUserToAddRows = false;
            this.dgvCustmer.AllowUserToResizeColumns = false;
            this.dgvCustmer.AllowUserToResizeRows = false;
            this.dgvCustmer.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustmer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustmer.ColumnHeadersHeight = 30;
            this.dgvCustmer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pPCODE,
            this.pNAME,
            this.pNBR,
            this.pPHONE});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustmer.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCustmer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustmer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCustmer.Location = new System.Drawing.Point(0, 59);
            this.dgvCustmer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvCustmer.Name = "dgvCustmer";
            this.dgvCustmer.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("나눔고딕OTF", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustmer.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCustmer.RowHeadersVisible = false;
            this.dgvCustmer.RowTemplate.Height = 30;
            this.dgvCustmer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustmer.Size = new System.Drawing.Size(585, 650);
            this.dgvCustmer.TabIndex = 2;
            this.dgvCustmer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustmer_CellClick);
            this.dgvCustmer.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCustmer_CellFormatting);
            // 
            // pPCODE
            // 
            this.pPCODE.DataPropertyName = "PCODE";
            this.pPCODE.HeaderText = "PCODE";
            this.pPCODE.Name = "pPCODE";
            this.pPCODE.ReadOnly = true;
            this.pPCODE.Visible = false;
            // 
            // pNAME
            // 
            this.pNAME.DataPropertyName = "NAME";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.pNAME.DefaultCellStyle = dataGridViewCellStyle2;
            this.pNAME.HeaderText = "성명";
            this.pNAME.Name = "pNAME";
            this.pNAME.ReadOnly = true;
            this.pNAME.Width = 120;
            // 
            // pNBR
            // 
            this.pNBR.DataPropertyName = "NBR";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N0";
            this.pNBR.DefaultCellStyle = dataGridViewCellStyle3;
            this.pNBR.HeaderText = "주민등록번호";
            this.pNBR.Name = "pNBR";
            this.pNBR.ReadOnly = true;
            this.pNBR.Width = 170;
            // 
            // pPHONE
            // 
            this.pPHONE.DataPropertyName = "PHONE";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = null;
            this.pPHONE.DefaultCellStyle = dataGridViewCellStyle4;
            this.pPHONE.HeaderText = "연락처";
            this.pPHONE.Name = "pPHONE";
            this.pPHONE.ReadOnly = true;
            this.pPHONE.Width = 200;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCustomerDelete);
            this.panel3.Controls.Add(this.btnCustomerEdit);
            this.panel3.Controls.Add(this.btnCustomerAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("나눔스퀘어 네오 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel3.Location = new System.Drawing.Point(0, 709);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(585, 78);
            this.panel3.TabIndex = 1;
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerDelete.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCustomerDelete.Location = new System.Drawing.Point(214, 16);
            this.btnCustomerDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(99, 41);
            this.btnCustomerDelete.TabIndex = 4;
            this.btnCustomerDelete.Text = "삭제";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnCustomerEdit
            // 
            this.btnCustomerEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerEdit.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCustomerEdit.Location = new System.Drawing.Point(108, 16);
            this.btnCustomerEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCustomerEdit.Name = "btnCustomerEdit";
            this.btnCustomerEdit.Size = new System.Drawing.Size(99, 41);
            this.btnCustomerEdit.TabIndex = 3;
            this.btnCustomerEdit.Text = "수정";
            this.btnCustomerEdit.UseVisualStyleBackColor = true;
            this.btnCustomerEdit.Click += new System.EventHandler(this.btnCustomerEdit_Click);
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerAdd.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCustomerAdd.Location = new System.Drawing.Point(0, 16);
            this.btnCustomerAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(99, 41);
            this.btnCustomerAdd.TabIndex = 2;
            this.btnCustomerAdd.Text = "추가";
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCustomerSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 59);
            this.panel1.TabIndex = 0;
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerSearch.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCustomerSearch.Location = new System.Drawing.Point(469, 12);
            this.btnCustomerSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(115, 32);
            this.btnCustomerSearch.TabIndex = 1;
            this.btnCustomerSearch.Text = "검색";
            this.btnCustomerSearch.UseVisualStyleBackColor = true;
            this.btnCustomerSearch.Click += new System.EventHandler(this.btnCustomerSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕OTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "고객 및 계좌관리";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomer.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCustomer.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtCustomer.Location = new System.Drawing.Point(220, 16);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(239, 26);
            this.txtCustomer.TabIndex = 0;
            this.txtCustomer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCustomer_KeyUp);
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToResizeColumns = false;
            this.dgvAccount.AllowUserToResizeRows = false;
            this.dgvAccount.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAccount.ColumnHeadersHeight = 30;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aPCode,
            this.aACODE,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccount.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccount.Location = new System.Drawing.Point(0, 59);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("나눔고딕OTF", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAccount.RowHeadersVisible = false;
            this.dgvAccount.RowTemplate.Height = 30;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(759, 650);
            this.dgvAccount.TabIndex = 3;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            this.dgvAccount.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAccount_CellFormatting);
            // 
            // aPCode
            // 
            this.aPCode.DataPropertyName = "PCODE";
            this.aPCode.HeaderText = "PCODE";
            this.aPCode.Name = "aPCode";
            this.aPCode.ReadOnly = true;
            this.aPCode.Visible = false;
            // 
            // aACODE
            // 
            this.aACODE.DataPropertyName = "ACODE";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.aACODE.DefaultCellStyle = dataGridViewCellStyle8;
            this.aACODE.HeaderText = "계좌번호";
            this.aACODE.Name = "aACODE";
            this.aACODE.ReadOnly = true;
            this.aACODE.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ASSET";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column3.HeaderText = "잔고";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 220;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "STATUS_YN";
            this.Column4.FalseValue = "N";
            this.Column4.HeaderText = "정지여부";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.TrueValue = "Y";
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CARD_YN";
            this.Column5.FalseValue = "N";
            this.Column5.HeaderText = "카드여부";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.TrueValue = "Y";
            this.Column5.Width = 120;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnHISTORY);
            this.panel4.Controls.Add(this.btnAccountDelete);
            this.panel4.Controls.Add(this.btnAccountEdit);
            this.panel4.Controls.Add(this.btnAccountAdd);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Font = new System.Drawing.Font("나눔스퀘어 네오 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel4.Location = new System.Drawing.Point(0, 709);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(759, 78);
            this.panel4.TabIndex = 2;
            // 
            // btnHISTORY
            // 
            this.btnHISTORY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHISTORY.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHISTORY.Location = new System.Drawing.Point(348, 16);
            this.btnHISTORY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHISTORY.Name = "btnHISTORY";
            this.btnHISTORY.Size = new System.Drawing.Size(411, 41);
            this.btnHISTORY.TabIndex = 10;
            this.btnHISTORY.Text = "이력보기";
            this.btnHISTORY.UseVisualStyleBackColor = true;
            this.btnHISTORY.Click += new System.EventHandler(this.btnHISTORY_Click);
            // 
            // btnAccountDelete
            // 
            this.btnAccountDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountDelete.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAccountDelete.Location = new System.Drawing.Point(232, 16);
            this.btnAccountDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAccountDelete.Name = "btnAccountDelete";
            this.btnAccountDelete.Size = new System.Drawing.Size(108, 41);
            this.btnAccountDelete.TabIndex = 9;
            this.btnAccountDelete.Text = "삭제";
            this.btnAccountDelete.UseVisualStyleBackColor = true;
            this.btnAccountDelete.Click += new System.EventHandler(this.btnAccountDelete_Click);
            // 
            // btnAccountEdit
            // 
            this.btnAccountEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountEdit.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAccountEdit.Location = new System.Drawing.Point(115, 16);
            this.btnAccountEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAccountEdit.Name = "btnAccountEdit";
            this.btnAccountEdit.Size = new System.Drawing.Size(108, 41);
            this.btnAccountEdit.TabIndex = 8;
            this.btnAccountEdit.Text = "수정";
            this.btnAccountEdit.UseVisualStyleBackColor = true;
            this.btnAccountEdit.Click += new System.EventHandler(this.btnAccountEdit_Click);
            // 
            // btnAccountAdd
            // 
            this.btnAccountAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountAdd.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAccountAdd.Location = new System.Drawing.Point(0, 16);
            this.btnAccountAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAccountAdd.Name = "btnAccountAdd";
            this.btnAccountAdd.Size = new System.Drawing.Size(108, 41);
            this.btnAccountAdd.TabIndex = 7;
            this.btnAccountAdd.Text = "추가";
            this.btnAccountAdd.UseVisualStyleBackColor = true;
            this.btnAccountAdd.Click += new System.EventHandler(this.btnAccountAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAccountSearch);
            this.panel2.Controls.Add(this.txtAccount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 59);
            this.panel2.TabIndex = 1;
            // 
            // btnAccountSearch
            // 
            this.btnAccountSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccountSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountSearch.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAccountSearch.Location = new System.Drawing.Point(642, 12);
            this.btnAccountSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAccountSearch.Name = "btnAccountSearch";
            this.btnAccountSearch.Size = new System.Drawing.Size(115, 32);
            this.btnAccountSearch.TabIndex = 6;
            this.btnAccountSearch.Text = "검색";
            this.btnAccountSearch.UseVisualStyleBackColor = true;
            this.btnAccountSearch.Click += new System.EventHandler(this.btnAccountSearch_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccount.Font = new System.Drawing.Font("나눔고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtAccount.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtAccount.Location = new System.Drawing.Point(397, 16);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(239, 26);
            this.txtAccount.TabIndex = 5;
            this.txtAccount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAccount_KeyUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(28, 37);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // frm_03_1_고객및계좌관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1412, 934);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_03_1_고객및계좌관리";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "고객및계좌관리";
            this.Load += new System.EventHandler(this.frm_03_1_고객및계좌관리_Load);
            this.Shown += new System.EventHandler(this.frm_03_1_고객및계좌관리_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustmer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvCustmer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerEdit;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCustomerSearch;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAccountDelete;
        private System.Windows.Forms.Button btnAccountEdit;
        private System.Windows.Forms.Button btnAccountAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAccountSearch;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHISTORY;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn aACODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNBR;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPHONE;
    }
}