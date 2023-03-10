using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class phelobotomist : Form
    {
        public phelobotomist()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Hide();
            }
            else
            {
                panel1.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // this.Hide();
            secondpage form = new secondpage();
          //  this.Hide();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            generatingreport form = new generatingreport();
            form.Show();
        }

        private void phelobotomist_Load(object sender, EventArgs e)
        {

        }
    }
}
