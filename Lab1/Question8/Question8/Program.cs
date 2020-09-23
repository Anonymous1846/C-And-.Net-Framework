using System;
using System.Collections;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Number :");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (a != 0)
            {
                int num = a % 10;
                if (num %2 != 0)
                {
                    sum += num;
                }
                a /= 10;
            }
            Console.WriteLine("The Sum is :{0}",sum);
        }
    }
}
