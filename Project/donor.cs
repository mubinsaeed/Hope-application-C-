using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{ [Serializable]
    class donor: user
    {
        //string emailaddress;
        string bloodgroup;
        float amountofblooddonated;
        string username;
        string password;
        int grno;
        public donor()
        {

        }
        public donor(string firstname, string lastname, string gender, string cnic, string cellphone, string useraddress, string username, string password, string branchname) : base(firstname, lastname, gender, cnic, cellphone, useraddress, branchname)
        {
            //this.emailaddress = emailaddress;
            this.username = username;
            this.password = password;
            this.bloodgroup = "*Empty*";
            this.amountofblooddonated = 0;
            this.grno = 0;
        }

        public donor(donor d1): base(d1)
        {
            this.username = d1.username;
            this.password = d1.password;
            this.bloodgroup = "*Empty*";
            this.amountofblooddonated = 0;
            this.grno = 0;
          //  this.emailaddress = d1.emailaddress;
        }

        public string Bloodgroup
        {
            get { return bloodgroup; }
            set { bloodgroup = value; }
        }

        public float Amountofblooddonated
        {
            get { return amountofblooddonated; }
            set { amountofblooddonated = value; }
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
