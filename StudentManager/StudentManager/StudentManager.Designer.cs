namespace StudentManager
{
    partial class frmStudentManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentManager));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoresManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewScorestoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.userManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.txtNameUser = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnViewScores = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnScoresManagement = new System.Windows.Forms.Button();
            this.btnStudentManager = new System.Windows.Forms.Button();
            this.btnSubjectManager = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Location = new System.Drawing.Point(131, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(873, 453);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationUserToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // informationUserToolStripMenuItem
            // 
            this.informationUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("informationUserToolStripMenuItem.Image")));
            this.informationUserToolStripMenuItem.Name = "informationUserToolStripMenuItem";
            this.informationUserToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.informationUserToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.informationUserToolStripMenuItem.Text = "Information user";
            this.informationUserToolStripMenuItem.Click += new System.EventHandler(this.informationUserToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.mnItemExit_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentManagementToolStripMenuItem,
            this.subjectManagementToolStripMenuItem,
            this.scoresManagementToolStripMenuItem,
            this.ViewScorestoolStripMenuItem1,
            this.toolStripSeparator2,
            this.userManagerToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // studentManagementToolStripMenuItem
            // 
            this.studentManagementToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentManagementToolStripMenuItem.Image")));
            this.studentManagementToolStripMenuItem.Name = "studentManagementToolStripMenuItem";
            this.studentManagementToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.studentManagementToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.studentManagementToolStripMenuItem.Text = "Student management";
            this.studentManagementToolStripMenuItem.Click += new System.EventHandler(this.btnStudentManager_Click);
            // 
            // subjectManagementToolStripMenuItem
            // 
            this.subjectManagementToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("subjectManagementToolStripMenuItem.Image")));
            this.subjectManagementToolStripMenuItem.Name = "subjectManagementToolStripMenuItem";
            this.subjectManagementToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.subjectManagementToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.subjectManagementToolStripMenuItem.Text = "Subject management";
            this.subjectManagementToolStripMenuItem.Click += new System.EventHandler(this.btnSubjectManager_Click);
            // 
            // scoresManagementToolStripMenuItem
            // 
            this.scoresManagementToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("scoresManagementToolStripMenuItem.Image")));
            this.scoresManagementToolStripMenuItem.Name = "scoresManagementToolStripMenuItem";
            this.scoresManagementToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.scoresManagementToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.scoresManagementToolStripMenuItem.Text = "Scores management";
            this.scoresManagementToolStripMenuItem.Click += new System.EventHandler(this.btnScoresManagement_Click);
            // 
            // ViewScorestoolStripMenuItem1
            // 
            this.ViewScorestoolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ViewScorestoolStripMenuItem1.Image")));
            this.ViewScorestoolStripMenuItem1.Name = "ViewScorestoolStripMenuItem1";
            this.ViewScorestoolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ViewScorestoolStripMenuItem1.Size = new System.Drawing.Size(232, 22);
            this.ViewScorestoolStripMenuItem1.Text = "View Scores";
            this.ViewScorestoolStripMenuItem1.Click += new System.EventHandler(this.btnViewScores_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(229, 6);
            // 
            // userManagerToolStripMenuItem
            // 
            this.userManagerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userManagerToolStripMenuItem.Image")));
            this.userManagerToolStripMenuItem.Name = "userManagerToolStripMenuItem";
            this.userManagerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.userManagerToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.userManagerToolStripMenuItem.Text = "User manager";
            this.userManagerToolStripMenuItem.Click += new System.EventHandler(this.userManagerToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.txtNameUser);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 24);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(377, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "STUDENT MANAGEMENT APPLICATION";
            // 
            // btnUser
            // 
            this.btnUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.Location = new System.Drawing.Point(974, 3);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(27, 19);
            this.btnUser.TabIndex = 6;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.informationUserToolStripMenuItem_Click);
            // 
            // txtNameUser
            // 
            this.txtNameUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameUser.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNameUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNameUser.Location = new System.Drawing.Point(807, 6);
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.ReadOnly = true;
            this.txtNameUser.Size = new System.Drawing.Size(161, 13);
            this.txtNameUser.TabIndex = 2;
            this.txtNameUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnViewScores);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnScoresManagement);
            this.panel2.Controls.Add(this.btnStudentManager);
            this.panel2.Controls.Add(this.btnSubjectManager);
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 453);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 42);
            this.panel3.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "--> ACTIONS <--";
            // 
            // btnViewScores
            // 
            this.btnViewScores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewScores.Image = ((System.Drawing.Image)(resources.GetObject("btnViewScores.Image")));
            this.btnViewScores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewScores.Location = new System.Drawing.Point(0, 236);
            this.btnViewScores.Name = "btnViewScores";
            this.btnViewScores.Size = new System.Drawing.Size(125, 58);
            this.btnViewScores.TabIndex = 4;
            this.btnViewScores.Text = "View Scores";
            this.btnViewScores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewScores.UseVisualStyleBackColor = true;
            this.btnViewScores.Click += new System.EventHandler(this.btnViewScores_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(0, 300);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 58);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnScoresManagement
            // 
            this.btnScoresManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScoresManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScoresManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnScoresManagement.Image")));
            this.btnScoresManagement.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnScoresManagement.Location = new System.Drawing.Point(0, 172);
            this.btnScoresManagement.Name = "btnScoresManagement";
            this.btnScoresManagement.Size = new System.Drawing.Size(125, 58);
            this.btnScoresManagement.TabIndex = 3;
            this.btnScoresManagement.Text = "Scores management";
            this.btnScoresManagement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnScoresManagement.UseVisualStyleBackColor = true;
            this.btnScoresManagement.Click += new System.EventHandler(this.btnScoresManagement_Click);
            // 
            // btnStudentManager
            // 
            this.btnStudentManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentManager.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentManager.Image")));
            this.btnStudentManager.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStudentManager.Location = new System.Drawing.Point(0, 44);
            this.btnStudentManager.Name = "btnStudentManager";
            this.btnStudentManager.Size = new System.Drawing.Size(125, 58);
            this.btnStudentManager.TabIndex = 1;
            this.btnStudentManager.Text = "Student management";
            this.btnStudentManager.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStudentManager.UseVisualStyleBackColor = true;
            this.btnStudentManager.Click += new System.EventHandler(this.btnStudentManager_Click);
            // 
            // btnSubjectManager
            // 
            this.btnSubjectManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubjectManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjectManager.Image = ((System.Drawing.Image)(resources.GetObject("btnSubjectManager.Image")));
            this.btnSubjectManager.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSubjectManager.Location = new System.Drawing.Point(0, 108);
            this.btnSubjectManager.Name = "btnSubjectManager";
            this.btnSubjectManager.Size = new System.Drawing.Size(125, 58);
            this.btnSubjectManager.TabIndex = 2;
            this.btnSubjectManager.Text = "Subject manager";
            this.btnSubjectManager.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSubjectManager.UseVisualStyleBackColor = true;
            this.btnSubjectManager.Click += new System.EventHandler(this.btnSubjectManager_Click);
            // 
            // frmStudentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1004, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmStudentManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Manager";
            this.Load += new System.EventHandler(this.frmStudentManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem informationUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoresManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNameUser;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.ToolStripMenuItem ViewScorestoolStripMenuItem1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViewScores;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnScoresManagement;
        private System.Windows.Forms.Button btnStudentManager;
        private System.Windows.Forms.Button btnSubjectManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}

