using System;
using System.Collections;


namespace ArraysandCollectionDemo
{
    class ArrayListDemo
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(100);
            arrayList.Add("Scott");
            arrayList.Add('M');
            arrayList.Add(true);
            arrayList.Add("Pune");
            //arrayList.Insert(1,100);
            arrayList.Capacity = arrayList.Count;
            Console.WriteLine($"Count={arrayList.Count} Capacity={arrayList.Capacity}");
            Console.WriteLine("Display using foreach");
            foreach (var v in arrayList)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("display using For loop");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            arrayList.Remove("Scott");
            arrayList.Capacity = arrayList.Count;
            Console.WriteLine($"Count={arrayList.Count} Capacity={arrayList.Capacity}");

            Console.WriteLine("After removing Scott");
            foreach (var v in arrayList)
            {
                Console.WriteLine(v);
            }
            var result = arrayList.Contains(100) ? "Roll No is present" : "Rollno is not present";
            Console.WriteLine($"{result}");
            arrayList.Clear();
            Console.WriteLine($"Count={arrayList.Count} Capacity={arrayList.Capacity}");
            Console.ReadLine();
        }
    }
}
