using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class certificate : Form
    { string s;
        public certificate(string s)
        {
            InitializeComponent();
            this.s = s;
            textBox2.Text = "Hope foundation";
            textBox1.Text = s;
        }

        private void certificate_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
