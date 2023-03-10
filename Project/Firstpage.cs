using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    public partial class Firstpage : Form
    {
     public  static string path;
        
        public Firstpage()
        {
            InitializeComponent();
            createfolder();
        }

        private void next_Click(object sender, EventArgs e)
        {
            //this.Hide();
            secondpage form1 = new secondpage();
            form1.Show();
            this.Hide();
        }

        private void Firstpage_Load(object sender, EventArgs e)
        {

        }
        void createfolder()
        {
            path = Application.StartupPath + "Bloodbank" ;
            DirectoryInfo dir = new DirectoryInfo(path);
            dir.Create();
            dir.CreateSubdirectory("AyeshaManzil branch"+"\\Donor\\");
            dir.CreateSubdirectory("AyeshaManzil branch" + "\\Patient\\");
            dir.CreateSubdirectory("Clifton branch"+"\\Donor\\");
            dir.CreateSubdirectory("Clifton branch" + "\\Patient\\");
            dir.CreateSubdirectory("Malir Branch"+"\\Donor\\");
            dir.CreateSubdirectory("Malir Branch" + "\\Patient\\");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
