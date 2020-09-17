using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2,2];
            int[,] b = new int[2,2];
            Console.WriteLine("Enter The Matrix A");
            for (int i=0;i<2;i++)
            {
                for (int j = 0; j <2; j ++)
                {
                    a[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter The Matrix B");
            for (int i = 0; i <2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    b[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The Sum :");
            sum(a,b);
            Console.WriteLine("The Difference :");
            diff(a,b);
            Console.WriteLine("The Product :");
            multiply(a, b);
        }
        static void multiply(int[,] a, int[,] b)
        {
            int[,] prdt = new int[2,2];
            for (int i=0;i<2;i++)
            {
                
                for (int j = 0; j < 2; j++)
                {
                    prdt[i, j] = 0;
                    for (int z=0;z<2;z++)
                    {
                        prdt[i, j] +=a[i,z]*b[z,j];
                    }
                }
            }
            show(prdt);
        }
        static void show(int [,]a)
        {
            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 2; j++)
                {
                    Console.Write(a[i, j]+" ");
                } 
                Console.WriteLine();
            }
        }
        static void sum(int[,] a,int [,]b)
        {
            int[,] sum = new int[2,2];
            for (int i=0;i<2;i++)
            {
                for (int j=0;j<2;j++)
                {
                    sum[i,j] = a[i,j] + b[i,j];
                    Console.Write(sum[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        static void diff(int[,] a, int[,] b)
        {
            int[,] diff = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    diff[i, j] = a[i, j] - b[i, j];
                    Console.Write(diff[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
