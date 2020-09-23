using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
    class CollectionsTest
    {
        ArrayList arrayList;
        Hashtable hashtable;
        Stack stack;
        Queue queue;
        BitArray bitArray;

        public void ArrayListTest()
        {
            arrayList = new ArrayList();
            arrayList.Add("Ducati Panigale V4");
            arrayList.Add("Royal Enfield Bullet 350 STD");
            arrayList.Add("MV Augusta F3800");
            arrayList.Add("Yamaha R6");
            Console.WriteLine("Bike Collections:");
            foreach(var x in arrayList){
                Console.WriteLine(x);
            }
            arrayList.RemoveAt(0);
            arrayList.Add("Harley Davidson Iron 883");
            Console.WriteLine("After Removing 1st Bike and then Adding Harley");
            foreach (var x in arrayList)
            {
                Console.WriteLine(x);
            }

        }
        public void StackTest()
        {
            
            stack = new Stack();
            stack.Push("Yamaha RX100");
            stack.Push("Yamaha RD350");
            stack.Push("Tata Sierra");
            stack.Push("Aston Martin DB9");
            stack.Push("Rolls Royce Phantom VIII");
            Console.WriteLine("Recently Sold :{0}",stack.Pop());
            Console.WriteLine("Recently Purchased :{0}",stack.Peek());

        }
        public void QueueTest()
        {
            queue = new Queue();
            queue.Enqueue("Aston Martin DB9");
            queue.Enqueue("Honda CBR1000RR");
            queue.Enqueue("Huqsvarna Vitpilan");
            queue.Enqueue("Rolls Royce Ghost");
            Console.WriteLine(queue.Dequeue()+" was My First Car !");
        }
        public void HashTableTest()
        {
            hashtable = new Hashtable();
            hashtable.Add("NY19077","Aston Martin DB9");
            hashtable.Add("KL31007", "Aston Martin Vanquish" );
            hashtable.Add("SA1900", "Rolls Royce Ghost");
            hashtable.Add("ML1909", "Ducati Panigale V4");
            Console.WriteLine("Enter The Vehicle Number ");
            String number = Console.ReadLine();
            if (hashtable.ContainsKey(number))
            {
                Console.WriteLine("Yes We have The Vehicle!,The Total Vehicles are {0}", hashtable.Count);
               
            }
            else
            {
                Console.WriteLine("No Such Vehicle Registered");
            }
        }
        public void BitArrayTest()
        {
            bitArray= new BitArray(5);
            bitArray[0]=true;
            bitArray[1] = true;
            bitArray[2] = false;
            bitArray[3] = false;
            bitArray[4] = true;
            int num = 1;
            foreach (object i in bitArray)
            {
                Console.WriteLine($"The Answer to Question {num} is {i}");
                num++;
            }
        }
    }
}
