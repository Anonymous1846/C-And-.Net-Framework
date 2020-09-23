using System;

namespace Radius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Radius !");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Diameter :{0}",radius*2);
            Double pi = 3.14159;
            Console.WriteLine("Area :{0}", 2*radius*pi);
            Console.WriteLine("Circumference :{0}", Math.Pow(radius,2)*pi);
        }
    }
}
