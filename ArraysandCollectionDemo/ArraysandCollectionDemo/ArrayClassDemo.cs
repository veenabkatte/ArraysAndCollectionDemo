using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysandCollectionDemo
{
    class ArrayClassDemo
    {
        static void Main()
        {

            int[] numsArray = { 34, 22, 11, 56, 89 };
            int[] dumsArray = new int[5];
            int[,] numsArray1 = new int[3, 5];

            //  How to copy elements from one array to another
            numsArray.CopyTo(dumsArray, 0);
            Console.WriteLine("After copying elements from NumsArray to DumsArray");
            foreach (var nums in dumsArray)
            {
                Console.WriteLine($"{nums}\t");
            }
            //  How to set an element at specific location
            dumsArray.SetValue(99, 4);
            dumsArray[4] = 99;
            //  How to get an element from Specified location
            Console.WriteLine($"Value ar Indext 4 is:{ dumsArray.GetValue(4)} {dumsArray[4]}");

            //  How to get Upperbound and Lowerbound
            Console.WriteLine($"Upperbound is:{dumsArray.GetUpperBound(0)} Lowerbound={dumsArray.GetLowerBound(0)}");
            Console.WriteLine($"Upperbound of NumsArray1 is:{numsArray1.GetUpperBound(1)} Lowerbound={numsArray1.GetLowerBound(1)}");

            //  How to get a Length
            Console.WriteLine($"dumsArray Length is:{dumsArray.Length} and numsArray1 Length of Second Dim. is {numsArray1.GetLength(1)}");

            //  How to get no of dim of an Array
            Console.WriteLine($"No. of dim in numsArray1 is :{numsArray1.Rank}");

            //  How to Sort an Array
            Array.Sort(dumsArray);
            Console.WriteLine("After sorting elements from  DumsArray");
            foreach (var nums in dumsArray)
            {
                Console.WriteLine($"{nums}\t");
            }
            //  How to reversing Array
            Array.Reverse(dumsArray);
            Console.WriteLine("After reversing elements from  DumsArray");
            foreach (var nums in dumsArray)
            {
                Console.WriteLine($"{nums}\t");
            }
            //  How to get an index by passing value
            Console.WriteLine($"Index of 99 is:{Array.IndexOf(dumsArray, 99)}");

            //  How to clear elements
            Array.Clear(dumsArray, 0, 3);
            Console.WriteLine("After clearing elements from  DumsArray");
            foreach (var nums in dumsArray)
            {
                Console.WriteLine($"{nums}\t");
            }
            Console.ReadLine();
        }
    }
}
    
