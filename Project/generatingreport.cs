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
    public partial class generatingreport : Form
    {
        donor d1 = new donor();
        public generatingreport()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          //  this.Hide();
            phelobotomist form = new phelobotomist();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pa;
            
            pa = Firstpage.path +   "\\" + comboBox1.SelectedItem.ToString() + "\\"+"\\Donor\\" +"username.txt";
            //pa = Application.StartupPath+"\\Bloodbank" + "\\AyeshaManzil branch\\" + "\\" + comboBox1.SelectedItem.ToString() + "\\" + "username.txt";
            if (File.Exists(pa))
            {
                StreamReader sr = new StreamReader(pa);

                richTextBox1.Text = sr.ReadToEnd();
            }
            else { MessageBox.Show("There are no donor in this branch"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string j;
            j = Firstpage.path + "\\" + comboBox1.SelectedItem.ToString() + "\\" + "\\Donor\\" + textBox1.Text + ".txt";
            if (File.Exists(j))
            {
                FileStream jj;
                BinaryFormatter jf = new BinaryFormatter();
                jj = File.OpenRead(j);
                d1 = (donor)jf.Deserialize(jj);
                jj.Close();
                if (d1.GRNO == 0)
                { MessageBox.Show("Report generated");
                    d1.GRNO = 1;
                    FileStream f = new FileStream(j, FileMode.Create);
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(f, d1);
                    f.Close(); ;

                }
                else if(d1.GRNO==1)
                {
                    MessageBox.Show("You have already generated the report");
                }

            }
            else
            { MessageBox.Show("Sorry couldnot open the file"); }
        }

        private void generatingreport_Load(object sender, EventArgs e)
        {

        }
    }
}
