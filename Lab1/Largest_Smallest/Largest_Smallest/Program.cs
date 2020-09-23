using System;

namespace Largest_Smallest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            Console.WriteLine("Enter Five Numbers !");
            for (int num= 0;num < numbers.Length;num++)
            {
                numbers[num] = Convert.ToInt32(Console.ReadLine());
            }
            int large = numbers[0];
            int small = numbers[0];
            for (int i=1;i<numbers.Length;i++)
            {
                if (numbers[i]>large)
                {
                    large = numbers[i];
                }
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] <small)
                {
                    small = numbers[i];
                }
            }
            Console.WriteLine("The Largest is {0} and Smallest is {1}",large,small);
        }
    }
}
