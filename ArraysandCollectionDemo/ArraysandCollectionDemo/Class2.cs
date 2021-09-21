using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysandCollectionDemo
{
    class Class2
    {
        static void Main()
        {
            List<int> intList = new List<int>();
            intList.Add(20);
            intList.Add(30);
            intList.Add(40);
            //intList.Add("hello");//Error

            foreach (var num in intList)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
