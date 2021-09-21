using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArraysandCollectionDemo
{
    class Class1
    {
        static void Main()
        {
          Stack p=new Stack();
            p.Push(10);
            p.Push(11);
            p.Push(12);
            p.Push(13);
            p.Push(14);

            Console.WriteLine($"count is:{p.Count}");
            foreach(var v in p)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine($"After removing an element:{p.Pop()}");

            foreach(var v in p)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine($"After removing an element:{p.Pop()}");
            foreach(var v in p)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine($"next element to remove is:{p.Peek()}");
            foreach(var v in p)
            {
                Console.WriteLine(v);
            }

        }
    }
}
