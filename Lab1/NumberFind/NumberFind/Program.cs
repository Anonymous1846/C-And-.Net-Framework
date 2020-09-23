using System;

namespace NumberFind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Numbers");
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            //Custom Output
            test(a,b,c);
            //testing for a=250,b=85,c=25
            test(250,85,25);
            //test(300, 70, 70);
        }
        public static void test(int a,int b,int c)
        {
            int x = a /( b - c);
            Console.WriteLine("The Answer is :{0}",x);
        }
    }
}
