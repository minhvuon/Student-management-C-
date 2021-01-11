namespace StudentManager
{
    partial class frmNewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewAccount));
            this.grbInformationUser = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grbGender = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grbAccountInformatiuon = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbbDecentralization = new System.Windows.Forms.ComboBox();
            this.lblDecentralization = new System.Windows.Forms.Label();
            this.txtRPass = new System.Windows.Forms.TextBox();
            this.lblRTpass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lblNPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbInformationUser.SuspendLayout();
            this.grbGender.SuspendLayout();
            this.grbAccountInformatiuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInformationUser
            // 
            this.grbInformationUser.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grbInformationUser.Controls.Add(this.txtEmail);
            this.grbInformationUser.Controls.Add(this.grbGender);
            this.grbInformationUser.Controls.Add(this.lblEmail);
            this.grbInformationUser.Controls.Add(this.lblPhone);
            this.grbInformationUser.Controls.Add(this.lblName);
            this.grbInformationUser.Controls.Add(this.txtPhone);
            this.grbInformationUser.Controls.Add(this.txtName);
            this.grbInformationUser.Location = new System.Drawing.Point(2, 90);
            this.grbInformationUser.Name = "grbInformationUser";
            this.grbInformationUser.Size = new System.Drawing.Size(304, 151);
            this.grbInformationUser.TabIndex = 1;
            this.grbInformationUser.TabStop = false;
            this.grbInformationUser.Text = "User information";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(104, 77);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // grbGender
            // 
            this.grbGender.Controls.Add(this.rdoFemale);
            this.grbGender.Controls.Add(this.rdoMale);
            this.grbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGender.Location = new System.Drawing.Point(55, 104);
            this.grbGender.Name = "grbGender";
            this.grbGender.Size = new System.Drawing.Size(228, 41);
            this.grbGender.TabIndex = 5;
            this.grbGender.TabStop = false;
            this.grbGender.Text = "Gender";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemale.Location = new System.Drawing.Point(138, 18);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoFemale.TabIndex = 7;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            this.rdoFemale.CheckedChanged += new System.EventHandler(this.rdoFemale_CheckedChanged);
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.Location = new System.Drawing.Point(54, 18);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 17);
            this.rdoMale.TabIndex = 6;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            this.rdoMale.CheckedChanged += new System.EventHandler(this.rdoMale_CheckedChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(1, 84);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(1, 55);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(92, 13);
            this.lblPhone.TabIndex = 32;
            this.lblPhone.Text = "Phone number:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblName.Location = new System.Drawing.Point(1, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 13);
            this.lblName.TabIndex = 31;
            this.lblName.Text = "Name: ";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(104, 48);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(179, 20);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.Click += new System.EventHandler(this.txtPhone_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 20);
            this.txtName.TabIndex = 2;
            this.txtName.Click += new System.EventHandler(this.txtUserName_Click);
            // 
            // grbAccountInformatiuon
            // 
            this.grbAccountInformatiuon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grbAccountInformatiuon.Controls.Add(this.pictureBox3);
            this.grbAccountInformatiuon.Controls.Add(this.pictureBox2);
            this.grbAccountInformatiuon.Controls.Add(this.cbbDecentralization);
            this.grbAccountInformatiuon.Controls.Add(this.lblDecentralization);
            this.grbAccountInformatiuon.Controls.Add(this.txtRPass);
            this.grbAccountInformatiuon.Controls.Add(this.lblRTpass);
            this.grbAccountInformatiuon.Controls.Add(this.txtPass);
            this.grbAccountInformatiuon.Controls.Add(this.txtAccount);
            this.grbAccountInformatiuon.Controls.Add(this.lblNPassword);
            this.grbAccountInformatiuon.Controls.Add(this.lblUserName);
            this.grbAccountInformatiuon.Location = new System.Drawing.Point(2, 247);
            this.grbAccountInformatiuon.Name = "grbAccountInformatiuon";
            this.grbAccountInformatiuon.Size = new System.Drawing.Size(304, 140);
            this.grbAccountInformatiuon.TabIndex = 8;
            this.grbAccountInformatiuon.TabStop = false;
            this.grbAccountInformatiuon.Text = "Account information";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(259, 109);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(259, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cbbDecentralization
            // 
            this.cbbDecentralization.FormattingEnabled = true;
            this.cbbDecentralization.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cbbDecentralization.Location = new System.Drawing.Point(124, 18);
            this.cbbDecentralization.Name = "cbbDecentralization";
            this.cbbDecentralization.Size = new System.Drawing.Size(108, 21);
            this.cbbDecentralization.TabIndex = 9;
            // 
            // lblDecentralization
            // 
            this.lblDecentralization.AutoSize = true;
            this.lblDecentralization.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecentralization.Location = new System.Drawing.Point(10, 26);
            this.lblDecentralization.Name = "lblDecentralization";
            this.lblDecentralization.Size = new System.Drawing.Size(103, 13);
            this.lblDecentralization.TabIndex = 23;
            this.lblDecentralization.Text = "Decentralization:";
            // 
            // txtRPass
            // 
            this.txtRPass.Location = new System.Drawing.Point(124, 107);
            this.txtRPass.Name = "txtRPass";
            this.txtRPass.Size = new System.Drawing.Size(159, 20);
            this.txtRPass.TabIndex = 12;
            this.txtRPass.UseSystemPasswordChar = true;
            this.txtRPass.Click += new System.EventHandler(this.txtRPass_Click);
            // 
            // lblRTpass
            // 
            this.lblRTpass.AutoSize = true;
            this.lblRTpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRTpass.Location = new System.Drawing.Point(10, 114);
            this.lblRTpass.Name = "lblRTpass";
            this.lblRTpass.Size = new System.Drawing.Size(108, 13);
            this.lblRTpass.TabIndex = 22;
            this.lblRTpass.Text = "Retype password:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(124, 77);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(159, 20);
            this.txtPass.TabIndex = 11;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.Click += new System.EventHandler(this.txtPass_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(124, 48);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(159, 20);
            this.txtAccount.TabIndex = 10;
            this.txtAccount.Click += new System.EventHandler(this.txtAccount_Click);
            // 
            // lblNPassword
            // 
            this.lblNPassword.AutoSize = true;
            this.lblNPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNPassword.Location = new System.Drawing.Point(10, 84);
            this.lblNPassword.Name = "lblNPassword";
            this.lblNPassword.Size = new System.Drawing.Size(65, 13);
            this.lblNPassword.TabIndex = 21;
            this.lblNPassword.Text = "Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(10, 55);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(71, 13);
            this.lblUserName.TabIndex = 20;
            this.lblUserName.Text = "User name:";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignUp.Location = new System.Drawing.Point(32, 404);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(244, 35);
            this.btnSignUp.TabIndex = 13;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(2, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(27, 27);
            this.btnBack.TabIndex = 14;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAccount.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblCreateAccount.Location = new System.Drawing.Point(65, 67);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(184, 20);
            this.lblCreateAccount.TabIndex = 37;
            this.lblCreateAccount.Text = "Create a new account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // frmNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(308, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCreateAccount);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.grbAccountInformatiuon);
            this.Controls.Add(this.grbInformationUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Account";
            this.grbInformationUser.ResumeLayout(false);
            this.grbInformationUser.PerformLayout();
            this.grbGender.ResumeLayout(false);
            this.grbGender.PerformLayout();
            this.grbAccountInformatiuon.ResumeLayout(false);
            this.grbAccountInformatiuon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInformationUser;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox grbGender;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grbAccountInformatiuon;
        private System.Windows.Forms.TextBox txtRPass;
        private System.Windows.Forms.Label lblRTpass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lblNPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCreateAccount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbbDecentralization;
        private System.Windows.Forms.Label lblDecentralization;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}