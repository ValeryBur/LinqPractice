using System;
using System.Linq;

namespace Quantifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //All
            string[] names1 = { "Bob", "Ned", "Amy", "Bill" };
            //All: Checks if all elements in a collection satisfies a specified condition.
            //This Lambda Expression sample checks whether all names in array start with letter "B".
            var resultAll = names1.All(n => n.StartsWith("B"));
            Console.WriteLine("Does all of the names start with the letter 'B':");
            Console.WriteLine(resultAll);


            //Any
            string[] names2 = { "Bob", "Ned", "Amy", "Bill" };
            //Any: Checks if any elements in a collection satisifies a specified condition.
            //This Lambda Expression sample checks whether any names in array start with the letter 'B'.
            var resultAny = names2.Any(n => n.StartsWith("B"));
            Console.WriteLine("Does any of the names start with the letter 'B':");
            Console.WriteLine(resultAny);


            //Contains
            int[] numbers = { 1, 3, 5, 7, 9 };
            //Contains: Checks if any elements in a collection satisifies a specified value.
            //This Lambda Expression sample checks whether array of numbers contains value of 5.
            var resultContains = numbers.Contains(5);
            Console.WriteLine("sequence contains the value 5:");
            Console.WriteLine(resultContains);


            Console.ReadLine();
        }
    }
}
