using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Number
    {
        
        int result;
       
        public void showResult()
        {
            Console.WriteLine("The Answer is {0}",result);
        }
        public void add(ref int first,ref int second)
        {
            result = first + second;
        }
        public void sub(ref int first, ref int second)
        {
            result = first - second;
        }
        public void mul(ref int first, ref int second)
        {
            result = first * second;
        }
        public void div(ref int first, ref int second)
        {
            result = first / second;
        }
    }
}
