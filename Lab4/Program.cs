using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the driver program to execute all the programs
            //switch case will be used for question-numbered Access
            Console.WriteLine("Question 1\nQuestion 2\nQuestion 3\nQuestion 4\nQuestion 5");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Quadratic quadratic = new Quadratic();
                    Console.WriteLine("Enter The Equation In the form ax^2+bx+c");
                    double []a = new double[3];
                    for (int i=0;i<a.Length;i++)
                    {
                        a[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    quadratic.setVal(a[0],a[1],a[2]);
                    quadratic.pos_root_of_quadratic();
                    quadratic.neg_root_of_quadratic();
                    Console.WriteLine("The Root of ({0})x^2+({1})x+{2} is {3} and {4}",quadratic.sq_r(),quadratic.s_r(),quadratic.z_r(),quadratic.neg_root_of_quadratic(),quadratic.pos_root_of_quadratic());
                    break;
                case 2:
                    Student student = new Student();
                    student.Age = 27;
                    student.Name = "Tyler Durden";
                    student.Code = 111;
                    Console.WriteLine("Hello Mr. {0},You are {1} years old and Your code is {2}, right ?",student.Name,student.Age,student.Code);
                    break;
                case 3:
                    Students students = new Students("Dwanye Johnson", "Princton", "therock@gmail.com",3339996666);
                    Console.Write(students.return_info());
                    Students students1 = new Students("Jason Stanthom", "Automobile Engg", "Fluid Mechanics", "Yale University", "jasonstanthom@gmail.com", 998900100);
                    Console.Write(students1.return_info());
                    break;
                case 4:
                    Electricity electricity = new Electricity();
                    Console.WriteLine("Enter The Customer name !");
                    String consumer_name = Console.ReadLine();
                    electricity.setConsumer(consumer_name);
                    Console.WriteLine("Enter The Electricity Usage in Units.");
                    double units = Convert.ToDouble(Console.ReadLine());
                    electricity.set_Usage(units);
                    electricity.showBill();
                    break;
                case 5:
                    Voting voting = new Voting();
                    voting.count_votes();
                    voting.ShowResults();
                break;
                default:
                    Console.WriteLine("Invalid Question Entered !");
                break;
            }
        }
    }
}
