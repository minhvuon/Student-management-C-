namespace StudentManager
{
    partial class frmUserInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserInformation));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblInformation = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDecentralization = new System.Windows.Forms.Label();
            this.llblEditDecentralization = new System.Windows.Forms.LinkLabel();
            this.txtDecentralization = new System.Windows.Forms.TextBox();
            this.llblEditPass = new System.Windows.Forms.LinkLabel();
            this.llblEditEmail = new System.Windows.Forms.LinkLabel();
            this.llblEditGender = new System.Windows.Forms.LinkLabel();
            this.llblEditPhone = new System.Windows.Forms.LinkLabel();
            this.llblEditName = new System.Windows.Forms.LinkLabel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 326);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 65);
            this.panel2.TabIndex = 11;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.Location = new System.Drawing.Point(159, 9);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 39);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Text = " Log out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(60, 9);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 39);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = " Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.lblInformation);
            this.panel4.Controls.Add(this.btnBack);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(284, 99);
            this.panel4.TabIndex = 12;
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblInformation.Location = new System.Drawing.Point(71, 68);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(144, 20);
            this.lblInformation.TabIndex = 8;
            this.lblInformation.Text = "Information User";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(27, 27);
            this.btnBack.TabIndex = 17;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.lblDecentralization);
            this.panel3.Controls.Add(this.llblEditDecentralization);
            this.panel3.Controls.Add(this.txtDecentralization);
            this.panel3.Controls.Add(this.llblEditPass);
            this.panel3.Controls.Add(this.llblEditEmail);
            this.panel3.Controls.Add(this.llblEditGender);
            this.panel3.Controls.Add(this.llblEditPhone);
            this.panel3.Controls.Add(this.llblEditName);
            this.panel3.Controls.Add(this.txtPass);
            this.panel3.Controls.Add(this.txtAccount);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.txtGender);
            this.panel3.Controls.Add(this.txtPhone);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.lblPass);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Controls.Add(this.lblEmail);
            this.panel3.Controls.Add(this.lblGender);
            this.panel3.Controls.Add(this.lblPhone);
            this.panel3.Controls.Add(this.lblUserName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 230);
            this.panel3.TabIndex = 13;
            // 
            // lblDecentralization
            // 
            this.lblDecentralization.AutoSize = true;
            this.lblDecentralization.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecentralization.Location = new System.Drawing.Point(3, 147);
            this.lblDecentralization.Name = "lblDecentralization";
            this.lblDecentralization.Size = new System.Drawing.Size(103, 13);
            this.lblDecentralization.TabIndex = 23;
            this.lblDecentralization.Text = "Decentralization:";
            // 
            // llblEditDecentralization
            // 
            this.llblEditDecentralization.AutoSize = true;
            this.llblEditDecentralization.Location = new System.Drawing.Point(252, 151);
            this.llblEditDecentralization.Name = "llblEditDecentralization";
            this.llblEditDecentralization.Size = new System.Drawing.Size(25, 13);
            this.llblEditDecentralization.TabIndex = 12;
            this.llblEditDecentralization.TabStop = true;
            this.llblEditDecentralization.Text = "Edit";
            this.llblEditDecentralization.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblEditDecentralization_LinkClicked);
            // 
            // txtDecentralization
            // 
            this.txtDecentralization.Location = new System.Drawing.Point(106, 144);
            this.txtDecentralization.Name = "txtDecentralization";
            this.txtDecentralization.Size = new System.Drawing.Size(138, 20);
            this.txtDecentralization.TabIndex = 5;
            this.txtDecentralization.Click += new System.EventHandler(this.txtDecentralization_Click);
            // 
            // llblEditPass
            // 
            this.llblEditPass.AutoSize = true;
            this.llblEditPass.Location = new System.Drawing.Point(252, 203);
            this.llblEditPass.Name = "llblEditPass";
            this.llblEditPass.Size = new System.Drawing.Size(25, 13);
            this.llblEditPass.TabIndex = 14;
            this.llblEditPass.TabStop = true;
            this.llblEditPass.Text = "Edit";
            this.llblEditPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblEditPass_LinkClicked);
            // 
            // llblEditEmail
            // 
            this.llblEditEmail.AutoSize = true;
            this.llblEditEmail.Location = new System.Drawing.Point(252, 125);
            this.llblEditEmail.Name = "llblEditEmail";
            this.llblEditEmail.Size = new System.Drawing.Size(25, 13);
            this.llblEditEmail.TabIndex = 11;
            this.llblEditEmail.TabStop = true;
            this.llblEditEmail.Text = "Edit";
            this.llblEditEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblEditEmail_LinkClicked);
            // 
            // llblEditGender
            // 
            this.llblEditGender.AutoSize = true;
            this.llblEditGender.Location = new System.Drawing.Point(252, 76);
            this.llblEditGender.Name = "llblEditGender";
            this.llblEditGender.Size = new System.Drawing.Size(25, 13);
            this.llblEditGender.TabIndex = 10;
            this.llblEditGender.TabStop = true;
            this.llblEditGender.Text = "Edit";
            this.llblEditGender.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblEditGender_LinkClicked);
            // 
            // llblEditPhone
            // 
            this.llblEditPhone.AutoSize = true;
            this.llblEditPhone.Location = new System.Drawing.Point(252, 50);
            this.llblEditPhone.Name = "llblEditPhone";
            this.llblEditPhone.Size = new System.Drawing.Size(25, 13);
            this.llblEditPhone.TabIndex = 9;
            this.llblEditPhone.TabStop = true;
            this.llblEditPhone.Text = "Edit";
            this.llblEditPhone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblEditPhone_LinkClicked);
            // 
            // llblEditName
            // 
            this.llblEditName.AutoSize = true;
            this.llblEditName.Location = new System.Drawing.Point(252, 24);
            this.llblEditName.Name = "llblEditName";
            this.llblEditName.Size = new System.Drawing.Size(25, 13);
            this.llblEditName.TabIndex = 8;
            this.llblEditName.TabStop = true;
            this.llblEditName.Text = "Edit";
            this.llblEditName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblEditName_LinkClicked);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(106, 196);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(138, 20);
            this.txtPass.TabIndex = 7;
            this.txtPass.Click += new System.EventHandler(this.txtPass_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(106, 170);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(138, 20);
            this.txtAccount.TabIndex = 6;
            this.txtAccount.Click += new System.EventHandler(this.txtAccount_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 95);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(138, 43);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(106, 69);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(138, 20);
            this.txtGender.TabIndex = 3;
            this.txtGender.Click += new System.EventHandler(this.txtGender_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(106, 43);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(138, 20);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.Click += new System.EventHandler(this.txtPhone_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(11, 199);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(65, 13);
            this.lblPass.TabIndex = 6;
            this.lblPass.Text = "Password:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(11, 98);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(11, 72);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 13);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(11, 46);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(92, 13);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone number:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(11, 173);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(73, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name:";
            // 
            // frmUserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 391);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Information";
            this.Load += new System.EventHandler(this.frmUserInformation_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel llblEditPass;
        private System.Windows.Forms.LinkLabel llblEditEmail;
        private System.Windows.Forms.LinkLabel llblEditGender;
        private System.Windows.Forms.LinkLabel llblEditPhone;
        private System.Windows.Forms.LinkLabel llblEditName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblDecentralization;
        private System.Windows.Forms.LinkLabel llblEditDecentralization;
        private System.Windows.Forms.TextBox txtDecentralization;
    }
}