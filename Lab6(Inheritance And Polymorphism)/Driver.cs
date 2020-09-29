using System;

namespace Lab6_Inheritance_And_Polymorphism_
{
    class Driver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Lab 6*****");
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1)Box Problem\n2)Employees\n3)Shapes");
           // Console.ForegroundColor = ConsoleColor.Black;
            int choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Box box = new Box(1,12,13);
                    Box box1 = new Box(12,12,12);
                    Console.WriteLine(box.equals(box1)?"The Two Boxes are Equals !":"They Aren't Equal !");
                    Console.WriteLine("Box One Info !");
                    box.displayInfo();
                    break;
                case 2:
                    Employee employee = new Employee();
                    employee.testTheService();
                    break;
                case 3:
                   Drawing[] drawings = new Drawing[4];
                    Circle circle = new Circle();
                    Square square = new Square();
                    Line line = new Line();
                    Drawing drawing = new Drawing();
                    drawings[0] = line;
                    drawings[1] = circle;
                    drawings[2] = square;
                    drawings[3] = drawing;
                    foreach (Drawing drawing1 in drawings)
                    {
                        drawing1.draw();
                    }
                    break;
                default:
                  //  Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Question !");
                    break;
            }
           // Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
