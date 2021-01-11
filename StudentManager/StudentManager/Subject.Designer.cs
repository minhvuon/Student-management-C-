namespace StudentManager
{
    partial class frmSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubject));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrSubjectOfStudent = new System.Windows.Forms.DataGridView();
            this.IDStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbbSubjectID = new System.Windows.Forms.ComboBox();
            this.cbbID = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.lblSubjectID = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.statusBar2 = new System.Windows.Forms.StatusBar();
            this.sttSManager = new System.Windows.Forms.StatusBarPanel();
            this.sttDate = new System.Windows.Forms.StatusBarPanel();
            this.grbStudent = new System.Windows.Forms.GroupBox();
            this.dgrSubject = new System.Windows.Forms.DataGridView();
            this.IDSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberCredits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbInformation = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.txtIDSubject = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.lblIDSubject = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblNameStudent = new System.Windows.Forms.Label();
            this.cbbStudentName = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblSearchSemester = new System.Windows.Forms.Label();
            this.cbbSemester = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSubjectOfStudent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sttSManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sttDate)).BeginInit();
            this.grbStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSubject)).BeginInit();
            this.grbInformation.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.statusBar2);
            this.panel2.Controls.Add(this.grbStudent);
            this.panel2.Controls.Add(this.grbInformation);
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 432);
            this.panel2.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel8.Location = new System.Drawing.Point(459, 9);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(3, 397);
            this.panel8.TabIndex = 43;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgrSubjectOfStudent);
            this.groupBox2.Location = new System.Drawing.Point(468, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 233);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List subject of student";
            // 
            // dgrSubjectOfStudent
            // 
            this.dgrSubjectOfStudent.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgrSubjectOfStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrSubjectOfStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDStudent,
            this.NameStudent,
            this.SubjectID,
            this.NameSubject,
            this.CreditsNumber,
            this.Semester1});
            this.dgrSubjectOfStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrSubjectOfStudent.Location = new System.Drawing.Point(3, 16);
            this.dgrSubjectOfStudent.Name = "dgrSubjectOfStudent";
            this.dgrSubjectOfStudent.Size = new System.Drawing.Size(391, 214);
            this.dgrSubjectOfStudent.TabIndex = 0;
            // 
            // IDStudent
            // 
            this.IDStudent.DataPropertyName = "IDStudent";
            this.IDStudent.HeaderText = "Student id";
            this.IDStudent.Name = "IDStudent";
            this.IDStudent.Width = 130;
            // 
            // NameStudent
            // 
            this.NameStudent.DataPropertyName = "NameStudent";
            this.NameStudent.HeaderText = "Student name";
            this.NameStudent.Name = "NameStudent";
            this.NameStudent.Width = 160;
            // 
            // SubjectID
            // 
            this.SubjectID.DataPropertyName = "IDSubject";
            this.SubjectID.HeaderText = "Subject id";
            this.SubjectID.Name = "SubjectID";
            // 
            // NameSubject
            // 
            this.NameSubject.DataPropertyName = "SubjectName";
            this.NameSubject.HeaderText = "Subject name";
            this.NameSubject.Name = "NameSubject";
            this.NameSubject.Width = 160;
            // 
            // CreditsNumber
            // 
            this.CreditsNumber.DataPropertyName = "NumberCredits";
            this.CreditsNumber.HeaderText = "Number credits";
            this.CreditsNumber.Name = "CreditsNumber";
            // 
            // Semester1
            // 
            this.Semester1.DataPropertyName = "Semester";
            this.Semester1.HeaderText = "Semester";
            this.Semester1.Name = "Semester1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Location = new System.Drawing.Point(468, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 149);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subject information of student";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel7.Controls.Add(this.cbbSubjectID);
            this.panel7.Controls.Add(this.cbbID);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.lblSubjectID);
            this.panel7.Controls.Add(this.lblID);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(391, 130);
            this.panel7.TabIndex = 6;
            // 
            // cbbSubjectID
            // 
            this.cbbSubjectID.FormattingEnabled = true;
            this.cbbSubjectID.Location = new System.Drawing.Point(111, 42);
            this.cbbSubjectID.Name = "cbbSubjectID";
            this.cbbSubjectID.Size = new System.Drawing.Size(167, 21);
            this.cbbSubjectID.TabIndex = 74;
            // 
            // cbbID
            // 
            this.cbbID.FormattingEnabled = true;
            this.cbbID.Location = new System.Drawing.Point(112, 14);
            this.cbbID.Name = "cbbID";
            this.cbbID.Size = new System.Drawing.Size(166, 21);
            this.cbbID.TabIndex = 73;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel6.Controls.Add(this.btnSave1);
            this.panel6.Controls.Add(this.btnDelete1);
            this.panel6.Location = new System.Drawing.Point(112, 76);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(203, 51);
            this.panel6.TabIndex = 7;
            // 
            // btnSave1
            // 
            this.btnSave1.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSave1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave1.Image = ((System.Drawing.Image)(resources.GetObject("btnSave1.Image")));
            this.btnSave1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave1.Location = new System.Drawing.Point(104, 7);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(95, 36);
            this.btnSave1.TabIndex = 16;
            this.btnSave1.Text = "  Save";
            this.btnSave1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave1.UseVisualStyleBackColor = false;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // btnDelete1
            // 
            this.btnDelete1.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDelete1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete1.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete1.Image")));
            this.btnDelete1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete1.Location = new System.Drawing.Point(4, 7);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(94, 36);
            this.btnDelete1.TabIndex = 15;
            this.btnDelete1.Text = " Delete";
            this.btnDelete1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete1.UseVisualStyleBackColor = false;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // lblSubjectID
            // 
            this.lblSubjectID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSubjectID.AutoSize = true;
            this.lblSubjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectID.Location = new System.Drawing.Point(37, 45);
            this.lblSubjectID.Name = "lblSubjectID";
            this.lblSubjectID.Size = new System.Drawing.Size(68, 13);
            this.lblSubjectID.TabIndex = 62;
            this.lblSubjectID.Text = "Subject id:";
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(37, 17);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(69, 13);
            this.lblID.TabIndex = 60;
            this.lblID.Text = "Student id:";
            // 
            // statusBar2
            // 
            this.statusBar2.Location = new System.Drawing.Point(0, 403);
            this.statusBar2.Name = "statusBar2";
            this.statusBar2.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.sttSManager,
            this.sttDate});
            this.statusBar2.ShowPanels = true;
            this.statusBar2.Size = new System.Drawing.Size(865, 29);
            this.statusBar2.TabIndex = 40;
            this.statusBar2.Text = "statusBar2";
            // 
            // sttSManager
            // 
            this.sttSManager.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.sttSManager.Name = "sttSManager";
            this.sttSManager.Text = "Student Manager";
            this.sttSManager.Width = 708;
            // 
            // sttDate
            // 
            this.sttDate.Name = "sttDate";
            this.sttDate.Text = "Date";
            this.sttDate.Width = 140;
            // 
            // grbStudent
            // 
            this.grbStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grbStudent.Controls.Add(this.dgrSubject);
            this.grbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbStudent.Location = new System.Drawing.Point(3, 207);
            this.grbStudent.Name = "grbStudent";
            this.grbStudent.Size = new System.Drawing.Size(450, 190);
            this.grbStudent.TabIndex = 39;
            this.grbStudent.TabStop = false;
            this.grbStudent.Text = "List Subject";
            // 
            // dgrSubject
            // 
            this.dgrSubject.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgrSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSubject,
            this.SubjectName,
            this.NumberCredits,
            this.Semester});
            this.dgrSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrSubject.Location = new System.Drawing.Point(3, 18);
            this.dgrSubject.Name = "dgrSubject";
            this.dgrSubject.Size = new System.Drawing.Size(444, 169);
            this.dgrSubject.TabIndex = 18;
            // 
            // IDSubject
            // 
            this.IDSubject.DataPropertyName = "IDSubject";
            this.IDSubject.HeaderText = "Subject id";
            this.IDSubject.MinimumWidth = 10;
            this.IDSubject.Name = "IDSubject";
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.HeaderText = "Subject name";
            this.SubjectName.MinimumWidth = 10;
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Width = 160;
            // 
            // NumberCredits
            // 
            this.NumberCredits.DataPropertyName = "NumberCredits";
            this.NumberCredits.HeaderText = "Number credits";
            this.NumberCredits.MinimumWidth = 10;
            this.NumberCredits.Name = "NumberCredits";
            // 
            // Semester
            // 
            this.Semester.DataPropertyName = "Semester";
            this.Semester.HeaderText = "Semester";
            this.Semester.Name = "Semester";
            // 
            // grbInformation
            // 
            this.grbInformation.Controls.Add(this.panel5);
            this.grbInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grbInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInformation.Location = new System.Drawing.Point(0, 9);
            this.grbInformation.Name = "grbInformation";
            this.grbInformation.Size = new System.Drawing.Size(453, 201);
            this.grbInformation.TabIndex = 38;
            this.grbInformation.TabStop = false;
            this.grbInformation.Text = "Subject Information";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.txtCredits);
            this.panel5.Controls.Add(this.txtIDSubject);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.lblCredits);
            this.panel5.Controls.Add(this.lblName);
            this.panel5.Controls.Add(this.txtSemester);
            this.panel5.Controls.Add(this.lblIDSubject);
            this.panel5.Controls.Add(this.txtName);
            this.panel5.Controls.Add(this.lblSemester);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(447, 180);
            this.panel5.TabIndex = 4;
            // 
            // txtCredits
            // 
            this.txtCredits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCredits.Location = new System.Drawing.Point(122, 66);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(254, 22);
            this.txtCredits.TabIndex = 6;
            // 
            // txtIDSubject
            // 
            this.txtIDSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDSubject.Location = new System.Drawing.Point(122, 10);
            this.txtIDSubject.Name = "txtIDSubject";
            this.txtIDSubject.Size = new System.Drawing.Size(254, 22);
            this.txtIDSubject.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Location = new System.Drawing.Point(31, 125);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(404, 52);
            this.panel4.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(204, 7);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 36);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = " Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(103, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 36);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "  Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Azure;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.Location = new System.Drawing.Point(305, 7);
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
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(3, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 36);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = " Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCredits
            // 
            this.lblCredits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.Location = new System.Drawing.Point(19, 71);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(96, 13);
            this.lblCredits.TabIndex = 73;
            this.lblCredits.Text = "Number credits:";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(28, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 13);
            this.lblName.TabIndex = 72;
            this.lblName.Text = "Subject name:";
            // 
            // txtSemester
            // 
            this.txtSemester.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSemester.Location = new System.Drawing.Point(122, 94);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(254, 22);
            this.txtSemester.TabIndex = 7;
            // 
            // lblIDSubject
            // 
            this.lblIDSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIDSubject.AutoSize = true;
            this.lblIDSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDSubject.Location = new System.Drawing.Point(48, 15);
            this.lblIDSubject.Name = "lblIDSubject";
            this.lblIDSubject.Size = new System.Drawing.Size(68, 13);
            this.lblIDSubject.TabIndex = 71;
            this.lblIDSubject.Text = "Subject id:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(122, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(254, 22);
            this.txtName.TabIndex = 5;
            // 
            // lblSemester
            // 
            this.lblSemester.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(48, 99);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(63, 13);
            this.lblSemester.TabIndex = 70;
            this.lblSemester.Text = "Semester:";
            // 
            // lblNameStudent
            // 
            this.lblNameStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameStudent.AutoSize = true;
            this.lblNameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameStudent.Location = new System.Drawing.Point(461, 10);
            this.lblNameStudent.Name = "lblNameStudent";
            this.lblNameStudent.Size = new System.Drawing.Size(76, 13);
            this.lblNameStudent.TabIndex = 72;
            this.lblNameStudent.Text = "Student name:";
            // 
            // cbbStudentName
            // 
            this.cbbStudentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbStudentName.FormattingEnabled = true;
            this.cbbStudentName.Location = new System.Drawing.Point(543, 6);
            this.cbbStudentName.Name = "cbbStudentName";
            this.cbbStudentName.Size = new System.Drawing.Size(155, 21);
            this.cbbStudentName.TabIndex = 12;
            this.cbbStudentName.SelectedIndexChanged += new System.EventHandler(this.cbbStudentName_SelectedIndexChanged);
            this.cbbStudentName.Click += new System.EventHandler(this.cbbStudentName_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.lblNameStudent);
            this.panel1.Controls.Add(this.lblSearchSemester);
            this.panel1.Controls.Add(this.cbbStudentName);
            this.panel1.Controls.Add(this.cbbSemester);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 48);
            this.panel1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightCyan;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(6, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 36);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = " Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // lblSearchSemester
            // 
            this.lblSearchSemester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchSemester.AutoSize = true;
            this.lblSearchSemester.Location = new System.Drawing.Point(316, 10);
            this.lblSearchSemester.Name = "lblSearchSemester";
            this.lblSearchSemester.Size = new System.Drawing.Size(54, 13);
            this.lblSearchSemester.TabIndex = 48;
            this.lblSearchSemester.Text = "Semester:";
            // 
            // cbbSemester
            // 
            this.cbbSemester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbSemester.FormattingEnabled = true;
            this.cbbSemester.Location = new System.Drawing.Point(376, 7);
            this.cbbSemester.Name = "cbbSemester";
            this.cbbSemester.Size = new System.Drawing.Size(74, 21);
            this.cbbSemester.TabIndex = 1;
            this.cbbSemester.SelectedIndexChanged += new System.EventHandler(this.cbbSemester_SelectedIndexChanged);
            this.cbbSemester.Click += new System.EventHandler(this.cbbSemester_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Location = new System.Drawing.Point(704, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 21);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(130, 13);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(865, 478);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSubject";
            this.Text = "Subject manager";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrSubjectOfStudent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sttSManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sttDate)).EndInit();
            this.grbStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrSubject)).EndInit();
            this.grbInformation.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusBar statusBar2;
        private System.Windows.Forms.StatusBarPanel sttSManager;
        private System.Windows.Forms.StatusBarPanel sttDate;
        private System.Windows.Forms.GroupBox grbStudent;
        private System.Windows.Forms.DataGridView dgrSubject;
        private System.Windows.Forms.GroupBox grbInformation;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbSemester;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSearchSemester;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrSubjectOfStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblNameStudent;
        private System.Windows.Forms.ComboBox cbbStudentName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.Label lblSubjectID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.TextBox txtIDSubject;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.Label lblIDSubject;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberCredits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.ComboBox cbbID;
        private System.Windows.Forms.ComboBox cbbSubjectID;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditsNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester1;
    }
}