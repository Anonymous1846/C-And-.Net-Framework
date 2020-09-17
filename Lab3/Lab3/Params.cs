using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Params
    {
        
        public void setAddress(params string[] str)
        {
            Console.WriteLine("Setted Addresses:");
            foreach (String address in str)
            {
                Console.WriteLine(address);
            }
        }
    }
}
