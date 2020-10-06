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
                Console.WriteLine("1)Question1\n2)Question2)\nExit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    default:
                        break:
                }
            } while (choice!=5);
        }
    }
}
