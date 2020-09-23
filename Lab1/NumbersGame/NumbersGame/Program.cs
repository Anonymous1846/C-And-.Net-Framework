using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input three different integers: ");
           //Enter the data in the format of the question
            String data = Console.ReadLine();
            String[] elements = data.Split();
            int a, b, c;
            a = Convert.ToInt32(elements[0]);
            b = Convert.ToInt32(elements[1]);
            c = Convert.ToInt32(elements[2]);
            Console.WriteLine("The Sum :{0}",sum(a,b,c));
            Console.WriteLine("The Average :{0}",avg(a,b,c));
            Console.WriteLine("The Product :{0}",Mul(a,b,c));
            Console.WriteLine("The Smallest is: {0}",small(a,b,c));
            Console.WriteLine("The Laregst  is: {0}", largest(a, b, c));
        }
        public static int sum(int a,int b,int c)
        {
            return a + b + c;
        }
        public static int avg(int a, int b, int c)
        {

            return sum(a, b, c) / 3;
        }
        public static int Mul(int a, int b, int c)
        {
            return a * b * c;
        }
        public static int largest(int a, int b, int c)
        {
           int  largest = a;
            if (b>c)
            {
                if(b>a){
                    largest = b;
                }
                else
                {
                    largest = a;
                }
            }
            else
            {
                largest = c;
            }
            return largest;
        }
        public static int small(int a, int b, int c)
        {
            int small = a;
            if (a>b)
            {
                if (b>c)
                {
                    small = c;
                }
                else
                {
                    small = b;
                }
            }
            else
            {
                small = a;
            }
            return small;
        }
    }
}
