using System;

namespace Question7
{
    class Program
    {
        static void change(Class1 class1)
        {
            class1.SomeData = 200;
            Console.WriteLine("Changed: "+class1.SomeData);
        }
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Class1 class2 = new Class1();
            class2 = class1;
            Console.WriteLine("Second Variable Assigned :"+class2.SomeData);
            change(class2);
            Console.WriteLine("First Variable:");
            Console.WriteLine("Original :"+class1.SomeData);
            change(class1);
        }
    }
}
