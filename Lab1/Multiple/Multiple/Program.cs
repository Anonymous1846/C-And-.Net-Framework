using System;

namespace Multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Two Numbers !");
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a % b == 0)
            {
                Console.WriteLine("Yes {0} is a multiple of {1} ", a, b);
            }
            else
            {
                Console.WriteLine("{0} is not a multiple of {1}",a,b);
            }
        }
    }
}
