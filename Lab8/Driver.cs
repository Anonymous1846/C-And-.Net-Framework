using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Driver
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("***** Labsheet 8 *****");
            do {
                Console.WriteLine("1)Question 1\n2)Question 2\n3)Question 3\n4)Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice) {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 4:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Question Doesn't Exist !");
                        break;
                }
            } while (choice!=4);
            
        }
    }
}
