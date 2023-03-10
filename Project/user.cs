using System;
using System.Collections.Generic;
using System.Text;
namespace Project
{   [Serializable]
    class user: branch
    {
        protected string firstname;
        protected string lastname;
        protected string gender;
        protected string cnic;
        protected string cellphone;
        protected string useraddress;
        protected string userfile_path;
        public user()
        { }
        public user(string firstname, string lastname, string gender, string cnic, string cellphone, string useraddress, string branchname): base(branchname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.cnic = cnic;
            this.cellphone = cellphone;
            this.useraddress = useraddress;
        }

        public user(user u1): base(u1)
        {
            this.firstname = u1.firstname;
            this.lastname = u1.lastname;
            this.gender = u1.gender;
            this.cnic = u1.cnic;
            this.cellphone = u1.cellphone;
            this.useraddress = u1.useraddress;
        }
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Cnic
        {
            get { return cnic; }
            set { cnic = value; }
        }
        public string Cellphone
        {
            get { return cellphone; }
            set { cellphone = value; }
        }

        public string UserAddress
        {
            get { return useraddress; }
            set { useraddress = value; }
        }

        public string Filepath
        {
            get { return userfile_path; }
        }
        public override void setphelobotomistname()
        {
            phlebotomistname = "Asif";
        }
        public void setbranchname()
        {
            branchname = "Ayeshamanzil,clifton,malir branches";

        }
    }
}
