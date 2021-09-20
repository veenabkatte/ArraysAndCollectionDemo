using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysandCollectionDemo
{
    class JaggedArray
    {
        static void Main()
        {
            //  This is syntax to declare single dim. Jagged Array
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[] { 10, 20, 30 };
            jaggedArray[1] = new int[] { 40, 50 };
            //jaggedArray[0] = new int[3];
            //jaggedArray[1] = new int[2];

            for (int i = 0; i < 2; i++)
            {
                foreach (var nums in jaggedArray[i])
                {
                    Console.Write($"{nums}\t");
                }
                Console.WriteLine();
            }

            //  This is syntax to declare multi. dim. jagged array
            int[][,] jaggedArray1 = new int[2][,]
            {
                new int[,]{ {10,20,30 },{40,50,60 } },
                new int[,]{ { 1,2,3},{4,5,6 } }
            };
            // This is assignemnt to print above multi jagged Array.

            Console.ReadLine();
        }
    }
}
