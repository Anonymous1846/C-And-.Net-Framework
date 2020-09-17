using System;
using System.Collections.Specialized;
using System.Threading;

namespace Lab3
{
    class ClassTime{
        public static  int count;
        public ClassTime()
        {
            count++;
        }
       
        public void  GetCount()
        {
            Console.WriteLine("Number of Instances :"+count);
        }
        ~ClassTime()
        {
            Console.WriteLine("Destroyed");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
           
            Console.WriteLine("1)Question 1\n2)Qeustion 2\n3)Question 3\n4)Qeustion 4\n5)Question 5");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ClassTime classTime = new ClassTime();
                    ClassTime classTime1 = new ClassTime();
                    classTime.GetCount();
                    break;
                case 2:
                    Time time = new Time();
                    int hour =10,sec = 60, min=61;
                    int hours = 10, seconds = 60, minutes = 61;
                    time.SetTime( hour, out min, ref sec);
                    Console.WriteLine("Three Refs Used {0}",time.getTime());
                    time.SetTimeAgain(ref hours, ref minutes, ref seconds);
                    Console.WriteLine("Using Ref and Out {0}",time.getTime());
                break;
                case 3:
                    Console.WriteLine("Number of Addressses");
                    int number = Convert.ToInt32(Console.ReadLine());
                    String[] address = new string[number];
                    for (int i=0;i<number;i++)
                    {
                        address[i] = Console.ReadLine();
                    }
                    Params params_test = new Params();
                    params_test.setAddress(address);
                break;
                case 4:
                    call_question_four();
                    break;
                case 5:
                   
                    call_question_five();
                    break;
                default:
                    Console.WriteLine("Selected Question Number Doesn't Exist !!!");
                 break;
            }
           
        }

        private static void call_question_four()
        {
            Number num = new Number();
            int a = 12, b = 90;
            num.add(ref a, ref b);
            num.showResult();
            num.sub(ref a, ref b);
            num.showResult();
            num.mul(ref a, ref b);
            num.showResult();
            num.div(ref a, ref b);
            num.showResult();
        }

        private static void call_question_five()
        {
            Flower rose = new Flower(), orchid = new Flower(), jasmine = new Flower();
            jasmine.__init__();
            orchid.__init__();
            rose.__init__();
            jasmine.setFlowerName("Jasmine");
            jasmine.setPrice(100.50);
            jasmine.setStock(40);
            rose.setFlowerName("Rose");
            rose.setPrice(200.50);
            rose.setStock(25);
            orchid.setFlowerName("Orchid");
            orchid.setPrice(150.50);
            orchid.setStock(15);
            Flower flower_to_buy = new Flower();
            Console.WriteLine("Enter Flower name ");
            String name = Console.ReadLine();
            flower_to_buy.setFlowerName(name);
            Console.WriteLine("Enter The Quantity !");
            double qty = Convert.ToInt32(Console.ReadLine());
            flower_to_buy.setStock(qty);

            if (string.Equals(flower_to_buy.getFlowerName(), "Orchid", StringComparison.OrdinalIgnoreCase))
            {
                orchid.sell_flower(flower_to_buy.getStock());
            }
            else if (string.Equals(flower_to_buy.getFlowerName(), "Jasmine", StringComparison.OrdinalIgnoreCase))
            {
                jasmine.sell_flower(flower_to_buy.getStock());
            }
            else if (string.Equals(flower_to_buy.getFlowerName(), "Rose", StringComparison.OrdinalIgnoreCase))
            {
                rose.sell_flower(flower_to_buy.getStock());
            }
        }
    }
}
