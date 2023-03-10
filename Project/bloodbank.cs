using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{  interface multipleinheritance
    { }
    class bloodbank : multipleinheritance
    {
        protected float totalbloodinall;
        protected int noofdonor;
        public bloodbank()
            {}
        public bloodbank(float totalbloodinall, int noofdonor)
        {
            this.totalbloodinall = totalbloodinall;
            this.noofdonor = noofdonor;
        }

        public float Totalbloodinall
        {
            get { return totalbloodinall; }
            set { totalbloodinall = value; }
        }

        public int Noofdonor
        {
            get { return noofdonor; }
            set { noofdonor = value; }
        }
    }
}
