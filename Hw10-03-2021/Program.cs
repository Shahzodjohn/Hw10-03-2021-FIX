using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;



namespace Hw10_03_2021

{

    class Program

    {

        static void Main(string[] args)
        {

            MyList<int> list = new MyList<int>();

            Console.WriteLine("List");

            Console.WriteLine("Adding...");

            
            list.Add(10);

            list.Add(24);

            list.Add(26);


            Console.WriteLine("Search by index! ");
            Console.WriteLine(list.FindByIndex(0));

            int[] arr = { 1, 2, 3, 4, 5 };
            list.AddRange(arr);
            list.Insert(1, 1111);
            Console.WriteLine("All elements = ");
            list.ShowAllElements();

            Console.WriteLine("\nDictionary");

            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            Console.WriteLine("Adding = ");
            dictionary.Add("Person ", "Maruf");
            dictionary.Add("Car ", "BMW");
            Console.WriteLine("Search by key ... ");

            Console.WriteLine();
            Console.WriteLine(dictionary.FindElementByKey("Person: "));

            Console.WriteLine("All elements!");
            Console.ResetColor();
            dictionary.ShowAllElements();

        }

    }

}
