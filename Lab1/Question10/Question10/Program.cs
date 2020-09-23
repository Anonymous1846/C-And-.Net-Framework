using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            int []a = {2,3,11,0,19,13,12,98,78,-9,10,100,90,89,-99,100,90,-99,-77,10};
            int temp;
            for (int j = 0; j <= a.Length - 2; j++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        temp = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = temp;
                    }
                }
            }
            int[] small = new int[10];
            int[] large = new int[10];
            Console.WriteLine("Sorted :");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            for (int i = 0; i < 10; i++)
            {
                small[i] = a[i];
             }
            for (int i=10,j=0;i<a.Length;i++,j++)
            {
                large[j]= a[i];
            }
            Console.WriteLine("\nSmall Sorted :");
            foreach (int i in small)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\nLarge Sorted :");
            foreach (int i in large)
            {
                Console.Write(i + " ");
            }

        }
    }
}
