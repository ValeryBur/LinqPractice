using System;
using System.Linq;
using System.Transactions;

namespace Ordering
{
    class Program
    {
        static void Main(string[] args)
        {
            //OrderBy(simple numbers)
            int[] numbers = { 7, 9, 5, 2};
            //OrderBy: Sorts a collection in ascending order.
            //This Lambda Expression sample sorts array of numbers in ascending order.
            var resultNumbers = numbers.OrderBy(n => n);
            Console.WriteLine("Ordered list of numbers:");
            foreach (int number in resultNumbers)
                Console.WriteLine(number);


            //OrderBy(simple dates)
            var dates = new DateTime[]
            {
            new DateTime(2015, 2, 15),
            new DateTime(2015, 3, 25),
            new DateTime(2015, 1, 5)
            };
            //OrderBy: Sorts a collection in ascending order.
            //This Lambda Expression sample sorts array of dates in ascending order.
            var resultDates = dates.OrderBy(d => d);
            Console.WriteLine("Ordered list of dates:");
            foreach (DateTime date in resultDates)
            {
                Console.WriteLine(date.ToString("yyyy/MM/dd"));
            }


            //OrderBy(simple objects)
            Cars[] car =
            {
                new Cars { Name = "Super Car", HorsePower = 215 },
                new Cars { Name = "Economy Car", HorsePower = 75 },
                new Cars { Name = "Family Car", HorsePower = 145 },
            };
            //OrderBy: Sorts a collection in ascending order.
            //This Lambda Expression sample sorts array of cars by "HorsePower", in ascending order.
            var result = car.OrderBy(c => c.HorsePower);
            Console.WriteLine("Ordered list of cars by horsepower:");
            foreach (Cars cars in result)
            {
                Console.WriteLine($"{cars.Name}: {cars.HorsePower}");
            }


            //OrderByDescending
            string[] names = { "Ned", "Ben", "Susan", "David" };
            //OrderByDescending: Sorts a collection in descending order.
            //This Lambda Expression sample sorts array of names in descending order.
            var resultDesc = names.OrderByDescending(n => n);
            Console.WriteLine("Descending ordered list of names:");
            foreach (string name in resultDesc)
            {
                Console.WriteLine(name);
            }


            //Reverse
            char[] characters = { 's', 'a', 'm', 'p', 'l', 'e' };
            //Reverse: Reverses elements in a collection.
            //This Lambda Expression sample reverts characters in array.
            var resultRev = characters.Reverse();
            Console.WriteLine("Characters in reverse order:");
            foreach (char ch in resultRev)
            {
                Console.WriteLine(ch);
            }


            //ThenBy
            string[] capitals = { "Berlin", "Paris", "Madrid", "Tokyo", "London",
                          "Athens", "Beijing", "Seoul" };
            //ThenBy: Use after earlier sorting, to further sort a collection in ascending order.
            //This Lambda Expression sample first sorts array by string length of city capital, and then by alphabet.
            var resultThen = capitals.OrderBy(c => c.Length).ThenBy(c => c);
            Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
            foreach (string capital in resultThen)
            {
                Console.WriteLine(capital);
            }


            //ThenByDescending
            var datesThenDesc = new DateTime[]
            {
                new DateTime(2015, 3, 1),
                new DateTime(2014, 7, 1),
                new DateTime(2013, 5, 1),
                new DateTime(2015, 1, 1),
                new DateTime(2015, 7, 1)
            };
            //ThenByDescending: Use after earlier sorting, to further sort a collection in descending order.
            //This Lambda Expression sample first orders a list of dates by year descending, and then by month descending.
            var resultThenDesc = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);
            Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
            foreach (var date in resultThenDesc)
            {
                Console.WriteLine(date.ToString("yyyy/MM/dd"));
            }

        }
    }
}
