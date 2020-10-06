using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Driver
    {
        /*The Driver Class to call the other classes.
         Individual Classes contains individual questions !*/
        static void Main(string[] args)
        {
            int choice;
            do {
                Console.WriteLine("1)Question 1\n2)Question 2\n3)Question 3\n4)Question 4\n5)Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Bank person = new Bank();
                        person.Test();
                        break;
                    case 2:
                        Matrix matrix = new Matrix();
                        matrix.Test();
                        break;
                    case 3:
                        break;
                    case 4:
                        Time times = new Time();
                        times.Test();
                        break;
                    default:
                        Console.WriteLine("The Question Doesn't Exist !");
                        break;
                }
            } while (choice!=5);
        }
    }
}
