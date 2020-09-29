using System;

namespace Lab6_Inheritance_And_Polymorphism_
{
    class Driver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Lab 6*****");
            //Console.ForegroundColor = ConsoleColor.Green;
           
            int choice;
            do {
                Console.ForegroundColor = ConsoleColor.White;
            
                Console.WriteLine("1)Box Problem\n2)Employees\n3)Shapes");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Box box = new Box(12, 12, 12);
                        Box box1 = new Box(12, 12, 12);
                        //If The Box Objects are equals then they Show both are Equals according to Terinery Operator!
                        Console.WriteLine(box.equals(box1) ? "The Two Boxes are Equals !" : "The Two Boxes Aren't Equal !");
                        Console.WriteLine("Box One Info !");
                        box.displayInfo();
                        Console.WriteLine("Box Two Info !");
                        box1.displayInfo();
                        break;
                    case 2:
                        Employee employee = new Employee();
                        //Fucntion Used to Test The Employees Manegaemnt System!
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
                        //The Elements are strore in a Drawing Object arrays which is the base class to other classes(line,circle,and Square)
                        foreach (Drawing drawing1 in drawings)
                        {
                            drawing1.draw();
                        }
                        break;
                    case 4:
                        System.Environment.Exit(0);
                        break;
                    default:
                        //Color Set For Error Red
                          Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Question !");
                        break;
                }
            } while (choice!=4);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
