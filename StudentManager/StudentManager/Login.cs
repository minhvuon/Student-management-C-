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
    public partial class frmLogin : Form
    {
        //tạo một kết nối với cơ sỡ dữ liệu
        SqlConnection conn = new SqlConnection("Data Source = VUON\\SQLEXPRESS;" +
            " User ID = sa; Password = 020299; Database = StudentDetails");
        public frmLogin()
        {
            InitializeComponent();
        }
        //phương thức lấy ID của người dùng khi truyền vào tài khoản và mật khẩu
        private string getID(string name, string pass)
        {
            string id = "";
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("--> Enable to connect <--", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            //tao một câu lệnh để thực thi truy vấn
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE Account='" + name + "' and PassWord='" + pass + "'", conn);
            //dùng SqlDataAdapter để đọc dữ liệu từ câu lệnh cmd
            SqlDataAdapter daA = new SqlDataAdapter(cmd);
            //tạo một bảng
            DataTable daT = new DataTable();
            //đổ dữ liệu từ Adapter vào bảng vừa tạo
            daA.Fill(daT);
            if (daT != null)
            {
                //duyệt qua dòng trong bảng và lấy ra cột IDUser
                foreach (DataRow daR in daT.Rows)
                {
                    id = daR["IDUser"].ToString();
                }
            }
            conn.Close();
            return id;
        }
        //phương thức lấy quyền sử dụng của người dùng khi truyền vào tài khoản và mật khẩu
        private string getDecentralization(string name, string pass)
        {
            string decentralization = "";
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE Account='" + name + "' and PassWord='" + pass + "'", conn);
            SqlDataAdapter daA = new SqlDataAdapter(cmd);
            DataTable daT = new DataTable();
            daA.Fill(daT);
            if (daT != null)
            {
                foreach (DataRow daR in daT.Rows)
                {
                    decentralization = daR["Decentralization"].ToString();
                }
            }
            conn.Close();
            return decentralization;
        }
        //phương thức lấy tên của người dùng khi truyền vào tài khoản và mật khẩu
        private string getName(string name, string pass)
        {
            string Name = "";
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE Account='" + name + "' and PassWord='" + pass + "'", conn);
            SqlDataAdapter daA = new SqlDataAdapter(cmd);
            DataTable daT = new DataTable();
            daA.Fill(daT);
            if (daT != null)
            {
                foreach (DataRow daR in daT.Rows)
                {
                    Name = daR["UserName"].ToString();
                }
            }
            conn.Close();
            return Name;
        }

        public string IDUser = "";
        public string Decentralization = "";
        public string NameU = ""; 
        //phương thức thoát khỏi chương trình
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Do you want to exit this program?", "LOGIN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        //phương thức đăng nhập mở một form mới
        private void btnSigIn_Click(object sender, EventArgs e)
        {
            String acc = txtAccount.Text;
            String pass = txtPassWord.Text;
            //lấy ID người dùng
            IDUser = getID(acc, pass);
            //lấy phân quyền của người dùng
            Decentralization = getDecentralization(acc, pass);
            //lấy tên của người dùng
            NameU = getName(acc, pass);
            if (IDUser != "")
            {
                Information.ID = IDUser;
                Information.Decentralization = Decentralization;
                Information.Name = NameU;
                frmStudentManager lienket = new frmStudentManager();
                lienket.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("--> Account invalid <--", "Please enter agian", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void txtAccount_Click(object sender, EventArgs e)
        {
            txtAccount.Clear();
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            txtAccount.ForeColor = Color.Black;
            panel2.BackColor = Color.WhiteSmoke;
        }

        private void txtPassWord_Click(object sender, EventArgs e)
        {
            txtPassWord.Clear();
            txtPassWord.PasswordChar = '*';
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            txtPassWord.ForeColor = Color.Black;
            panel1.BackColor = Color.WhiteSmoke;
        }

        private void lnkNAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNewAccount nacc = new frmNewAccount();
            nacc.Show();
            this.Hide();
        }
    }
}
