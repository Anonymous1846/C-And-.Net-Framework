using System;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {11,111,11,22,23};
            int sum = 0;
            foreach(int num in numbers)
            {
                sum += num;
            }
            int pos = 0;
            int avg = sum / numbers.Length;
            int smallest_nearest = Math.Abs(avg-numbers[0]);
            int nearer = numbers[0];
            for (int i=1;i<numbers.Length;i++)
            {
                if (smallest_nearest>Math.Abs(avg-numbers[i]))
                { 
                    nearer = numbers[i];
                    pos = i;
                }
            }
            if (avg == nearer)
            {
                Console.WriteLine("The Averge is {0} is Equal to {1} at position {2}", avg, nearer,pos);
            }
            else
            {
                //Starting from zero !!
                Console.WriteLine("The Averge is {0} and {1} nearest to it at position {2}!", avg, nearer,pos);
            }
        }
    }
}
