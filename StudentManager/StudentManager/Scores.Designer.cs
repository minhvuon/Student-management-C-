namespace StudentManager
{
    partial class frmScores
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSearchSemester = new System.Windows.Forms.Label();
            this.cbbSemester = new System.Windows.Forms.ComboBox();
            this.lblSearchClass = new System.Windows.Forms.Label();
            this.cbbSearchClass = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusBar2 = new System.Windows.Forms.StatusBar();
            this.sttSManager = new System.Windows.Forms.StatusBarPanel();
            this.sttDate = new System.Windows.Forms.StatusBarPanel();
            this.grbList = new System.Windows.Forms.GroupBox();
            this.dgrScores = new System.Windows.Forms.DataGridView();
            this.clClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiligenceScores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MidternScores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndtermScores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectMediumScores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbInformation = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbbIDSubject = new System.Windows.Forms.ComboBox();
            this.cbbIDStudent = new System.Windows.Forms.ComboBox();
            this.lblSubjectID = new System.Windows.Forms.Label();
            this.txtMidterm = new System.Windows.Forms.TextBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtEndterm = new System.Windows.Forms.TextBox();
            this.txtDiligence = new System.Windows.Forms.TextBox();
            this.lblEndterm = new System.Windows.Forms.Label();
            this.lblDiligence = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sttSManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sttDate)).BeginInit();
            this.grbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrScores)).BeginInit();
            this.grbInformation.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSearchSemester);
            this.panel1.Controls.Add(this.cbbSemester);
            this.panel1.Controls.Add(this.lblSearchClass);
            this.panel1.Controls.Add(this.cbbSearchClass);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 59);
            this.panel1.TabIndex = 40;
            // 
            // lblSearchSemester
            // 
            this.lblSearchSemester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchSemester.AutoSize = true;
            this.lblSearchSemester.Location = new System.Drawing.Point(441, 10);
            this.lblSearchSemester.Name = "lblSearchSemester";
            this.lblSearchSemester.Size = new System.Drawing.Size(54, 13);
            this.lblSearchSemester.TabIndex = 51;
            this.lblSearchSemester.Text = "Semester:";
            // 
            // cbbSemester
            // 
            this.cbbSemester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbSemester.FormattingEnabled = true;
            this.cbbSemester.Location = new System.Drawing.Point(501, 7);
            this.cbbSemester.Name = "cbbSemester";
            this.cbbSemester.Size = new System.Drawing.Size(74, 21);
            this.cbbSemester.TabIndex = 50;
            this.cbbSemester.SelectedIndexChanged += new System.EventHandler(this.cbbSemester_SelectedIndexChanged);
            this.cbbSemester.Click += new System.EventHandler(this.cbbSemester_Click);
            // 
            // lblSearchClass
            // 
            this.lblSearchClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchClass.AutoSize = true;
            this.lblSearchClass.Location = new System.Drawing.Point(577, 10);
            this.lblSearchClass.Name = "lblSearchClass";
            this.lblSearchClass.Size = new System.Drawing.Size(35, 13);
            this.lblSearchClass.TabIndex = 49;
            this.lblSearchClass.Text = "Class:";
            // 
            // cbbSearchClass
            // 
            this.cbbSearchClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbSearchClass.FormattingEnabled = true;
            this.cbbSearchClass.Items.AddRange(new object[] {
            "CNTT K40a",
            "CNTT K40b",
            "CNTT K40c"});
            this.cbbSearchClass.Location = new System.Drawing.Point(618, 7);
            this.cbbSearchClass.Name = "cbbSearchClass";
            this.cbbSearchClass.Size = new System.Drawing.Size(91, 21);
            this.cbbSearchClass.TabIndex = 1;
            this.cbbSearchClass.SelectedIndexChanged += new System.EventHandler(this.cbbSearchClass_SelectedIndexChanged);
            this.cbbSearchClass.Click += new System.EventHandler(this.cbbSearchClass_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Location = new System.Drawing.Point(715, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 20);
            this.panel3.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(136, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(126, 13);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Location = new System.Drawing.Point(0, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(406, 44);
            this.panel4.TabIndex = 42;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightCyan;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(305, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 36);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = " Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(204, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 36);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = " Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Azure;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.Location = new System.Drawing.Point(103, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 36);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = " Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(3, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 36);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = " Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.statusBar2);
            this.panel2.Controls.Add(this.grbList);
            this.panel2.Controls.Add(this.grbInformation);
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 413);
            this.panel2.TabIndex = 49;
            // 
            // statusBar2
            // 
            this.statusBar2.Location = new System.Drawing.Point(0, 391);
            this.statusBar2.Name = "statusBar2";
            this.statusBar2.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.sttSManager,
            this.sttDate});
            this.statusBar2.ShowPanels = true;
            this.statusBar2.Size = new System.Drawing.Size(876, 22);
            this.statusBar2.TabIndex = 40;
            this.statusBar2.Text = "statusBar2";
            // 
            // sttSManager
            // 
            this.sttSManager.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.sttSManager.Name = "sttSManager";
            this.sttSManager.Text = "Student Manager";
            this.sttSManager.Width = 719;
            // 
            // sttDate
            // 
            this.sttDate.Name = "sttDate";
            this.sttDate.Text = "Date";
            this.sttDate.Width = 140;
            // 
            // grbList
            // 
            this.grbList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbList.Controls.Add(this.dgrScores);
            this.grbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbList.Location = new System.Drawing.Point(0, 164);
            this.grbList.Name = "grbList";
            this.grbList.Size = new System.Drawing.Size(876, 221);
            this.grbList.TabIndex = 39;
            this.grbList.TabStop = false;
            this.grbList.Text = "List scores";
            // 
            // dgrScores
            // 
            this.dgrScores.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgrScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clClass,
            this.StudentID,
            this.clName,
            this.SubjectID,
            this.SubjectName,
            this.DiligenceScores,
            this.MidternScores,
            this.EndtermScores,
            this.SubjectMediumScores});
            this.dgrScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrScores.Location = new System.Drawing.Point(3, 18);
            this.dgrScores.Name = "dgrScores";
            this.dgrScores.Size = new System.Drawing.Size(870, 200);
            this.dgrScores.TabIndex = 18;
            // 
            // clClass
            // 
            this.clClass.DataPropertyName = "Class";
            this.clClass.HeaderText = "Class";
            this.clClass.MinimumWidth = 10;
            this.clClass.Name = "clClass";
            this.clClass.Width = 110;
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "IDStudent";
            this.StudentID.HeaderText = "Student id";
            this.StudentID.Name = "StudentID";
            this.StudentID.Width = 130;
            // 
            // clName
            // 
            this.clName.DataPropertyName = "NameStudent";
            this.clName.HeaderText = "Student name";
            this.clName.MinimumWidth = 10;
            this.clName.Name = "clName";
            this.clName.Width = 160;
            // 
            // SubjectID
            // 
            this.SubjectID.DataPropertyName = "IDSubject";
            this.SubjectID.HeaderText = "Subject id";
            this.SubjectID.Name = "SubjectID";
            this.SubjectID.Width = 130;
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.HeaderText = "Subject name";
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Width = 160;
            // 
            // DiligenceScores
            // 
            this.DiligenceScores.DataPropertyName = "DiligenceScores";
            this.DiligenceScores.HeaderText = "Diligence scores";
            this.DiligenceScores.MinimumWidth = 10;
            this.DiligenceScores.Name = "DiligenceScores";
            this.DiligenceScores.Width = 130;
            // 
            // MidternScores
            // 
            this.MidternScores.DataPropertyName = "MidtermScores";
            this.MidternScores.HeaderText = "Midtern scores";
            this.MidternScores.MinimumWidth = 10;
            this.MidternScores.Name = "MidternScores";
            this.MidternScores.Width = 130;
            // 
            // EndtermScores
            // 
            this.EndtermScores.DataPropertyName = "EndtermScores";
            this.EndtermScores.HeaderText = "Endterm scores";
            this.EndtermScores.Name = "EndtermScores";
            this.EndtermScores.Width = 130;
            // 
            // SubjectMediumScores
            // 
            this.SubjectMediumScores.DataPropertyName = "SubjectMediumScores";
            this.SubjectMediumScores.HeaderText = "Subject medium scores";
            this.SubjectMediumScores.Name = "SubjectMediumScores";
            this.SubjectMediumScores.Width = 130;
            // 
            // grbInformation
            // 
            this.grbInformation.Controls.Add(this.panel5);
            this.grbInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grbInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInformation.Location = new System.Drawing.Point(0, 0);
            this.grbInformation.Name = "grbInformation";
            this.grbInformation.Size = new System.Drawing.Size(876, 155);
            this.grbInformation.TabIndex = 38;
            this.grbInformation.TabStop = false;
            this.grbInformation.Text = "Scores information";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.cbbIDSubject);
            this.panel5.Controls.Add(this.cbbIDStudent);
            this.panel5.Controls.Add(this.lblSubjectID);
            this.panel5.Controls.Add(this.txtMidterm);
            this.panel5.Controls.Add(this.lblSemester);
            this.panel5.Controls.Add(this.lblID);
            this.panel5.Controls.Add(this.txtEndterm);
            this.panel5.Controls.Add(this.txtDiligence);
            this.panel5.Controls.Add(this.lblEndterm);
            this.panel5.Controls.Add(this.lblDiligence);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(870, 134);
            this.panel5.TabIndex = 43;
            // 
            // cbbIDSubject
            // 
            this.cbbIDSubject.FormattingEnabled = true;
            this.cbbIDSubject.Location = new System.Drawing.Point(142, 43);
            this.cbbIDSubject.Name = "cbbIDSubject";
            this.cbbIDSubject.Size = new System.Drawing.Size(179, 24);
            this.cbbIDSubject.TabIndex = 48;
            // 
            // cbbIDStudent
            // 
            this.cbbIDStudent.FormattingEnabled = true;
            this.cbbIDStudent.Location = new System.Drawing.Point(142, 8);
            this.cbbIDStudent.Name = "cbbIDStudent";
            this.cbbIDStudent.Size = new System.Drawing.Size(179, 24);
            this.cbbIDStudent.TabIndex = 47;
            // 
            // lblSubjectID
            // 
            this.lblSubjectID.AutoSize = true;
            this.lblSubjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectID.Location = new System.Drawing.Point(56, 52);
            this.lblSubjectID.Name = "lblSubjectID";
            this.lblSubjectID.Size = new System.Drawing.Size(68, 13);
            this.lblSubjectID.TabIndex = 46;
            this.lblSubjectID.Text = "Subject id:";
            // 
            // txtMidterm
            // 
            this.txtMidterm.Location = new System.Drawing.Point(593, 43);
            this.txtMidterm.Name = "txtMidterm";
            this.txtMidterm.Size = new System.Drawing.Size(249, 22);
            this.txtMidterm.TabIndex = 7;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(476, 48);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(96, 13);
            this.lblSemester.TabIndex = 44;
            this.lblSemester.Text = "Midterm scores:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(55, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(69, 13);
            this.lblID.TabIndex = 42;
            this.lblID.Text = "Student id:";
            // 
            // txtEndterm
            // 
            this.txtEndterm.Location = new System.Drawing.Point(593, 79);
            this.txtEndterm.Name = "txtEndterm";
            this.txtEndterm.Size = new System.Drawing.Size(249, 22);
            this.txtEndterm.TabIndex = 8;
            // 
            // txtDiligence
            // 
            this.txtDiligence.Location = new System.Drawing.Point(593, 8);
            this.txtDiligence.Name = "txtDiligence";
            this.txtDiligence.Size = new System.Drawing.Size(249, 22);
            this.txtDiligence.TabIndex = 6;
            // 
            // lblEndterm
            // 
            this.lblEndterm.AutoSize = true;
            this.lblEndterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndterm.Location = new System.Drawing.Point(474, 84);
            this.lblEndterm.Name = "lblEndterm";
            this.lblEndterm.Size = new System.Drawing.Size(98, 13);
            this.lblEndterm.TabIndex = 38;
            this.lblEndterm.Text = "Endterm scores:";
            // 
            // lblDiligence
            // 
            this.lblDiligence.AutoSize = true;
            this.lblDiligence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiligence.Location = new System.Drawing.Point(467, 13);
            this.lblDiligence.Name = "lblDiligence";
            this.lblDiligence.Size = new System.Drawing.Size(105, 13);
            this.lblDiligence.TabIndex = 36;
            this.lblDiligence.Text = "Diligence scores:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(876, 478);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmScores";
            this.Text = "Scores management";
            this.Load += new System.EventHandler(this.frmScores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sttSManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sttDate)).EndInit();
            this.grbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrScores)).EndInit();
            this.grbInformation.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearchClass;
        private System.Windows.Forms.ComboBox cbbSearchClass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusBar statusBar2;
        private System.Windows.Forms.StatusBarPanel sttSManager;
        private System.Windows.Forms.StatusBarPanel sttDate;
        private System.Windows.Forms.GroupBox grbList;
        private System.Windows.Forms.DataGridView dgrScores;
        private System.Windows.Forms.GroupBox grbInformation;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtMidterm;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtEndterm;
        private System.Windows.Forms.TextBox txtDiligence;
        private System.Windows.Forms.Label lblEndterm;
        private System.Windows.Forms.Label lblDiligence;
        private System.Windows.Forms.Label lblSubjectID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbbIDSubject;
        private System.Windows.Forms.ComboBox cbbIDStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn clClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiligenceScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn MidternScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndtermScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectMediumScores;
        private System.Windows.Forms.ComboBox cbbSemester;
        private System.Windows.Forms.Label lblSearchSemester;
    }
}