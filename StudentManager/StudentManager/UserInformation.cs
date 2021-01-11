using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class frmUserInformation : Form
    {
        //
        SqlConnection conn = new SqlConnection("Data Source = VUON\\SQLEXPRESS;" +
            " User ID = sa; Password = 020299; Database = StudentDetails");
        public frmUserInformation()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmStudentManager std = new frmStudentManager();
            std.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
        //tạo một biến để lưu id của người dùng khi đã đăng nhập vào
        public string id;
        //hiển thị tên người dùng lên textbox
        public void NameUser()
        {
            txtName.Enabled = false;

            string sql = "select UserName from Login where IDUser = '"+ id +"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtName.Text = reader["UserName"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
        }
        //hiển thị số điện thoại người dùng lên textbox
        public void Phone()
        {
            txtPhone.Enabled = false;

            string sql = "select PhoneNumber from Login where IDUser = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtPhone.Text = reader["PhoneNumber"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
        }
        //hiển thị giới tính của người dùng ra textbox
        public void Gender()
        {
            txtGender.Enabled = false;

            string sql = "select Gender from Login where IDUser = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtGender.Text = reader["Gender"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
        }
        //hiển thị email của người dùng lên textbox
        public void Email()
        {
            txtEmail.Enabled = false;

            string sql = "select Email from Login where IDUser = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtEmail.Text = reader["Email"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
        }
        //hiển thị quyền của người sử dụng lên textbox
        public void Decentralization()
        {
            txtDecentralization.Enabled = false;

            string sql = "select Decentralization from Login where IDUser = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtDecentralization.Text = reader["Decentralization"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
        }
        //hiển thị tài khoản của người dùng lên textbox
        public void Account()
        {
            txtAccount.Enabled = false;

            string sql = "select Account from Login where IDUser = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtAccount.Text = reader["Account"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
        }
        //hiển thị mật khẩu của người dùng lên textbox
        public void Password()
        {
            txtPass.Enabled = false;

            string sql = "select Password from Login where IDUser = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtPass.Text = reader["Password"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
        }

        private void frmUserInformation_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("--> Enable to connect <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            id = Information.ID;
            NameUser();
            Phone();
            Gender();
            Email();
            Decentralization();
            Account();
            Password();
            conn.Close();
        }

        private void llblEditName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtName.Enabled = true;
        }

        private void llblEditPhone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPhone.Enabled = true;
        }

        private void llblEditGender_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtGender.Enabled = true;
        }

        private void llblEditEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtEmail.Enabled = true;
        }

        private void llblEditPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPass.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string gender = txtGender.Text;
            string email = txtEmail.Text;
            string decentralization = txtDecentralization.Text;
            string acc = txtAccount.Text;
            string pass = txtPass.Text;
            //tạo câu lệnh sql để update cho cột UserName
            string sqlname = "UPDATE Login Set UserName = N'" + name + "' Where IDUser = '" + id + "'";
            //
            string sqlphone = "UPDATE Login Set PhoneNumber = '" + phone + "' Where IDUser = '" + id + "'";
            string sqlgender = "UPDATE Login Set Gender = '" + gender + "' Where IDUser = '" + id + "'";
            string sqlemail = "UPDATE Login Set Email = '" + email + "' Where IDUser = '" + id + "'";
            string sqldecentralization = "UPDATE Login Set Decentralization = '" + decentralization + "' Where IDUser = '" + id + "'";
            string sqlacc = "UPDATE Login Set Account = '" + acc + "' Where IDUser = '" + id + "'";
            string sqlpass = "UPDATE Login Set Password = '" + pass + "' Where IDUser = '" + id + "'";
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("--> Enable to connect <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlCommand cmdname = new SqlCommand(sqlname, conn);
            SqlCommand cmdphone = new SqlCommand(sqlphone, conn);
            SqlCommand cmdgender = new SqlCommand(sqlgender, conn);
            SqlCommand cmdemail = new SqlCommand(sqlemail, conn);
            SqlCommand cmddecentralization = new SqlCommand(sqldecentralization, conn);
            SqlCommand cmdacc = new SqlCommand(sqlacc, conn);
            SqlCommand cmdpass = new SqlCommand(sqlpass, conn);
            try
            {
                //nếu textbox đã mở thì cho thực hiện update
                if (txtName.Enabled == true)
                {
                    cmdname.ExecuteNonQuery();
                    MessageBox.Show("--> Updated successfully <--", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NameUser();
                }
                if (txtPhone.Enabled == true)
                {
                    cmdphone.ExecuteNonQuery();
                    MessageBox.Show("--> Updated successfully <--", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Phone();
                }
                if (txtGender.Enabled == true)
                {
                    cmdgender.ExecuteNonQuery();
                    MessageBox.Show("--> Updated successfully <--", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Gender();
                }
                if (txtEmail.Enabled == true)
                {
                    cmdemail.ExecuteNonQuery();
                    MessageBox.Show("--> Updated successfully <--", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Email();
                }
                if (txtDecentralization.Enabled == true)
                {
                    cmddecentralization.ExecuteNonQuery();
                    MessageBox.Show("--> Updated successfully <--", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Decentralization();
                }              
                if (txtPass.Enabled == true)
                {
                    if(txtPass.Text != "")
                    {
                        cmdpass.ExecuteNonQuery();
                        MessageBox.Show("--> Updated successfully <--", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Password();
                    }
                    else
                    {
                        MessageBox.Show("--> Please enter password <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("--> Not update <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        private void txtPhone_Click(object sender, EventArgs e)
        {
            txtPhone.Text = "";
        }

        private void txtGender_Click(object sender, EventArgs e)
        {
            txtGender.Text = "";
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
        }

        private void txtAccount_Click(object sender, EventArgs e)
        {
            txtAccount.Text = "";
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
        }

        private void llblEditDecentralization_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtDecentralization.Enabled = true;
        }

        private void txtDecentralization_Click(object sender, EventArgs e)
        {
            txtDecentralization.Text = "";
        }
    }
}
