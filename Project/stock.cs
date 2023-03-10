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
    public partial class stock : Form
    {
        inventory obj = new inventory();
        public stock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            admin form = new admin();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s;
            s = Firstpage.path + "\\" + Form1.b + "\\" + "donation.txt";
            if (File.Exists(s))
            {
                FileStream fs;
                BinaryFormatter bf = new BinaryFormatter();
                fs = File.OpenRead(s);
                obj = (inventory)bf.Deserialize(fs);
                // fs = File.OpenRead(Firstpage.path + "\\" + comboBox1.SelectedItem.ToString() + "\\" + "\\" + secondpage.usertype + "\\" + user + ".txt");
                // d1 = (donor)bf.Deserialize(fs);
                fs.Close();
                textBox1.Text = obj.Apos.ToString();
                textBox2.Text = obj.Aneg.ToString();
                textBox3.Text = obj.Bpos.ToString();
                textBox4.Text = obj.Bneg.ToString();
                textBox5.Text = obj.ABpos.ToString();
                textBox6.Text = obj.ABneg.ToString();
                textBox7.Text = obj.Opos.ToString();
                textBox8.Text = obj.Oneg.ToString();

            }
            else
            { MessageBox.Show("No one has donated yet! No record"); }
           


        }

        private void stock_Load(object sender, EventArgs e)
        {

        }
    }
}
