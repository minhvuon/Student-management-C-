using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            string id = Information.IDStudent;
            //đổ dữ liệu vào bảng DataSet1.ResultLearning đã tạo
            this.ResultLearningTableAdapter.Fill(this.DataSet1.ResultLearning, id);
            //đổ dữ liệu vào bảng DataSet1.Student đã tạo
            this.StudentTableAdapter.Fill(this.DataSet1.Student, id);

            this.reportViewer1.RefreshReport();
        }
    }
}
