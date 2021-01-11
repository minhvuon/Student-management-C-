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
    public partial class frmSubject : Form
    {
        //
        SqlConnection conn = new SqlConnection("Data Source = VUON\\SQLEXPRESS;" +
            " User ID = sa; Password = 020299; Database = StudentDetails");
        SqlDataReader reader;

        public frmSubject()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            statusBar2.Panels[0].Text = "Ready...";
            btnClear.Enabled = false;
            cbbSemester.Text = "";
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("--> Enable to connect <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            hienThi();
            hienThiSubjectOfStudent();
            hienThiSemester();
            hienThiName();
            hienThiID();
            hienThiIDSubject();
            conn.Close();
        }
        //hiển thị học kỳ lên ComboBox
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
        //hiển thị tên của sinh viên lên ComboBox
        private void hienThiName()
        {
            string selectname = "Select distinct NameStudent from Student ";
            SqlCommand cmdname = new SqlCommand(selectname, conn);
            reader = cmdname.ExecuteReader();
            while (reader.Read())
            {
                cbbStudentName.Items.Add(reader.GetString(0));
            }
            reader.Dispose();
            cmdname.Dispose();
        }
        //hiển thị ID của sinh viên lên ComboBox
        private void hienThiID()
        {
            string selectid = "Select distinct IDStudent from Student ";
            SqlCommand cmdid = new SqlCommand(selectid, conn);
            reader = cmdid.ExecuteReader();
            while (reader.Read())
            {
                cbbID.Items.Add(reader.GetValue(0));
            }
            reader.Dispose();
            cmdid.Dispose();
        }
        //hiển thị ID của môn học lên ComboBox
        public void hienThiIDSubject()
        {
            string selectidSubject = "Select distinct IDSubject from Subject ";
            SqlCommand cmdidSubject = new SqlCommand(selectidSubject, conn);
            reader = cmdidSubject.ExecuteReader();
            while (reader.Read())
            {
                cbbSubjectID.Items.Add(reader.GetString(0));
            }
            reader.Dispose();
            cmdidSubject.Dispose();
        }
        //hiển thị dữ liệu lên DataGridView
        private void hienThi()
        {
            string sqlSelect = "select * from Subject";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dar = cmd.ExecuteReader();
            DataTable dat = new DataTable();
            dat.Load(dar);
            dgrSubject.DataSource = dat;
        }
        //hiển thị dữ liệu lên DataGridView
        private void hienThiSubjectOfStudent()
        {
            string sqlSelect = "select ResultLearning.IDStudent, NameStudent, ResultLearning.IDSubject, SubjectName, Subject.NumberCredits, Semester from ResultLearning, Subject, Student where ResultLearning.IDSubject = Subject.IDSubject and ResultLearning.IDStudent = Student.IDStudent order by IDStudent asc";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dar = cmd.ExecuteReader();
            DataTable dat = new DataTable();
            dat.Load(dar);
            dgrSubjectOfStudent.DataSource = dat;
        }
        //phương thức lấy ID của môn học từ cơ sở dữ liệu khi truyền vào một ID
        private string getID(string ID)
        {
            string id = "";
            string sqlid = "SELECT * FROM Subject WHERE IDSubject = '" + ID + "'";
            SqlCommand cmdid = new SqlCommand(sqlid, conn);
            SqlDataAdapter daA = new SqlDataAdapter(cmdid);
            DataTable dat = new DataTable();
            daA.Fill(dat);
            if (dat != null)
            {
                foreach (DataRow daR in dat.Rows)
                {
                    id = daR["IDSubject"].ToString();
                }
            }
            return id;
        }
        //tạo một biến ID để lưu id lấy ra từ cơ sở dữ liệu
        public string ID = "";
        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtIDSubject.Text;
            string name = txtName.Text;
            string credits = txtCredits.Text;
            string semester = txtSemester.Text;

            conn.Open();
            //tạo câu lệnh sql để nhập dữ liệu cho bảng Subject
            String sql = "INSERT into Subject values('" + id + "', N'" + name + "', '" + credits + "', '" + semester + "')";
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
                        cbbSubjectID.Items.Clear();
                        hienThiIDSubject();
                        cbbSemester.Items.Clear();
                        hienThiSemester();
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
            statusBar2.Panels[0].Text = "Cleared successfully";
            cbbSemester.Text = "";
            cbbStudentName.Text = "";
            txtSearch.Text = "";
            txtIDSubject.Text = "";
            txtName.Text = "";
            txtCredits.Text = "";
            txtSemester.Text = "";
            btnClear.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
     
            string id = txtIDSubject.Text;
            string name = txtName.Text;
            string credits = txtCredits.Text;
            string semester = txtSemester.Text;

            string sqlname = "UPDATE Subject Set SubjectName = N'" + name + "' Where IDSubject = '" + id + "'";
            string sqlmeduScores = "UPDATE Subject Set NumberCredits = '" + credits + "' Where IDSubject = '" + id + "'";
            string sqlnbCredits = "UPDATE Subject Set Semester = '" + semester + "' Where IDSubject = '" + id + "'";

            conn.Open();
            if (id != "")
            {
                //lấy ID sinh viên trong cơ sỡ dữ liệu nếu khác rỗng thì cho phép thực hiện
                ID = getID(id);
                if (ID != "")
                {
                    SqlCommand cmdname = new SqlCommand(sqlname, conn);
                    SqlCommand cmdmeduScores = new SqlCommand(sqlmeduScores, conn);
                    SqlCommand cmdnbCredits = new SqlCommand(sqlnbCredits, conn);
                    try
                    {
                        //nếu người dùng nhập dữ liệu vào ô textbox thì thực hiện update
                        if (name != "")
                        {
                            cmdname.ExecuteNonQuery();
                        }
                        if (credits != "")
                        {
                            cmdmeduScores.ExecuteNonQuery();
                        }
                        if (semester != "")
                        {
                            cmdnbCredits.ExecuteNonQuery();
                        }

                        statusBar2.Panels[0].Text = "Updated successfully";
                        cbbSemester.Items.Clear();
                        hienThiSemester();
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
       
            string id = txtIDSubject.Text;
            string sql = "DELETE FROM Subject WHERE IDSubject = '" + id + "'";
            string sql1 = "delete from ResultLearning where IDSubject = '" + id + "'";
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            if (id != "")
            {
                // lấy ID sinh viên trong cơ sỡ dữ liệu nếu khác rỗng thì cho phép thực hiện
                ID = getID(id);
                if (ID != "")
                {
                    try
                    {
                        cmd1.ExecuteNonQuery();
                        cmd.ExecuteNonQuery();
                        statusBar2.Panels[0].Text = "Deleted successfully";
                        hienThi();
                        cbbSubjectID.Items.Clear();
                        hienThiIDSubject();
                        cbbSemester.Items.Clear();
                        hienThiSemester();
                        hienThiSubjectOfStudent();
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
        //phương thức lọc dữ liệu theo học kì
        private void cbbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            string semester = cbbSemester.Text;
            //tạo câu lệnh select lọc dữ liệu theo từng học kì
            string sql = "select * from Subject where Semester = '" + semester + "'";
            string sql1 = "select ResultLearning.IDStudent, NameStudent, ResultLearning.IDSubject, SubjectName," +
                " Subject.NumberCredits, Semester from ResultLearning, Subject, Student where" +
                " ResultLearning.IDSubject = Subject.IDSubject and ResultLearning.IDStudent = Student.IDStudent" +
                " and Subject.Semester = '"+ semester +"'";
            conn.Open();
            if (semester != "")
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dar = cmd.ExecuteReader();
                DataTable dat = new DataTable();
                dat.Load(dar);
                dgrSubject.DataSource = dat;

                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                SqlDataReader dar1 = cmd1.ExecuteReader();
                DataTable dat1 = new DataTable();
                dat1.Load(dar1);
                dgrSubjectOfStudent.DataSource = dat1;
                statusBar2.Panels[0].Text = "Searched successfully";
            }
            else
            {
                hienThi();
            }
            conn.Close();
        }

        private void cbbSemester_Click(object sender, EventArgs e)
        {
            cbbSemester.Text = "";
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            conn.Open();
            hienThi();
            conn.Close();
            statusBar2.Panels[0].Text = "Refreshing...";
        }

        private void cbbStudentName_Click(object sender, EventArgs e)
        {
            cbbStudentName.Text = "";
        }
        //phương thức lấy ID của môn học từ cơ sở dữ liệu khi truyền vào id của sinh viên và id của môn học
        private string getIDSubject(string IDStudent, string IDSubject)
        {
            string id = "";
            string sqlid = "SELECT * FROM ResultLearning WHERE" +
                " IDStudent = '" + IDStudent + "' and IDSubject = '" + IDSubject + "'";
            SqlCommand cmdid = new SqlCommand(sqlid, conn);
            SqlDataAdapter daA = new SqlDataAdapter(cmdid);
            DataTable dat = new DataTable();
            daA.Fill(dat);
            if (dat != null)
            {
                foreach (DataRow daR in dat.Rows)
                {
                    id = daR["IDSubject"].ToString();
                }
            }
            return id;
        }
        //phương thức lấy ID của sinh viên từ cơ sở dữ liệu khi truyền vào id của sinh viên và id của môn học
        private string getIDStudent(string IDStudent, string IDSubject)
        {
            string id = "";
            string sqlid = "SELECT * FROM ResultLearning WHERE" +
                " IDSubject = '" + IDSubject + "' and IDStudent = '" + IDStudent + "'";
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
        //phương thức kiểm tra môn học của sinh viên đã có trong cơ sở dữ liệu chưa
        public int checkSubject(string idStudent)
        {
            string id = "";
            string idSubject = cbbSubjectID.Text;
            string sqlid = "SELECT * FROM ResultLearning WHERE IDStudent = '" + idStudent + "'";
            SqlCommand cmdid = new SqlCommand(sqlid, conn);
            SqlDataAdapter daA = new SqlDataAdapter(cmdid);
            DataTable dat = new DataTable();
            daA.Fill(dat);
            //duyệt qua bảng dữ liệu nếu id mà bằng id nhập vào từ ComboBox thì trả về 1 ngược lại trả về 0
            if (dat != null)
            {
                foreach (DataRow daR in dat.Rows)
                {
                    id = daR["IDSubject"].ToString();
                    if (id == idSubject)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            string idSubject = cbbSubjectID.Text;
            string idStudent = cbbID.Text;
            string sql = "insert into ResultLearning(IDStudent, IDSubject)" +
                " values( '"+idStudent+"', '"+idSubject+"')";
            conn.Open();
            if (idStudent != "")
            {
                if(idSubject != "")
                {
                    //kiểm tra môn học đã có trong sinh viên này chưa, bằng 0 là chưa có, cho thực hiện
                    if(checkSubject(idStudent) == 0)
                    {
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        statusBar2.Panels[0].Text = "Saved successfully";
                        hienThiSubjectOfStudent();
                    }
                    else
                    {
                        MessageBox.Show("--> Student already have \"" + idSubject + "\"subjects <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("--> Please enter ID subject <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("--> Please enter ID student <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            string idSubject = cbbSubjectID.Text;
            string idStudent = cbbID.Text;
            string sql = "delete from ResultLearning where" +
                " IDStudent = '" + idStudent + "' and IDSubject = '" + idSubject + "'";
            conn.Open();
            if (idStudent != "")
            {
                if (idSubject != "")
                {
                    //lấy ID của sinh viên từ cơ sở dữ liệu
                    string StudentID = getIDStudent(idStudent, idSubject);
                    //lấy ID của môn học từ cơ sở dữ liệu
                    string SubjectID = getIDSubject(idStudent, idSubject);
                    //nếu khác rỗng là có trong cơ sở dữ liệu, thực hiện xóa 
                    if (StudentID != "" && SubjectID != "")
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            statusBar2.Panels[0].Text = "Deteled successfully";
                            hienThiSubjectOfStudent();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("--> Detele failed <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("-->ID \"" + idSubject + "\" of ID \"" + idStudent + "\" do not exist <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("--> Please enter ID subject <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("--> Please enter ID student <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            btnClear.Enabled = false;
            statusBar2.Panels[0].Text = "Refreshing...";
            cbbSemester.Text = "";
            cbbStudentName.Text = "";
            txtSearch.Text = "";
            conn.Open();

            hienThi();
            hienThiSubjectOfStudent();
            cbbSemester.Items.Clear();
            hienThiSemester();
            cbbStudentName.Items.Clear();
            hienThiName();
            cbbID.Items.Clear();
            hienThiID();
            cbbSubjectID.Items.Clear();
            hienThiIDSubject();

            conn.Close();
        }
        
        private void cbbStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbbStudentName.Text;
            //tạo câu lệnh sql lọc dữ liệu theo tên sinh viên
            string sql = "select ResultLearning.IDStudent, NameStudent, ResultLearning.IDSubject, SubjectName," +
                " Subject.NumberCredits, Semester from ResultLearning, Subject, Student where " +
                "ResultLearning.IDSubject = Subject.IDSubject and ResultLearning.IDStudent = Student.IDStudent" +
                " and Student.NameStudent = N'" + name +"'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dar = cmd.ExecuteReader();
            DataTable dat = new DataTable();
            dat.Load(dar);
            dgrSubjectOfStudent.DataSource = dat;
            statusBar2.Panels[0].Text = "Searched successfully";
            conn.Close();
        }
        //tìm kím trong 2 bảng dữ liệu
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            string sql = "select * from Subject where SubjectName like N'%" + search + "%'";
            string sql1 = "select ResultLearning.IDStudent, NameStudent, ResultLearning.IDSubject, SubjectName," +
                " Subject.NumberCredits, Semester from ResultLearning, Subject, Student where" +
                " ResultLearning.IDSubject = Subject.IDSubject and ResultLearning.IDStudent = Student.IDStudent" +
                " and (SubjectName like N'%" + search + "%' or NameStudent like N'%" + search + "%')";

            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dar = cmd.ExecuteReader();
                DataTable dat = new DataTable();
                dat.Load(dar);
                dgrSubject.DataSource = dat;

                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                SqlDataReader dar1 = cmd1.ExecuteReader();
                DataTable dat1 = new DataTable();
                dat1.Load(dar1);
                dgrSubjectOfStudent.DataSource = dat1;
                statusBar2.Panels[0].Text = "Searched successfully";
            }
            catch (Exception)
            { 
                MessageBox.Show("--> The subject name you searched for does not exist <--", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
        }
    }
}
