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
    public partial class donate : Form
    {
        donor d1 = new donor();
        int index;
       // string[] lines;00
        inventory obj = new inventory();
        inventory obj2 = new inventory();
        public donate()
        {
            InitializeComponent();
            FileStream fs;
            BinaryFormatter bf = new BinaryFormatter();
            string s;
            s = Firstpage.path + "\\" + Form1.b + "\\" + "\\" + secondpage.usertype + "\\" + Form1.username + ".txt";
            if (File.Exists(s))
            {
                fs = File.OpenRead(Firstpage.path + "\\" + Form1.b + "\\" + "\\" + secondpage.usertype + "\\" + Form1.username + ".txt");
                d1 = (donor)bf.Deserialize(fs);
                fs.Close();
            }
            else
            { MessageBox.Show("File cannot be opened at this moment"); }

        }
        public void set()
        {
            if (index == 0)
                obj.Apos = float.Parse(textBox1.Text);
            if (index == 1)
                obj.Aneg= float.Parse(textBox1.Text); 
            if (index == 2)
                obj.Bpos = float.Parse(textBox1.Text);
            if (index == 3)
                obj.Bneg = float.Parse(textBox1.Text);
            if (index == 4)
                obj.ABpos = float.Parse(textBox1.Text);
            if (index == 5)
                obj.ABneg = float.Parse(textBox1.Text);
            if (index == 6)
                obj.Opos = float.Parse(textBox1.Text);
            if (index == 7)
                obj.Oneg = float.Parse(textBox1.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            set();
            d1.Amountofblooddonated = float.Parse(textBox1.Text);
            d1.Bloodgroup = comboBox1.SelectedItem.ToString();
            
            MessageBox.Show("Thanks for donating. You can get your certificate from portal");
            FileStream fs = new FileStream(Firstpage.path + "\\" + Form1.b + "\\" + "\\" + secondpage.usertype + "\\" + Form1.username + ".txt", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, d1);
            fs.Close();
            string fpath;
            fpath = Firstpage.path + "\\" + Form1.b + "\\" + "donation.txt";
            if (!File.Exists(fpath))
            {
                FileStream o = new FileStream(fpath, FileMode.Create);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(o, obj);
                o.Close();

            }
            else
            {
                FileStream o = new FileStream(fpath, FileMode.Open);
                BinaryFormatter b = new BinaryFormatter();
                obj2 = (inventory)bf.Deserialize(o);
                o.Close();
                inventory temp = new inventory();
                temp = obj + obj2;
                FileStream k = new FileStream(fpath, FileMode.OpenOrCreate);
                BinaryFormatter f = new BinaryFormatter();
                f.Serialize(k, temp);
                k.Close();

            }
            donor1 form = new donor1();
            
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            donor1 form = new donor1();
            //this.Hide();
            form.Show();
            this.Hide();
        }

        private void donate_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                index = 0;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                index = 1;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                index = 2;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                index = 3;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                index = 4;
            }
            if (comboBox1.SelectedIndex == 5)
            {
                index = 5;
            }
            if (comboBox1.SelectedIndex == 6)
            {
                index = 6;
            }
            if (comboBox1.SelectedIndex == 7)
            {
                index = 7;
            }






        }
    }
}
