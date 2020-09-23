using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers ?");
            int a = Convert.ToInt32(Console.ReadLine());
            int b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Sum Is {0}",a+b);
            Console.WriteLine("The Difference Is {0}", a - b);
            Console.WriteLine("The Quotient Is {0}", a / b);
            Console.WriteLine("The Product Is {0}", a * b);
        }
    }
}
