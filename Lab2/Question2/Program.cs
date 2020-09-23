using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Marks of 10 Students !");
            int[] students = new int[10];
            int[] category = { 0,0,0,0,0,0,0,0,0,0};
            for (int i=0;i<10;i++)
            {
                students[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i=0;i<students.Length;i++)
            {
                if (students[i] < 10 && students[i] >= 0)
                {
                    category[0]++;
                }
                else if (students[i] >= 10 && students[i] < 20)
                {
                    category[1]++;
                }
                else if (students[i] >=20 && students[i] < 30)
                {
                    category[2]++;
                }
                else if (students[i] >=30 && students[i] < 40)
                {
                    category[3]++;
                }
                else if (students[i] >= 40 && students[i] < 50)
                {
                    category[4]++;
                }
                else if (students[i] >= 50 && students[i] < 60)
                {
                    category[5]++;
                }
                else if (students[i] >= 60 && students[i] < 70)
                {
                    category[6]++;
                }
                else if (students[i] >= 70 && students[i] < 80)
                {
                    category[7]++;
                }
                else if (students[i] >= 80 && students[i] < 90)
                {
                    category[8]++;
                }
                else if (students[i] >= 90 && students[i] <= 100)
                {
                    category[9]++;
                }
            }
            Console.WriteLine("There are {0} students in group 0-10",category[0]);
            Console.WriteLine("There are {0} students in group 10-20", category[1]);
            Console.WriteLine("There are {0} students in group 20-30", category[2]);
            Console.WriteLine("There are {0} students in group 30-40", category[3]);
            Console.WriteLine("There are {0} students in group 40-50", category[4]);
            Console.WriteLine("There are {0} students in group 50-60", category[5]);
            Console.WriteLine("There are {0} students in group 60-70", category[6]);
            Console.WriteLine("There are {0} students in group 70-80", category[7]);
            Console.WriteLine("There are {0} students in group 80-90", category[8]);
            Console.WriteLine("There are {0} students in group 90-100", category[9]);
            
        }
        } 
    }

