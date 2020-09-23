using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Numerics;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            String number = "";
            Console.WriteLine("Enter The Number !");
            long  a = Convert.ToInt32(Console.ReadLine());
            while (a!=0)
            {
                long num = a % 10;
                number += Convert.ToChar(num)+" ";
                Console.Write(number);
                a /= 10;
            }
        }
    }
}
