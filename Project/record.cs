using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Project
{

    public partial class record : Form
    {
        
     static   string t;
     //   int i;
        patient p1 = new patient();
        donor d1 = new donor();
        public record()
        {
            InitializeComponent();
            
        }
       
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void record_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pa;
            pa = Firstpage.path + "\\" + Form1.b + "\\" + "\\" + comboBox1.SelectedItem.ToString() + "\\" + "username.txt";
            //pa = Application.StartupPath+"\\Bloodbank" + "\\AyeshaManzil branch\\" + "\\" + comboBox1.SelectedItem.ToString() + "\\" + "username.txt";
            if (File.Exists(pa))
            {
                StreamReader sr = new StreamReader(pa);

                richTextBox1.Text = sr.ReadToEnd();
            }
            else
            {
                MessageBox.Show("No file exist here");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s;
            s = Firstpage.path + "\\" + Form1.b + "\\" + "\\" + comboBox1.SelectedItem.ToString() + "\\" + textBox1.Text + ".txt";
            if (File.Exists(s))
            {
                FileStream fs;
                BinaryFormatter bf = new BinaryFormatter();
                fs = File.OpenRead(s);
                if (comboBox1.SelectedIndex == 1)
                {
                    p1 = (patient)bf.Deserialize(fs);
                    fs.Close();
                    textBox10.Text = p1.Firstname;
                    textBox2.Text = p1.Lastname;
                    textBox3.Text = p1.Cnic;
                    textBox4.Text = p1.Cellphone;
                    textBox5.Text = p1.Gender;
                    textBox6.Text = p1.UserAddress;
                    textBox7.Text = p1.Username; 
                    textBox8.Text = p1.Password;
                    textBox9.Text = p1.bloodtype;
                    textBox11.Text = p1.bloodrequired.ToString();
                }
                else if(comboBox1.SelectedIndex == 0)
                {
                    d1 = (donor)bf.Deserialize(fs);
                    fs.Close();
                    textBox10.Text = d1.Firstname;
                    textBox2.Text = d1.Lastname;
                    textBox3.Text = d1.Cnic;
                    textBox4.Text = d1.Cellphone;
                    textBox5.Text = d1.Gender;
                    textBox6.Text = d1.UserAddress;
                    textBox7.Text = d1.Username;
                    textBox8.Text = d1.Password;
                    textBox9.Text = d1.Bloodgroup;
                    textBox11.Text = d1.Amountofblooddonated.ToString();
                }
                else
                {
                    MessageBox.Show("Please select a user type");
                }
                fs.Close();
            }

//Application.StartupPath + "\\Bloodbank" + "\\AyeshaManzil branch\\" + "\\" + comboBox1.SelectedItem.ToString() + "\\" + textBox1.Text + ".txt"
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // this.Hide();
            admin form = new admin();
            form.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
