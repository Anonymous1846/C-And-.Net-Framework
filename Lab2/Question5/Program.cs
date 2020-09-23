using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] questions = new int[5][];
            questions[0] =new int[]{ 1,2,9};
            questions[1] = new int[] { 1, 2, 10 };
            questions[2] = new int[] { 1, 2, 3,2,5,10 };
            questions[3] = new int[] { 1, 2, 3,4,5,6,7,10 };
            questions[4] = new int[] { 1, 2, 3, 2, 5,7,8,9, 10 };
            Console.WriteLine("*******Quiz Results*******");
            Console.WriteLine("1)Details of All Students\n2)Show Individual Details");
            
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    for (int i=0; i<questions.Length;i++)
                    {
                        Console.WriteLine("Roll Number {0} attended {1} Questions.",+1+i,questions[i].Length);
                    }
                break;
                case 2:
                    Console.WriteLine("RollNumber :");
                    int roll = Convert.ToInt32(Console.ReadLine())-1;
                    if (roll>4)
                    {
                        Console.WriteLine("Only Five Students !");
                    }
                    else
                    {
                        Console.WriteLine("Roll Number {0} Answered The Following Questions",roll+1);
                        for (int i=0;i<questions[roll].Length;i++)
                        {
                            Console.WriteLine(questions[roll][i]);
                        }
                    }
                break;
                default:
                    Console.WriteLine("Wrong Selection !");
                    break;
            }

            
        }
    }
}
