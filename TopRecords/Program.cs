using System;
using System.Collections.Generic;
using System.Linq;

namespace TopRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program displays the top n-th records form the list, where n is a number given by the user.");
            List<int> myList = new List<int> { 2, 23, 45, 67, 78, 89, 12, 3, 25};

            var text = "The numbers on the list are: ";
            int n = 0;
            foreach (var i in myList)
            {
                text += i;
                if (n != myList.Count - 1)
                {
                    text += ", ";
                }
                n++;
            }
            Console.WriteLine(text);

            Console.WriteLine("How many records from the list would you like to display?");
            int recordsNumber = int.Parse(Console.ReadLine());

            var recordsQuery = (from record in myList
                               orderby record descending
                               select record)
                               .Take(recordsNumber);

            var recordsMethod = myList.OrderByDescending(p => p).Take(recordsNumber);

            Console.WriteLine("First check by LINQ Query syntax:");
            foreach (var number in recordsQuery)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();

            Console.WriteLine("Additional check by LINQ Method:");
            foreach (var number in recordsMethod)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
