using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter the numbers");
            int i=0, counter_for_zero=0,counter_for_plus=0, counter_for_nega=0;
            while (i!=-1)
            {
                i = Convert.ToInt32(Console.ReadLine());
                if (i==0)
                {
                    counter_for_zero++;
                }
                else if (i>0)
                {
                    counter_for_plus++;
                }
                else if(i<0 && i!=-1)
                {
                    counter_for_nega++;
                }
            }
            Console.WriteLine("Zeros:{0},Positives:{1},Negatives:{2}",counter_for_zero,counter_for_plus,counter_for_nega);
        }
    }
}
