using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class admin : Form
    {
        public admin()
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
            //this.Hide();
            secondpage form = new secondpage();
            //this.Hide();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            record form = new record();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            stock form = new stock();
            form.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
