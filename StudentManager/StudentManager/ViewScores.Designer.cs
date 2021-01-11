namespace StudentManager
{
    partial class frmViewScores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewScores));
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusBar2 = new System.Windows.Forms.StatusBar();
            this.sttSManager = new System.Windows.Forms.StatusBarPanel();
            this.sttDate = new System.Windows.Forms.StatusBarPanel();
            this.grbList = new System.Windows.Forms.GroupBox();
            this.dgrViewScores = new System.Windows.Forms.DataGridView();
            this.clClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiligenceScores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MidternScores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndtermScores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectMediumScores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbClass = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchClass = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbbSemester = new System.Windows.Forms.ComboBox();
            this.lblSearchSemester = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sttSManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sttDate)).BeginInit();
            this.grbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrViewScores)).BeginInit();
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
            this.panel2.Controls.Add(this.statusBar2);
            this.panel2.Controls.Add(this.grbList);
            this.panel2.Location = new System.Drawing.Point(1, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 405);
            this.panel2.TabIndex = 50;
            // 
            // statusBar2
            // 
            this.statusBar2.Location = new System.Drawing.Point(0, 383);
            this.statusBar2.Name = "statusBar2";
            this.statusBar2.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.sttSManager,
            this.sttDate});
            this.statusBar2.ShowPanels = true;
            this.statusBar2.Size = new System.Drawing.Size(835, 22);
            this.statusBar2.TabIndex = 40;
            this.statusBar2.Text = "statusBar2";
            // 
            // sttSManager
            // 
            this.sttSManager.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.sttSManager.Name = "sttSManager";
            this.sttSManager.Text = "Student Manager";
            this.sttSManager.Width = 678;
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
            this.grbList.Controls.Add(this.dgrViewScores);
            this.grbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbList.Location = new System.Drawing.Point(0, 0);
            this.grbList.Name = "grbList";
            this.grbList.Size = new System.Drawing.Size(835, 377);
            this.grbList.TabIndex = 39;
            this.grbList.TabStop = false;
            this.grbList.Text = "List scores";
            // 
            // dgrViewScores
            // 
            this.dgrViewScores.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgrViewScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrViewScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clClass,
            this.StudentID,
            this.clName,
            this.SubjectName,
            this.DiligenceScores,
            this.MidternScores,
            this.EndtermScores,
            this.SubjectMediumScores});
            this.dgrViewScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrViewScores.Location = new System.Drawing.Point(3, 18);
            this.dgrViewScores.Name = "dgrViewScores";
            this.dgrViewScores.Size = new System.Drawing.Size(829, 356);
            this.dgrViewScores.TabIndex = 18;
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
            this.StudentID.Width = 150;
            // 
            // clName
            // 
            this.clName.DataPropertyName = "NameStudent";
            this.clName.HeaderText = "Student name";
            this.clName.MinimumWidth = 10;
            this.clName.Name = "clName";
            this.clName.Width = 190;
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.HeaderText = "Subject name";
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Width = 200;
            // 
            // DiligenceScores
            // 
            this.DiligenceScores.DataPropertyName = "DiligenceScores";
            this.DiligenceScores.HeaderText = "Diligence scores";
            this.DiligenceScores.MinimumWidth = 10;
            this.DiligenceScores.Name = "DiligenceScores";
            this.DiligenceScores.Width = 140;
            // 
            // MidternScores
            // 
            this.MidternScores.DataPropertyName = "MidtermScores";
            this.MidternScores.HeaderText = "Midtern scores";
            this.MidternScores.MinimumWidth = 10;
            this.MidternScores.Name = "MidternScores";
            this.MidternScores.Width = 140;
            // 
            // EndtermScores
            // 
            this.EndtermScores.DataPropertyName = "EndtermScores";
            this.EndtermScores.HeaderText = "Endterm scores";
            this.EndtermScores.Name = "EndtermScores";
            this.EndtermScores.Width = 140;
            // 
            // SubjectMediumScores
            // 
            this.SubjectMediumScores.DataPropertyName = "SubjectMediumScores";
            this.SubjectMediumScores.HeaderText = "Subject medium scores";
            this.SubjectMediumScores.Name = "SubjectMediumScores";
            this.SubjectMediumScores.Width = 150;
            // 
            // cbbClass
            // 
            this.cbbClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.Items.AddRange(new object[] {
            "CNTT K40a",
            "CNTT K40b",
            "CNTT K40c"});
            this.cbbClass.Location = new System.Drawing.Point(573, 7);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(96, 21);
            this.cbbClass.TabIndex = 51;
            this.cbbClass.SelectedIndexChanged += new System.EventHandler(this.cbbClass_SelectedIndexChanged);
            this.cbbClass.Click += new System.EventHandler(this.cbbClass_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.PowderBlue;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(4, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 36);
            this.btnRefresh.TabIndex = 52;
            this.btnRefresh.Text = " Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Location = new System.Drawing.Point(675, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 21);
            this.panel3.TabIndex = 53;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(136, 0);
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
            this.txtSearch.Size = new System.Drawing.Size(133, 13);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearchClass
            // 
            this.lblSearchClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchClass.AutoSize = true;
            this.lblSearchClass.Location = new System.Drawing.Point(532, 10);
            this.lblSearchClass.Name = "lblSearchClass";
            this.lblSearchClass.Size = new System.Drawing.Size(35, 13);
            this.lblSearchClass.TabIndex = 54;
            this.lblSearchClass.Text = "Class:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbbSemester
            // 
            this.cbbSemester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbSemester.FormattingEnabled = true;
            this.cbbSemester.Location = new System.Drawing.Point(443, 7);
            this.cbbSemester.Name = "cbbSemester";
            this.cbbSemester.Size = new System.Drawing.Size(74, 21);
            this.cbbSemester.TabIndex = 55;
            this.cbbSemester.SelectedIndexChanged += new System.EventHandler(this.cbbSemester_SelectedIndexChanged);
            this.cbbSemester.Click += new System.EventHandler(this.cbbSemester_Click);
            // 
            // lblSearchSemester
            // 
            this.lblSearchSemester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchSemester.AutoSize = true;
            this.lblSearchSemester.Location = new System.Drawing.Point(383, 10);
            this.lblSearchSemester.Name = "lblSearchSemester";
            this.lblSearchSemester.Size = new System.Drawing.Size(54, 13);
            this.lblSearchSemester.TabIndex = 56;
            this.lblSearchSemester.Text = "Semester:";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(105, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 36);
            this.btnPrint.TabIndex = 57;
            this.btnPrint.Text = " Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmViewScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblSearchSemester);
            this.Controls.Add(this.cbbSemester);
            this.Controls.Add(this.lblSearchClass);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbbClass);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewScores";
            this.Text = "ViewScores";
            this.Load += new System.EventHandler(this.frmViewScores_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sttSManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sttDate)).EndInit();
            this.grbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrViewScores)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusBar statusBar2;
        private System.Windows.Forms.StatusBarPanel sttSManager;
        private System.Windows.Forms.StatusBarPanel sttDate;
        private System.Windows.Forms.GroupBox grbList;
        private System.Windows.Forms.DataGridView dgrViewScores;
        private System.Windows.Forms.ComboBox cbbClass;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn clClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiligenceScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn MidternScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndtermScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectMediumScores;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbbSemester;
        private System.Windows.Forms.Label lblSearchSemester;
        private System.Windows.Forms.Button btnPrint;
    }
}