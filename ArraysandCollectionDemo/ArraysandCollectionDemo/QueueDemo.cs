using System;
using System.Collections;


namespace ArraysandCollectionDemo
{
    class QueueDemo
    {
        static void Main()
        {
            Queue queue = new Queue();
            queue.Enqueue(1001);
            queue.Enqueue(1002);
            queue.Enqueue(1003);
            queue.Enqueue(1004);
            queue.Enqueue(1005);

            Console.WriteLine($"Count is:{queue.Count}");
            foreach (var v in queue)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine($"After removing an element:{queue.Dequeue()}");

            foreach (var v in queue)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine($"next element to be removed is:{queue.Peek()}");
            foreach (var v in queue)
            {
                Console.WriteLine(v);
            }

            queue.Clear();
            Console.ReadLine();
        }
    }
}
