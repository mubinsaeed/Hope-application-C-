using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Ayeshamanziladmin: multiple,multipleinheritance
    { public string password;
      public  string username;
        bloodbank obj = new bloodbank();
        head obj1 = new head();


        public Ayeshamanziladmin()
        { setcredential(); }
        public void setcredential()
        {
            password = "admin1";
            username = "admin1";


        }
    }
}
