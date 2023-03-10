using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{  [Serializable]
    class patient: user
    {
        string username;
        string password;
        int grno;
       public float bloodrequired;
      public  string bloodtype;
        public patient()
        { }
        public patient(string firstname, string lastname, string gender, string cnic, string cellphone, string useraddress, string username, string password, string branchname) : base(firstname, lastname, gender, cnic, cellphone, useraddress, branchname)
        {
            this.username = username;
            this.password = password;
            this.grno = 0;
           // userfile_path = @"C:\Users\Muhammad Fahad\Desktop\OOP Project\Project1.4\Project1\Bloodbank\Branches\" + Branchname + "\\Patient\\" + Username + ".txt";
        }

        public patient(patient p1) : base(p1)
        {
            this.username = p1.username;
            this.password = p1.password;
            this.grno = 0;
          //  userfile_path = @"C:\Users\Muhammad Fahad\Desktop\OOP Project\Project1.4\Project1\Bloodbank\Branches\" + Branchname + "\\Patient\\" + Username + ".txt";
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        
        public int GRNO
        {
            get { return grno; }
            set { grno = value; }
        }
    }
}
