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
    public partial class frmUser : Form
    {
        //
        SqlConnection conn = new SqlConnection("Data Source = VUON\\SQLEXPRESS; User ID = sa; Password = 020299; Database = StudentDetails");
        public frmUser()
        {
            InitializeComponent();
        }
        //phương thức hiển thị dữ liệu lên DataGridView
        private void hienThi()
        {
            string sqlSelect = "select Account, Password, UserName, Email, PhoneNumber, Gender, Decentralization from Login";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dar = cmd.ExecuteReader();
            DataTable dat = new DataTable();
            dat.Load(dar);
            dgrUser.DataSource = dat;
        }
        //phương thức lấy tên tài khoản từ cơ sở dữ liệu khi truyền vào tên
        private string getName(string name)
        {
            string NAME = "";
            string sqlid = "SELECT * FROM Login WHERE Account = '" + name + "'";
            SqlCommand cmdid = new SqlCommand(sqlid, conn);
            SqlDataAdapter daA = new SqlDataAdapter(cmdid);
            DataTable dat = new DataTable();
            daA.Fill(dat);
            if (dat != null)
            {
                foreach (DataRow daR in dat.Rows)
                {
                    NAME = daR["Account"].ToString();
                }
            }
            return NAME;
        }
        //tạo một biến để lưu tên tài khoản
        public string NameUser;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text;
            string sql1 = "delete from Login where Account = '" + name + "'";
            SqlCommand cmd1 = new SqlCommand(sql1, conn);

            conn.Open();
            if (name != "")
            {
                //lấy tên người dùng, nếu khác rỗng là đã có, cho phép thực hiện
                NameUser = getName(name);
                if (NameUser != "")
                {
                    try
                    {
                        cmd1.ExecuteNonQuery();
                        statusBar2.Panels[0].Text = "Deleted successfully";
                        hienThi();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("--> Delete failed <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("--> ID invalid <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("--> Please enter ID <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
            btnClear.Enabled = true;
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            btnClear.Enabled = false;
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("--> Unable to connect <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            hienThi();
            conn.Close();
        }
        //tạo một biến gender để lưu dữ liệu từ RadioButton
        public string gender = "Gay";
        private void btnClear_Click(object sender, EventArgs e)
        {
            statusBar2.Panels[0].Text = "Cleared successfully";
            txtName.Text = ""; ;
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtPassword.Text = "";
            txtUserName.Text = "";
            cbbDecentralization.Text = "";
            rdoFemale.Checked = false;
            rdoMale.Checked = false;
            btnClear.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar2.Panels[1].Text = System.DateTime.Today.ToLongDateString();
        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string name = txtName.Text;
            string username = txtUserName.Text;
            string pass = txtPassword.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string decentralization = cbbDecentralization.Text;

            string sqlname = "UPDATE Login Set UserName = N'" + name + "' Where Account = '" + username + "'";
            string sqlphone = "UPDATE Login Set PhoneNumber = '" + phone + "' Where Account = '" + username + "'";
            string sqlemail = "UPDATE Login Set Email = '" + email + "' Where Account = '" + username + "'";
            string sqlpass = "UPDATE Login Set Password = '" + pass + "' Where Account = '" + username + "'";
            string sqlgender = "UPDATE Login Set Gender = '" + gender + "' Where Account = '" + username + "'";
            string sqldecentralization = "UPDATE Login Set Decentralization = '" + decentralization + "' Where Account = '" + username + "'";

            conn.Open();
            if (username != "")
            {
                // lấy tài khoản của người dùng trong cơ sỡ dữ liệu nếu khác rỗng thì cho phép thực hiện
                NameUser = getName(username);
                if (NameUser != "")
                {
                    SqlCommand cmdname = new SqlCommand(sqlname, conn);
                    SqlCommand cmdpass = new SqlCommand(sqlpass, conn);
                    SqlCommand cmdemail = new SqlCommand(sqlemail, conn);
                    SqlCommand cmdphone = new SqlCommand(sqlphone, conn);
                    SqlCommand cmdgender = new SqlCommand(sqlgender, conn);
                    SqlCommand cmddecentralization = new SqlCommand(sqldecentralization, conn);
                    try
                    {
                        //nếu người dùng nhập dữ liệu vào ô textbox thì thực hiện update
                        if (name != "")
                        {
                            cmdname.ExecuteNonQuery();
                        }
                        if (pass != "")
                        {
                            cmdpass.ExecuteNonQuery();
                        }
                        if (email != "")
                        {
                            cmdemail.ExecuteNonQuery();
                        }
                        if (phone != "")
                        {
                            cmdphone.ExecuteNonQuery();
                        }
                        if (gender != "")
                        {
                            cmdgender.ExecuteNonQuery();
                        }
                        if (decentralization != "")
                        {
                            cmddecentralization.ExecuteNonQuery();
                        }
                        statusBar2.Panels[0].Text = "Updated successfully";
                        hienThi();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("--> Update failed <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("--> ID invalid <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("--> Please enter ID <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
            btnClear.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            statusBar2.Panels[0].Text = "Refreshing...";
            btnClear.Enabled = false;
            txtSearch.Text = "";
            conn.Open();
            hienThi();
            conn.Close();
        }
        //tìm kiếm 
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            //tạo câu lệnh select lọc theo dữ liệu người dùng nhập vào
            string sql = "select Account, Password, UserName, Email, PhoneNumber, Gender, Decentralization" +
                " from Login where (UserName like N'%" + search + "%' or Account like '"+ search +"')";

            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dar = cmd.ExecuteReader();
                DataTable dat = new DataTable();
                dat.Load(dar);
                dgrUser.DataSource = dat;
                statusBar2.Panels[0].Text = "Searched successfully";
            }
            catch (Exception)
            {
                MessageBox.Show("--> The name you searched for does not exist <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
