using System;
using System.Collections;

namespace Lab
{
    class DriverClass
    {

        static void Main(string[] args)
        {
            Console.WriteLine("1)Bank Trial\n2)Indexers\n3)Collections");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Bank bank = new Bank();
                    bank.TestBank();
                    break;
                case 2:
                    Wheels wheels = new Wheels();
                    wheels[0] = "Ferrari";
                    wheels[1] = "Royal Enfield";
                    wheels[2] = "Ferrari";
                    wheels[3]="Rolls Royce";
                    Console.WriteLine($"The First Vehicle is {wheels[0]}");
                    Console.WriteLine($"The Second Vehicle is {wheels[1]}");
                    Console.WriteLine($"The Third Vehicle is {wheels[2]}");
                    Console.WriteLine($"The Fourth Vehicle is {wheels[3]}");
                    break;
                case 3:
                    int my_choice;
                    CollectionsTest collectionsTest = new CollectionsTest();
                    do
                    {
                        Console.WriteLine("1)Stack\n2)Queue\n3)HashTable\n4)BitArray\n5)ArrayList\n6)Exit");
                        my_choice = Convert.ToInt32(Console.ReadLine());
                        switch (my_choice)
                        {
                            case 1:
                                collectionsTest.StackTest();
                                break;
                            case 2:
                                collectionsTest.QueueTest();
                                break;
                            case 3:
                                collectionsTest.HashTableTest();
                                break;
                            case 4:
                                collectionsTest.BitArrayTest();
                                break;
                            case 5:
                                collectionsTest.ArrayListTest();
                                break;
                            default:
                                System.Environment.Exit(0);
                                break;

                        }
                    } while (my_choice != 6);
                    break;
                default:
                    Console.WriteLine("Invalid Question");
                    break;
            }
        }
       
    }
}
