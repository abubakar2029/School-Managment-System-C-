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
    public partial class DashboardTemplate : Form
    {
        Dashboard dashboard;
        About about;
        bool sidebarExpand;
        bool menu1Expand;
        public DashboardTemplate()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*PictureBox PictureBox2 = new PictureBox();
            this.pictureBox2.BorderStyle = BorderStyle.None;*/

            Button button1 = new Button();
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderColor = Color.Transparent; // transparent
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu1Transition.Start();
        }

        private void dashboardForm_Closed(object sender, EventArgs e)
        {
            dashboard=null;
        }

        private void sidebarTimer_Click(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void menu1Transition_Tick_Tick(object sender, EventArgs e)
        {
            if (menu1Expand)
            {
                menu1.Height += 10;
                if (menu1.Height == menu1.MaximumSize.Height)
                {
                    menu1Expand = false;
                    menu1Transition.Stop();
                }
            }
            else
            {
                menu1.Height -= 10;
                if (menu1.Height == menu1.MinimumSize.Height)
                {
                    menu1Expand = true;
                    menu1Transition.Stop();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.BorderColor = Color.Transparent; // transparent
            button8.FlatAppearance.MouseOverBackColor = button8.BackColor;
            button8.FlatAppearance.MouseDownBackColor = button8.BackColor;
            button8.BackColorChanged += (s, ev) =>
            {
                button8.FlatAppearance.MouseOverBackColor = button8.BackColor;
                button8.FlatAppearance.MouseDownBackColor = button8.BackColor;
            };
            button8.TabStop = false; // Removes the focus outline
        }

        private void DashboardTemplate_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new Dashboard();
                dashboard.FormClosed += dashboardForm_Closed;
                dashboard.MdiParent = this;
                dashboard.Dock=DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }
    }
}
