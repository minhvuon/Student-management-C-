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
    public partial class frmStudent : Form
    {
        //
        SqlConnection conn = new SqlConnection("Data Source = VUON\\SQLEXPRESS;" +
            " User ID = sa; Password = 020299; Database = StudentDetails");
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            statusBar2.Panels[0].Text = "Ready...";
            btnClear.Enabled = false;
            cbbSearchClass.Text = "";

            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("--> Enable to connect <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            hienThi();;
            conn.Close();
        }
        //hiển thị dữ liệu của sinh viên lên DataGridView
        private void hienThi()
        {
            string sqlSelect = "select * from Student order by IDStudent asc";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dar = cmd.ExecuteReader();
            DataTable dat = new DataTable();
            dat.Load(dar);
            dgrStudent.DataSource = dat;
        }

        //phương thức lấy ID của sinh viên từ cơ sở dữ liệu khi truyền vào một ID
        private string getID(string ID)
        {
            string id = "";
            string sqlid = "SELECT * FROM Student WHERE IDStudent = '" + ID + "'";
            SqlCommand cmdid = new SqlCommand(sqlid, conn);
            SqlDataAdapter daA = new SqlDataAdapter(cmdid);
            DataTable dat = new DataTable();
            daA.Fill(dat);
            if (dat != null)
            {
                foreach (DataRow daR in dat.Rows)
                {
                    id = daR["IDStudent"].ToString();
                }
            }
            return id;
        }
        //tạo một biến ID để lưu id lấy ra từ cơ sở dữ liệu
        public string ID = "";
        //tạo một biến gender để lưu dữ liệu từ radiobutton
        public string gender = "Gay";
        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            string id = txtID.Text;
            string name = txtName.Text;
            string address = txtAddress.Text;
            string dateofbirth = dtpckBirth.Text;
            string classs = lstClass.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            String sql = "INSERT into Student values('" + id + "', N'" + name + "'," +
                " N'" + address + "', '" + dateofbirth + "', '" + classs + "', '" + email + "'," +
                " '" + phone + "', '" + gender + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (id != "")
            {
                //lấy ID trong cơ sở dữ liệu ra để so sánh nếu bằng là đã có, thông báo
                ID = getID(id);
                if (id == ID)
                {
                    MessageBox.Show("--> ID already <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        statusBar2.Panels[0].Text = "Saved successfully";
                        hienThi();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("--> Save failed <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("--> Please enter ID <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
            btnClear.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //hiển thị thông tin lên statusbar
            statusBar2.Panels[0].Text = "Cleared successfully";
            cbbSearchClass.Text = "";
            txtSearch.Text = "";
            txtID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            dtpckBirth.Text = "";
            lstClass.Text = "";
            rdoFemale.Checked = false;
            rdoMale.Checked = false;
            btnClear.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {       
            string id = txtID.Text;
            string name = txtName.Text;
            string address = txtAddress.Text;
            string dateofbirth = dtpckBirth.Text;
            string classs = lstClass.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string sqlname = "UPDATE Student Set NameStudent = N'" + name + "' Where IDStudent = '" + id + "'";
            string sqladdress = "UPDATE Student Set Address = N'" + address + "' Where IDStudent = '" + id + "'";
            string sqldate = "UPDATE Student Set DateofBirth = '" + dateofbirth + "' Where IDStudent = '" + id + "'";
            string sqlclass = "UPDATE Student Set Class = '" + classs + "' Where IDStudent = '" + id + "'";
            string sqlemail = "UPDATE Student Set Email = '" + email + "' Where IDStudent = '" + id + "'";
            string sqlphone = "UPDATE Student Set PhoneNumber = '" + phone + "' Where IDStudent = '" + id + "'";
            string sqlgender = "UPDATE Student Set Gender = '" + gender + "' Where IDStudent = '" + id + "'";
            conn.Open();
            if (id != "")
            {
                //lấy ID sinh viên trong cơ sỡ dữ liệu nếu khác rỗng thì cho phép thực hiện
                ID = getID(id);
                if (ID != "")
                {
                    SqlCommand cmdname = new SqlCommand(sqlname, conn);
                    SqlCommand cmdaddress = new SqlCommand(sqladdress, conn);
                    SqlCommand cmddate = new SqlCommand(sqldate, conn);
                    SqlCommand cmdclass = new SqlCommand(sqlclass, conn);
                    SqlCommand cmdemail = new SqlCommand(sqlemail, conn);
                    SqlCommand cmdphone = new SqlCommand(sqlphone, conn);
                    SqlCommand cmdgender = new SqlCommand(sqlgender, conn);
                    try
                    {
                        //nếu người dùng nhập dữ liệu vào ô textbox thì thực hiện update
                        if (name != "")
                        {
                            cmdname.ExecuteNonQuery();
                        }
                        if (address != "")
                        {
                            cmdaddress.ExecuteNonQuery();
                        }
                        if (dateofbirth != "")
                        {
                            cmddate.ExecuteNonQuery();
                        }
                        if (classs != "")
                        {
                            cmdclass.ExecuteNonQuery();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
            string id = txtID.Text;
            //tạo câu lệnh sql xóa dữ liệu trong bảng Student của cơ sở dữ liệu
            string sql = "DELETE FROM Student WHERE IDStudent = '" + id + "'";
            //tạo câu lệnh sql xóa dữ liệu trong bảng Student của cơ sở dữ liệu
            string sql1 = "delete from ResultLearning where IDStudent = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlCommand cmd1 = new SqlCommand(sql1, conn);

            conn.Open();
            if (id != "")
            {
                //lấy ID sinh viên trong cơ sỡ dữ liệu nếu khác rỗng thì cho phép thực hiện
                ID = getID(id);
                if (ID != "")
                {
                    try
                    {
                        cmd1.ExecuteNonQuery();
                        cmd.ExecuteNonQuery();
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

        private void cbbSearchClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string scl = cbbSearchClass.Text;
            string sql = "select * from Student where Class = '"+ scl + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dar = cmd.ExecuteReader();
            DataTable dat = new DataTable();
            dat.Load(dar);
            dgrStudent.DataSource = dat;
            statusBar2.Panels[0].Text = "Searched successfully";
            conn.Close();
        }

        private void cbbSearchClass_Click(object sender, EventArgs e)
        {
            cbbSearchClass.Text = "";
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            statusBar2.Panels[0].Text = "Refreshing...";
            btnClear.Enabled = false;
            cbbSearchClass.Text = "";
            txtSearch.Text = "";
            conn.Open();
            hienThi();
            conn.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            string sql = "select * from Student where ( NameStudent like N'%" + search + "%' or" +
                " IDStudent like N'%" + search + "%' or Address like N'%" + search + "%' )";
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dar = cmd.ExecuteReader();
                DataTable dat = new DataTable();
                dat.Load(dar);
                dgrStudent.DataSource = dat;
                statusBar2.Panels[0].Text = "Searched successfully";
            }
            catch (Exception)
            {
                MessageBox.Show("--> The name you searched for does not exist <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
    }
}
