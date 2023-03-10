using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class malir : multiple, multipleinheritance
    {
       public string password;
       public string username;
        bloodbank obj = new bloodbank();
        head obj1 = new head();


        public malir()
        { setcredential(); }
        public void setcredential()
        {
            password = "admin3";
            username = "admin3";

        }
    }
}
