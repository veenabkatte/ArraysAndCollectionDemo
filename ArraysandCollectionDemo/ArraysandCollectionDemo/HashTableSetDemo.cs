using System;
using System.Collections.Generic;


namespace ArraysandCollectionDemo
{
    class HashTableSetDemo
    {

        static void Main()
        {
            HashSet<int> intHashSet = new HashSet<int>();
            intHashSet.Add(45);
            intHashSet.Add(40);
            intHashSet.Add(45);
            intHashSet.Add(40);

            foreach (var v in intHashSet)
            {
                Console.WriteLine(v);
            }
            Console.ReadLine();
        }
    }
}
