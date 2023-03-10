using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class cliftonadmin : multiple, multipleinheritance
    {
       public string password;
      public  string username;
        bloodbank obj = new bloodbank();
        head obj1 = new head();


        public cliftonadmin()
        {
            setcredential();
        }
        public void setcredential()
        {
            password = "admin2";
            username = "admin2";

        }
    }
}