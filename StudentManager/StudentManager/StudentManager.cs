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
    public partial class frmStudentManager : Form
    {
        Image closeImage, closeImageAct;
        public frmStudentManager()
        {
            InitializeComponent();
        }

        public void addTab(Form frm)
        {
            int a = checkTab(frm);
            if (a > -1) //form đã được mở
            {
                //nếu tab đã được chọn
                if (tabControl1.SelectedTab == tabControl1.TabPages[a])
                {
                    MessageBox.Show("--> Tab \"" + frm.Text.Trim() + "\" opened<--", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    tabControl1.SelectedTab = tabControl1.TabPages[a];
                }
            }
            else //thêm
            {
                TabPage newTab = new TabPage(frm.Text.Trim());
                tabControl1.TabPages.Add(newTab);
                frm.TopLevel = false;
                frm.Parent = newTab;
                tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabCount - 1];
                frm.Show();
                frm.Dock = DockStyle.Fill;
            }
        }

        public int checkTab(Form frm)
        {
            for (int i = 0; i < tabControl1.TabCount; i++)
            {
                if (tabControl1.TabPages[i].Text == frm.Text.Trim())
                {
                    return i;
                }
            }
            return -2;
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Rectangle rect = tabControl1.GetTabRect(e.Index);
            Rectangle imagerect = new Rectangle(rect.Right - closeImage.Width, rect.Top + (rect.Height - closeImage.Height) / 2, closeImage.Width, closeImage.Height);
            //tăng  size cho rect
            rect.Size = new Size(rect.Width + 24, 38);
            Font f;
            Brush br = Brushes.Black;
            StringFormat strf = new StringFormat(StringFormat.GenericDefault);
            if (tabControl1.SelectedTab == tabControl1.TabPages[e.Index])
            {
                e.Graphics.DrawImage(closeImageAct, imagerect);
                f = new Font("Arial", 10, FontStyle.Bold);
                //tên tabpage
                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text, f, br, rect, strf);
            }
            else
            {
                //tab đang mở nhưng không được chọn
                e.Graphics.DrawImage(closeImage, imagerect);
                f = new Font("Arial", 9, FontStyle.Regular  );
                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text, f, br, rect, strf);
            }
        }

        private void btnSubjectManager_Click(object sender, EventArgs e)
        {
            addTab(new frmSubject());
        }

        private void btnStudentManager_Click(object sender, EventArgs e)
        {
            addTab(new frmStudent());
        }

        private void btnScoresManagement_Click(object sender, EventArgs e)
        {
            addTab(new frmScores());
        }

        private void frmStudentManager_Load(object sender, EventArgs e)
        {
            Size s = new System.Drawing.Size(15, 15);
            Bitmap b = new Bitmap(Properties.Resources.Actions_window_close_icon__1_);
            Bitmap bm = new Bitmap(b, s);
            closeImageAct = bm;
            Bitmap bit = new Bitmap(Properties.Resources.playstation_cross_black_and_white_icon__1_);
            Bitmap bitm = new Bitmap(bit, s);
            closeImage = bitm;
            tabControl1.Padding = new Point(30);

            txtNameUser.Text = Information.Name;

            if (Information.Decentralization.Equals("User"))
            {
                btnStudentManager.Enabled = false;
                btnSubjectManager.Enabled = false;
                btnScoresManagement.Enabled = false;
                studentManagementToolStripMenuItem.Enabled = false;
                subjectManagementToolStripMenuItem.Enabled = false;
                scoresManagementToolStripMenuItem.Enabled = false;
                userManagerToolStripMenuItem.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabControl1.TabCount; i++)
            {
                Rectangle rect = tabControl1.GetTabRect(i);
                Rectangle imagerect = new Rectangle(rect.Right - closeImage.Width, rect.Top + (rect.Height - closeImage.Height) / 2, closeImage.Width, closeImage.Height);
                if (imagerect.Contains(e.Location))
                {
                    tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                }
            }
        }

        private void informationUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInformation user = new frmUserInformation();
            user.Show();
            this.Hide();
        }

        private void mnItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addTab(new frmUser());
        }

        private void btnViewScores_Click(object sender, EventArgs e)
        {
            addTab(new frmViewScores());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout ab = new frmAbout();
            ab.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
    }
}
