using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class patient2 : Form
    {
        public patient2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e) //sliding panel button
        { if(panel1.Visible)
            {
                panel1.Hide();
            }
        else
            {
                panel1.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e) //logout button
        {
           
            secondpage ff = new secondpage();
            ff.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            request form = new request();
            form.Show();
        }

        private void patient2_Load(object sender, EventArgs e)
        {

        }
    }
}
