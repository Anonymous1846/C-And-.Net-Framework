using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Bank
    {
         int person;
        public Bank()
        {
            person = 0;
        }
        public Bank(int curr)
        {
            person = curr;
        }
        public static Bank operator ++(Bank p)
        {
            //Post Increment Operator !
            p.person++;
            return p;
        }
        public static Bank operator --(Bank p)
        {
            //Post Decrement Operator !
            p.person--;
            return p;
        }
       
        public int getCount()
        {
            return person;
        }
       
        public void Test()
        {
            //This Function is used to Test The Class !
            int action;
            //We initialized the Number of People in the bank as 10 People !
            Bank p1 = new Bank(10);
            do {
                

                Console.WriteLine("1)Add Person\n2)Remove Person\n3)Count\n4)Exit");
                action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        p1++;
                        break;
                    case 2:
                        p1--;
                        break;
                    case 3:
                        Console.WriteLine($"We Have {p1.getCount()} People !");
                        break;
                    case 4:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Sorry Something Went Wrong !");
                        break;
                }
                } while (action!=4);
            }
    }
}
