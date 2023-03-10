using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Project
{
    public partial class Form1 : Form
    {  public static string username; 
         donor d1 = new donor();
        patient p1 = new patient();
        Ayeshamanziladmin a1 = new Ayeshamanziladmin();
        malir m1 = new malir();
        cliftonadmin c1= new cliftonadmin();
        public static string b;
       static int i;
        public Form1( )
        {
            InitializeComponent();
            if(secondpage.opt == 2)
            { button2.Enabled = false; }
            if(secondpage.opt == 3)
            { button2.Enabled = false;
                comboBox1.Enabled = false;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // signup button
        {     
            sign form = new sign();
           // this.Hide();
            form.Show();
            this.Hide();


        }
        private bool check( string user,string pass)
        {
         //   string ayeshamanziladminusername = "admin1";
         //   string ayeshamanzilpassword = "admin1";
         //   string cliftonuser = "admin2";
          //  string cliftonpass = "admin2";
          //  string maliruser = "admin3";
         //   string malirpass = "admin3";
            string phelobot = "tester";
            string phelobotpass = "tester";
            if (secondpage.opt== 0)
            {
                string s;
                s = Firstpage.path + "\\" + comboBox1.SelectedItem.ToString() + "\\" + "\\" + secondpage.usertype + "\\" + user + ".txt";
                if (File.Exists(s))
                {
                    FileStream fs;
                    BinaryFormatter bf = new BinaryFormatter();
                    fs = File.OpenRead(s);
                    d1 = (donor)bf.Deserialize(fs);
                    fs.Close();
                    if (d1.Password == pass)
                    {
                        return true;
                    }
                }
                else
                { MessageBox.Show("File doesnot exist"); }
            }

        if(secondpage.opt==1)
            {
                string s;
                s = Firstpage.path + "\\" + comboBox1.SelectedItem.ToString() + "\\" + "\\" + secondpage.usertype + "\\" + user + ".txt";
                if (File.Exists(s))
                {
                    FileStream fs;
                    BinaryFormatter bf = new BinaryFormatter();
                    fs = File.OpenRead(s);
                    p1 = (patient)bf.Deserialize(fs);
                    fs.Close();
                    if (p1.Password == pass)
                    {
                        return true;
                    }
                    else
                    { MessageBox.Show("File doesnot exist"); }
                }
            }

            if(secondpage.opt == 2)
            { if (i == 0 && user == a1.username && pass == a1.password)
                    return true;
                if (i == 1 && user == c1.username && pass == c1.password)
                    return true;
                if (i == 2 && user == m1.username && pass == m1.password)
                    return true;
            }
            if(secondpage.opt == 3)
            {
                if(user == phelobot && pass == phelobotpass)
                {
                    return true;
                }
            }

            return false;
        }

        private void Button1_Click(object sender, EventArgs e) //login button
        {
          //  b = "default";
           // b = comboBox1.SelectedItem.ToString();
            username = textBox1.Text;

            if (secondpage.opt == 0 && check(textBox1.Text,textBox2.Text)==true)
            {
               b = comboBox1.SelectedItem.ToString();
                
                donor1 form = new donor1();
                form.Show();
                this.Hide();


            }
                 else if(secondpage.opt == 1 && check(textBox1.Text, textBox2.Text)==true)
            {
                b = comboBox1.SelectedItem.ToString();
                this.Hide();
                patient2 form = new patient2();
                form.Show();
            }
            else if(secondpage.opt==2 && check(textBox1.Text,textBox2.Text)==true)
            {
                b = comboBox1.SelectedItem.ToString();
                this.Hide();
                admin form = new admin();
                form.Show();

            }
            else if(secondpage.opt  ==3 && check(textBox1.Text, textBox2.Text) == true)
            {
                this.Hide();
                phelobotomist form = new phelobotomist();
                form.Show();
            }
                else
            {
                MessageBox.Show("Invalid username or password");
            }
           

        }
      

        
        private void button3_Click(object sender, EventArgs e) //backbutton
        {
            this.Hide();
            secondpage form = new secondpage();
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            { i = 0;
                b = "AyeshaManzil branch";
            }

            if (comboBox1.SelectedIndex == 1)
            { i = 1;
                b = "Clifton branch";
        }
            if (comboBox1.SelectedIndex == 2)
            { i = 2;
                b = "Malir branch";
            }
        }
    }
}
