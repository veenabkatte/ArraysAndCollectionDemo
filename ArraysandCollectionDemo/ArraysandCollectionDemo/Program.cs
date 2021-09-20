using System;

namespace ArraysandCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numsArray = {10,20,30,40,50 };
            //int[] numsArray = new int[] { 10, 20, 30, 40, 50 };
            int[] numsArray = new int[5];

            Console.WriteLine("Please enter 5 elements:");
            for (int i = 0; i <= 4; i++)
            {
                numsArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"numsArray[0]={numsArray[0]}");

            Console.WriteLine($"Length of numsArray is:{numsArray.Length}");
            foreach (var num in numsArray)
            {

                Console.Write($"{num}\t");
            }
            Console.WriteLine();
            Console.WriteLine("====================================================");

            string[] strArray = { "string1", "string2", "string3", "string4", "string5" };
            strArray[0] = "New String1";
            Console.WriteLine($"strArray[0]={strArray[0]}");

            Console.WriteLine($"Length of strArray is:{strArray.Length}");
            foreach (var str in strArray)
            {

                Console.Write($"{str}\t");
            }
            Console.ReadLine();
        }
    }
}
