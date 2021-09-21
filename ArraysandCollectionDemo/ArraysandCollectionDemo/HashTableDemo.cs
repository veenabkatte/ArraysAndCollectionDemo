using System;
using System.Collections;


namespace ArraysandCollectionDemo
{
    class HashTableDemo
    {
        static void Main()
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Add("MH", 27);
            hashtable.Add("GJ", 24);
            hashtable.Add("DL", 12);
            hashtable.Add("TL", 29);
            hashtable.Add("KA", 37);
            Console.WriteLine($"Count is:{hashtable.Count}");
            Console.WriteLine($"GST State Code for Maharashtra is:{hashtable["MH"]}");

            hashtable["GJ"] = 30;
            Console.WriteLine($"GST State Code for Gujarat is:{hashtable["GJ"]}");

            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine($"Key={key} and Value is={hashtable[key]}");
            }

            hashtable.Remove("DL");
            Console.WriteLine("After removing DL");
            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine($"Key={key} and Value is={hashtable[key]}");
            }

            SortedList sortedList = new SortedList();
            sortedList.Add("MH", 27);
            sortedList.Add("GJ", 24);
            sortedList.Add("DL", 12);
            sortedList.Add("TL", 29);
            sortedList.Add("KA", 37);

            Console.WriteLine("Sorted List:");
            Console.WriteLine($"Count is:{sortedList.Count}");
            foreach (var key in sortedList.Keys)
            {

                Console.WriteLine($"Key={key} and Value is={sortedList[key]}");
            }

            Console.ReadLine();
        }
    }
}
