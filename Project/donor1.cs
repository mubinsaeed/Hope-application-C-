using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class donor1 : Form
    {
        donor d1 = new donor();
        public donor1()
        {
            InitializeComponent();
            FileStream fs;
            BinaryFormatter bf = new BinaryFormatter();
            string s = Firstpage.path + "\\" + Form1.b + "\\" + "\\" + secondpage.usertype + "\\" + Form1.username + ".txt";
            if (File.Exists(s))
            {
                fs = File.OpenRead(Firstpage.path + "\\" + Form1.b + "\\" + "\\" + secondpage.usertype + "\\" + Form1.username + ".txt");
                d1 = (donor)bf.Deserialize(fs);
                fs.Close();
            }
            else
            {
                MessageBox.Show("File cannot be open at this moment");
            }
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void donor1_Load(object sender, EventArgs e)
        {
            panel1.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Hide();

            }
            else { panel1.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // this.Hide();
            secondpage ff= new secondpage();
             ff.Show();
            this.Hide();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            donate form = new donate();
            form.Show();
           
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            if(d1.GRNO==0)
            {
                MessageBox.Show("Your report is not generated yet! Please wait");
            }
            if(d1.GRNO==1)
            {
                MessageBox.Show("Your report is generate please collect it from the office");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = d1.Firstname;
            certificate pp = new certificate(s);
            pp.Show();
        }
    }
}
