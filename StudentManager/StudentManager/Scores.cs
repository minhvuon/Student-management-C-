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
    public partial class frmScores : Form
    {
        //
        SqlConnection conn = new SqlConnection("Data Source = VUON\\SQLEXPRESS;" +
        " User ID = sa; Password = 020299; Database = StudentDetails");
        SqlDataReader reader;
        public frmScores()
        {
            InitializeComponent();
        }
        //phương thức hiển thị dữ liệu lên DataGridView
        private void hienThi()
        {
                string sqlSelect = "select Student.Class, Student.IDStudent, NameStudent, Subject.IDSubject," +
                " SubjectName, ResultLearning.DiligenceScores, MidtermScores, EndtermScores, SubjectMediumScores" +
                " from Student, Subject, ResultLearning where Student.IDStudent = ResultLearning.IDStudent" +
                " and Subject.IDSubject = ResultLearning.IDSubject order by IDStudent asc";
                SqlCommand cmd = new SqlCommand(sqlSelect, conn);
                SqlDataAdapter daA= new SqlDataAdapter(cmd);
                DataTable dat = new DataTable();
                daA.Fill(dat);
                dgrScores.DataSource = dat;
        }
        //phương thức hiển thị các học kỳ lên ComboBox
        private void hienThiSemester()
        {
            string select = "Select distinct Semester from Subject";
            SqlCommand cmd = new SqlCommand(select, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbbSemester.Items.Add(reader.GetInt32(0));
            }
            reader.Dispose();
            cmd.Dispose();
        }

        private void cbbSemester_Click(object sender, EventArgs e)
        {
            cbbSemester.Text = "";
        }
        //phương thức lọc dữ liệu hiển thị lên DataGridView theo từng học kì
        private void cbbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            string semester = cbbSemester.Text;
            string sql = "select Student.Class, Student.IDStudent, NameStudent, Subject.IDSubject, SubjectName," +
            " ResultLearning.DiligenceScores, MidtermScores, EndtermScores, SubjectMediumScores from Student," +
            " Subject, ResultLearning where Student.IDStudent = ResultLearning.IDStudent and " +
            "Subject.IDSubject = ResultLearning.IDSubject and Semester = '" + semester + "' order by IDStudent asc ";

            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dar = cmd.ExecuteReader();
            DataTable dat = new DataTable();
            dat.Load(dar);
            dgrScores.DataSource = dat;
            statusBar2.Panels[0].Text = "Searched successfully";

            conn.Close();
        }
        //phương thức hiển thị ID của sinh viên lên ComboBox
        private void hienThiID()
        {
            string selectid = "Select distinct IDStudent from ResultLearning ";
            SqlCommand cmdid = new SqlCommand(selectid, conn);
            reader = cmdid.ExecuteReader();
            while (reader.Read())
            {
                cbbIDStudent.Items.Add(reader.GetValue(0));
            }
            reader.Dispose();
            cmdid.Dispose();
        }
        //phương thức hiển thị ID của môn học lên ComboBox
        public void hienThiIDSubject()
        {
            string selectidSubject = "Select distinct IDSubject from ResultLearning ";
            SqlCommand cmdidSubject = new SqlCommand(selectidSubject, conn);
            reader = cmdidSubject.ExecuteReader();
            while (reader.Read())
            {
                cbbIDSubject.Items.Add(reader.GetString(0));
            }
            reader.Dispose();
            cmdidSubject.Dispose();
        }

        private void frmScores_Load(object sender, EventArgs e)
        {
            statusBar2.Panels[0].Text = "Ready...";
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
            hienThiID();
            hienThiIDSubject();
            hienThiSemester();
            conn.Close();
        }
        //phương thức lấy ID của sinh viên từ cơ sở dữ liệu khi truyền vào một ID
        private string getIDStudent(string ID)
        {
            string id = "";
            string sqlid = "SELECT * FROM ResultLearning WHERE IDStudent = '" + ID + "'";
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
        //phương thức lấy ID của môn học từ cơ sỡ dữ liệu khi truyền vào một ID
        private string getIDSubject(string ID)
        {
            string id = "";
            string sqlid = "SELECT * FROM ResultLearning WHERE IDSubject = '" + ID + "'";
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            statusBar2.Panels[0].Text = "Cleared successfully";
            cbbSemester.Text = "";
            cbbSearchClass.Text = "";
            txtSearch.Text = "";
            cbbIDStudent.Text = "";
            cbbIDSubject.Text = "";
            txtDiligence.Text = "";
            txtMidterm.Text = "";
            txtEndterm.Text = "";
            btnClear.Enabled = false;
        }

        public string IDStudent = "";
        public string IDSubject = "";

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = cbbIDStudent.Text;
            string idSubject = cbbIDSubject.Text; 
            string diligence = txtDiligence.Text;
            string midterm = txtMidterm.Text;
            string endterm = txtEndterm.Text;
            conn.Open();
            if (id != "" && idSubject != "")
            {
                //lấy ID sinh viên trong cơ sỡ dữ liệu nếu khác rỗng thì cho phép thực hiện
                IDStudent = getIDStudent(id);
                //lấy ID của môn học trong cơ sỡ dữ liệu nếu khác rỗng thì cho phép thực hiện
                IDSubject = getIDSubject(idSubject);
                if (IDStudent != "")
                {
                    if(IDSubject != "")
                    {
                        try
                        {
                            //nếu TextBox diligence có dữ liệu thì thực hiện update
                            if (diligence != "")
                            {
                                string sqldiligence = "UPDATE ResultLearning Set DiligenceScores = '" + diligence + "' " +
                                "Where IDStudent = '" + id + "' and IDSubject = '" + idSubject + "'";
                                SqlCommand cmddiligence = new SqlCommand(sqldiligence, conn);
                                cmddiligence.ExecuteNonQuery();
                            }
                            if (midterm != "")
                            {
                                string sqlmidterm = "UPDATE ResultLearning Set MidtermScores = '" + midterm + "'" +
                                " Where IDStudent = '" + id + "' and IDSubject = '" + idSubject + "'";
                                SqlCommand cmdmidterm = new SqlCommand(sqlmidterm, conn);
                                cmdmidterm.ExecuteNonQuery();
                            }
                            if (endterm != "")
                            {
                                string sqlendterm = "UPDATE ResultLearning Set EndtermScores = '" + endterm + "' " +
                                "Where IDStudent = '" + id + "' and IDSubject = '" + idSubject + "'";
                                SqlCommand cmdendterm = new SqlCommand(sqlendterm, conn);
                                cmdendterm.ExecuteNonQuery();
                            }
                            //tạo câu lệnh sql cập nhật điểm cho cột SubjectMediumScores
                            string sqlmedium = "UPDATE ResultLearning Set SubjectMediumScores = DiligenceScores*0.1" +
                            " + MidtermScores*0.2 +EndtermScores*0.7 Where " +
                            "IDStudent = '" + id + "' and IDSubject = '" + idSubject + "'";
                            SqlCommand cmdmedium = new SqlCommand(sqlmedium, conn);
                            cmdmedium.ExecuteNonQuery();
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
                        MessageBox.Show("--> ID subject invalid <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("--> ID student invalid <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
          
            string id = cbbIDStudent.Text;
            string idSubject = cbbIDSubject.Text;
            string sql = "update ResultLearning set DiligenceScores = '', MidtermScores = '', EndtermScores = ''," +
            " SubjectMediumScores = '' where IDSubject = '"+ idSubject +"' and IDStudent = '"+ id +"'";
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            if (id != "" && idSubject != "")
            {
                IDStudent = getIDStudent(id);
                IDSubject = getIDSubject(idSubject);
                if (IDStudent != "")
                {
                    if(IDSubject != "")
                    {
                        try
                        {
                            cmd.ExecuteNonQuery();
                            statusBar2.Panels[0].Text = "Deleted successfully";
                            hienThi();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("--> Detelion failed <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("--> ID subject invalid <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("--> ID student invalid <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cbbSearchClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string scl = cbbSearchClass.Text;
            //tạo câu lệnh sql lọc dữ liệu theo lớp
            string sql = "select Student.Class, Student.IDStudent, NameStudent, Subject.IDSubject, SubjectName," +
            " ResultLearning.DiligenceScores, MidtermScores, EndtermScores, SubjectMediumScores from" +
            " Student, Subject, ResultLearning where Student.IDStudent = ResultLearning.IDStudent and" +
            " Subject.IDSubject = ResultLearning.IDSubject and Class = '" + scl + "' order by IDStudent asc";

            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dar = cmd.ExecuteReader();
            DataTable dat = new DataTable();
            dat.Load(dar);
            dgrScores.DataSource = dat;
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

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            btnClear.Enabled = false;
            statusBar2.Panels[0].Text = "Refreshing...";
            cbbSearchClass.Text = "";
            txtSearch.Text = "";
            cbbIDStudent.Text = "";
            cbbIDSubject.Text = "";

            conn.Open();

            hienThi();
            cbbIDStudent.Items.Clear();
            hienThiID();
            cbbIDSubject.Items.Clear();
            hienThiIDSubject();

            conn.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            //tạo câu lệnh sql lọc dữ liệu theo người dùng nhập vào textbox
            string sql = "select Student.Class, Student.IDStudent, NameStudent, Subject.IDSubject, SubjectName," +
                " ResultLearning.DiligenceScores, MidtermScores, EndtermScores, SubjectMediumScores from " +
                "Student, Subject, ResultLearning where Student.IDStudent = ResultLearning.IDStudent and " +
                "Subject.IDSubject = ResultLearning.IDSubject and ( NameStudent like N'%" + search + "%'or " +
                "SubjectName like N'%" + search + "%')";

            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dar = cmd.ExecuteReader();
                DataTable dat = new DataTable();
                dat.Load(dar);
                dgrScores.DataSource = dat;
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
