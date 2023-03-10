using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{   [Serializable]
   public abstract class branch
    {
        protected string phlebotomistname;
        protected string branchname;   //branch address
        protected float totalbloodinbranch;
        const string username = "admin";
        const string password = "admin";

        public branch(string branchname)
        {
            this.branchname = branchname;
        }
        public branch()
        { }
        public branch(branch b1)
        {
            this.branchname = b1.branchname;
        }
       

        public string Branchname
        {
            get { return branchname; }
            set { branchname = value; }
        }
        public virtual void setphelobotomistname()
        { }
        public void setbranchname()
        {
            branchname = "Hope foundation karachi";

        }
    }
}
