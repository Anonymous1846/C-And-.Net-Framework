using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers= 2, j = 0;
            int[] a = new int[10];
            Console.WriteLine("The First 10 Primes Are :");
            while (j<10)
            {
                if (test_prime(numbers))
                {
                    a[j] = numbers;
                    j++;
                }
                numbers++;
            }
            for (int i=0;i<10;i++)
            {
                Console.WriteLine(a[i]);
            }
        }

         static Boolean test_prime(int number)
        {
           
            for (int i=2;i<number;i++)
            
                if (number % i == 0)
                    return false;
            
            return true;
        }
    }
}
          