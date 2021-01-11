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
    public partial class frmViewScores : Form
    {
        //
        SqlConnection conn = new SqlConnection("Data Source = VUON\\SQLEXPRESS;" +
            " User ID = sa; Password = 020299; Database = StudentDetails");
        public frmViewScores()
        {
            InitializeComponent();
        }
        //phương thức hiển thị dữ liệu lên DataGridView
        private void hienThi()
        {
            string sqlSelect = "select Student.Class, Student.IDStudent, NameStudent, Subject.SubjectName," +
                " ResultLearning.DiligenceScores, MidtermScores, EndtermScores, SubjectMediumScores from" +
                " Student, Subject, ResultLearning where Student.IDStudent = ResultLearning.IDStudent and" +
                " Subject.IDSubject = ResultLearning.IDSubject order by IDStudent asc";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataAdapter daA = new SqlDataAdapter(cmd);
            DataTable dat = new DataTable();
            daA.Fill(dat);
            dgrViewScores.DataSource = dat;
        }
        //phương thức hiển thị học kì lên combobox
        private void hienThiSemester()
        {
            string select = "Select distinct Semester from Subject";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbbSemester.Items.Add(reader.GetInt32(0));
            }
            reader.Dispose();
            cmd.Dispose();
        }
        //phương thức lấy ID của sinh viên từ cơ sở dữ liệu khi truyền vào ID
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

        private void cbbSemester_Click(object sender, EventArgs e)
        {
            cbbSemester.Text = "";
        }

        private void cbbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            string semester = cbbSemester.Text;
            //tạo câu lệnh sql lọc dữ liệu theo từng học kì
            string sql = "select Student.Class, Student.IDStudent, NameStudent, Subject.SubjectName," +
                " ResultLearning.DiligenceScores, MidtermScores, EndtermScores, SubjectMediumScores from" +
                " Student, Subject, ResultLearning where Student.IDStudent = ResultLearning.IDStudent and" +
                " Subject.IDSubject = ResultLearning.IDSubject and Semester = '" + semester + "' order by" +
                " IDStudent asc ";

            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dar = cmd.ExecuteReader();
            DataTable dat = new DataTable();
            dat.Load(dar);
            dgrViewScores.DataSource = dat;
            statusBar2.Panels[0].Text = "Searched successfully";
            conn.Close();
        }

        private void frmViewScores_Load(object sender, EventArgs e)
        {
            statusBar2.Panels[0].Text = "Ready...";
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("--> Unable to connect <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            hienThi();
            hienThiSemester();
            conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar2.Panels[1].Text = System.DateTime.Today.ToLongDateString();
        }
        
        private void cbbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string scl = cbbClass.Text;
            //tạo câu lệnh sql lọc dữ liệu theo lớp
            string sql = "select Student.Class, Student.IDStudent, NameStudent, Subject.SubjectName," +
                " ResultLearning.DiligenceScores, MidtermScores, EndtermScores, SubjectMediumScores from" +
                " Student, Subject, ResultLearning where Student.IDStudent = ResultLearning.IDStudent and" +
                " Subject.IDSubject = ResultLearning.IDSubject and Class = '" + scl + "' order by IDStudent asc";

            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dar = cmd.ExecuteReader();
            DataTable dat = new DataTable();
            dat.Load(dar);
            dgrViewScores.DataSource = dat;
            statusBar2.Panels[0].Text = "Searched successfully";
            conn.Close();
        }

        private void cbbClass_Click(object sender, EventArgs e)
        {
            cbbClass.Text = "";
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            statusBar2.Panels[0].Text = "Refreshing...";
            cbbClass.Text = "";
            cbbSemester.Text = "";
            txtSearch.Text = "";
            conn.Open();
            hienThi();
            conn.Close();
        }
        //tìm kiếm
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            string sql = "select Student.Class, Student.IDStudent, NameStudent, Subject.SubjectName," +
                " ResultLearning.DiligenceScores, MidtermScores, EndtermScores, SubjectMediumScores from " +
                "Student, Subject, ResultLearning where Student.IDStudent = ResultLearning.IDStudent and" +
                " Subject.IDSubject = ResultLearning.IDSubject and ( Student.IDStudent like '%"+ search+"%' or" +
                " NameStudent like N'%" + search + "%'or SubjectName like N'%" + search + "%')";

            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dar = cmd.ExecuteReader();
                DataTable dat = new DataTable();
                dat.Load(dar);
                dgrViewScores.DataSource = dat;
                statusBar2.Panels[0].Text = "Searched successfully";
            }
            catch (Exception)
            {
                MessageBox.Show("--> The name you searched for does not exist <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //lấy id của sinh viên từ cơ sở dữ liệu
            String idStudent = getID(txtSearch.Text);
            if(txtSearch.Text != "")
            {
                //nếu id khác rỗng là có trong cơ sở dữ liệu, cho phép thực hiện
                if (idStudent != "")
                {
                    Information.IDStudent = idStudent;
                    frmReport rp = new frmReport();
                    rp.Show();
                }
                else
                {
                    MessageBox.Show("--> ID student you searched for does not exist <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("--> Please enter ID student you want print <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
