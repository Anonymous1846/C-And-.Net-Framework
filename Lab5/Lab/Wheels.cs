using System;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
    class Wheels
    {
        string[] make=new string[10];
        public string this[int index]
        {
            set
            {
                make[index] = value; 
            }
            get
            {
                return make[index];
            }
        }
    }
}
