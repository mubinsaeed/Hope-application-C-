using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{  interface multiple
    { }
    class head:multiple
    { protected string username;
        protected string password;
        public head()
        {
            setusername();
            setpassword();
        }
        public void setusername()
        {
            username = "head";

        }
        public  void setpassword()
        {
            password = "head";
        }

    }
}
