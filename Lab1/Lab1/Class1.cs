using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Class1
    {
        static void main(String[] args)
        {
            Console.WriteLine("Enter The Numbers !");
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Sum is :{0}",a+b);
            Console.WriteLine("The Product is :{0}",a*b);
            Console.WriteLine("The Difference :{0}", a - b);
            Console.WriteLine("The Quotient is :{0}",a / b);
        }
       
    }
}
