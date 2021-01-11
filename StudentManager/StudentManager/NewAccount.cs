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
    public partial class frmNewAccount : Form
    {
        //tạo một kết nối với cơ sỡ dữ liệu
        SqlConnection conn = new SqlConnection("Data Source = VUON\\SQLEXPRESS; User ID = sa;" +
        " Password = 020299; Database = StudentDetails");
        public frmNewAccount()
        {
            InitializeComponent();
        }
        //phương thức lấy ID của người dùng khi truyền vào tài khoản
        private string getID(string name)
        {
            string id = "";
            //tạo một câu lệnh truy vấn
            string sql = "SELECT * FROM Login WHERE Account = '" + name + "'";
            //tạo câu lệnh để thực thi truy vấn
            SqlCommand cmd = new SqlCommand(sql, conn);
            //dùng SqlDataAdapter để đọc dữ liệu từ câu lệnh cmd
            SqlDataAdapter daA = new SqlDataAdapter(cmd);
            //tạo một bảng mới
            DataTable daT = new DataTable();
            //đổ dữ liệu từ Adapter vào bảng
            daA.Fill(daT);
            if (daT != null)
            {
                //duyệt qua dòng trong bảng và lấy ra cột IDUser
                foreach (DataRow daR in daT.Rows)
                {
                    id = daR["IDUser"].ToString();
                }
            }
            return id;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin lg = new frmLogin();
            lg.Show();
            this.Hide();
        }
        public static string IDUser = "";
        public static string gender = "Gay";

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string user = txtName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string name = txtAccount.Text;
            string pass = txtPass.Text;
            string rpass = txtRPass.Text;
            string decentralization = cbbDecentralization.Text;
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("--> Enable to connect <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(decentralization != "")
            {
                //lấy tên tài khoản của người dùng vừa nhập vào đã có trong cơ sở dữ liệu hay chưa 
                //( bằng rỗng là chưa có và ngược lại) 
                IDUser = getID(name);
                if (IDUser == "")
                {
                    string sql = "INSERT into Login values(N'" + user + "','" + phone + "','" + gender + "'," +
                    "'" + email + "','" + name + "', '" + pass + "', '" + decentralization + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //nếu tài khoản và mật khẩu người dùng đã nhập ở ô textbox thì thực hiện
                    if (name != "" && pass != "")
                    {
                        //nếu mật khẩu không trùng khớp với mật khẩu nhập lại lần 2 thì thông báo
                        if (pass != rpass)
                        {
                            MessageBox.Show("--> Password incorrect <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("--> Created successfully <--", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("--> Please enter data <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("--> Account Already Exists <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("--> Please enter decentralization <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtName.Clear();
        }

        private void txtPhone_Click(object sender, EventArgs e)
        {
            txtPhone.Clear();
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
        }

        private void txtAccount_Click(object sender, EventArgs e)
        {
            txtAccount.Clear();
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
        }

        private void txtRPass_Click(object sender, EventArgs e)
        {
            txtRPass.Clear();
        }
        //phương thức cho sự kiện click mở xem mật khẩu
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !txtPass.UseSystemPasswordChar;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtRPass.UseSystemPasswordChar = !txtRPass.UseSystemPasswordChar;
        }
    }
}
