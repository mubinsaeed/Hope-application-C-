using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{   [Serializable]
    class inventory
    {
      public  float Apos ;
        public float Aneg ;
        public float Bpos ;
        public float Bneg ;
        public float ABpos;
        public float ABneg;
        public float Opos;
        public float Oneg;
        public inventory()
        { }
        public static inventory operator +(inventory k, inventory j)
        {
            inventory temp = new inventory();
            temp.Apos = k.Apos + j.Apos;
            temp.Aneg = k.Aneg + j.Aneg;
            temp.Bpos = k.Bpos + j.Bpos;
            temp.Bneg = k.Bneg + j.Bneg;
            temp.ABpos = k.ABpos + j.ABpos;
            temp.ABneg = k.ABneg + j.ABneg;
            temp.Opos = k.Opos + j.Opos;
            temp.Oneg = k.Oneg + j.Oneg;

            return temp;
        }
        public static inventory operator -(inventory k, inventory j)
        {
            inventory temp = new inventory();
            temp.Apos = k.Apos - j.Apos;
            temp.Aneg = k.Aneg - j.Aneg;
            temp.Bpos = k.Bpos - j.Bpos;
            temp.Bneg = k.Bneg - j.Bneg;
            temp.ABpos = k.ABpos - j.ABpos;
            temp.ABneg = k.ABneg - j.ABneg;
            temp.Opos = k.Opos - j.Opos;
            temp.Oneg = k.Oneg - j.Oneg;
            if (temp.Apos < 0)
                temp.Apos = 0;
            if (temp.Aneg < 0)
                temp.Aneg = 0;
            if (temp.Bpos < 0)
                temp.Bpos = 0;
            if (temp.Bneg < 0)
                temp.Bneg = 0;
            if (temp.ABpos < 0)
                temp.ABpos = 0;
            if (temp.ABneg < 0)
                temp.ABneg = 0;
            if (temp.Opos < 0)
                temp.Opos = 0;
            if (temp.Oneg < 0)
                temp.Oneg = 0;
            return temp;
        }



    }
}
