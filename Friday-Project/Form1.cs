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
    public partial class Form1 : Form
    {
        // Define x and y variables
        private int x = 0;
        private int y = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Construct button name based on x and y
            string buttonName = "btn" + y.ToString() + x.ToString();
            // Find the button control
            Button btn = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
                // Modify button properties
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.Red;
                btn.FlatAppearance.BorderSize = 1;
            }
            
    }
}
