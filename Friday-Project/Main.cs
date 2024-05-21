using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Friday_Project
{
    public partial class Main : Form
    {
        private Student studentForm;
        private Teacher teacherForm;
        private Course courseForm;
        private Section sectionForm;
        private Enrollment enrollmentForm;
        private Attendance attendanceForm;

        bool sidebarExpand;

        public Main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form_Closed(object sender, EventArgs e)
        {
            if (sender is Form form)
            {
                form.FormClosed -= Form_Closed;
                if (form is Student) studentForm = null;
                if (form is Teacher) teacherForm = null;
                if (form is Course) courseForm = null;
                if (form is Section) sectionForm = null;
                if (form is Enrollment) enrollmentForm = null;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        
        
        private void student_click(object sender, EventArgs e)
        {
            if (studentForm == null)
            {
                studentForm = new Student();
                studentForm.FormClosed += Form_Closed;
                studentForm.MdiParent = this;
                studentForm.Dock = DockStyle.Fill;
                studentForm.Show();
            }
            else
            {
                studentForm.Activate();
            }
        }


        

        private void teacher_click(object sender, EventArgs e)
        {
            if (teacherForm == null)
            {
                teacherForm = new Teacher();
                teacherForm.FormClosed += Form_Closed;
                teacherForm.MdiParent = this;
                teacherForm.Dock = DockStyle.Fill;
                teacherForm.Show();
            }
            else
            {
                teacherForm.Activate();
            }
        }

        private void course_click(object sender, EventArgs e)
        {
            if (courseForm == null)
            {
                courseForm = new Course();
                courseForm.FormClosed += Form_Closed;
                courseForm.MdiParent = this;
                courseForm.Dock = DockStyle.Fill;
                courseForm.Show();
            }
            else
            {
                courseForm.Activate();
            }
        }

        private void section_click(object sender, EventArgs e)
        {
            if (sectionForm == null)
            {
                sectionForm = new Section();
                sectionForm.FormClosed += Form_Closed;
                sectionForm.MdiParent = this;
                sectionForm.Dock = DockStyle.Fill;
                sectionForm.Show();
            }
            else
            {
                sectionForm.Activate();
            }
        }

        private void enrollment_click(object sender, EventArgs e)
        {
            if (enrollmentForm == null)
            {
                enrollmentForm = new Enrollment();
                enrollmentForm.FormClosed += Form_Closed;
                enrollmentForm.MdiParent = this;
                enrollmentForm.Dock = DockStyle.Fill;
                enrollmentForm.Show();
            }
            else
            {
                enrollmentForm.Activate();
            }
        }

        private void attendance_click(object sender, EventArgs e)
        {
            if (attendanceForm==null)
            {
                attendanceForm = new Attendance();
                attendanceForm.FormClosed += Form_Closed;
                attendanceForm.MdiParent = this;
                attendanceForm.Dock = DockStyle.Fill;
                attendanceForm.Show();
            }
            else
            {
                attendanceForm.Activate();
            }
        }

        private void logout(object sender, EventArgs e)
        {
            MessageBox.Show("You are logging out");
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_click(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timer1.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    timer1.Stop();
                }
            }
        }
    }
}
