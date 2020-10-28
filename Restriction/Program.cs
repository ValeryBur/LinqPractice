using System;
using System.Linq;

namespace Restriction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Where(simple numbers)
            int[] numbers = { 5, 10, 15, 20, 25, 30 };
            //Where: Filters elements from a collection to satisfy a specified condition.
            //This Lambda Expression sample finds numbers with values >= 15 and values <= 25.
            var result = numbers.Where(n => n >= 15 && n <= 25);
            Console.WriteLine("Numbers being >= 15 and <= 25:");
            foreach (int number in result)
            {
                Console.WriteLine(number);
            }


            //Where(simple objects)
            Person[] persons =
                {
                    new Person { Name = "Mike", Age = 25 },
                    new Person { Name = "Joe", Age = 43 },
                    new Person { Name = "Nadia", Age = 31 }
                };
            //Where: Filters elements from a collection to satisfy a specified condition.
            //	This Lambda Expression sample finds all persons who are 30 years or older.
            var resultObj = persons.Where(p => p.Age >= 30);
            Console.WriteLine("Finding persons who are 30 years old or older:");
            foreach (Person person in resultObj)
            {
                Console.WriteLine($"{person.Name}\t {person.Age}");
            }


            //Where(indexed)
            int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Where: Filters elements from a collection to satisfy a specified condition. 
            //Use overloaded Index to pass index.
            //This Lambda Expression sample finds numbers divisible by 3 and element index >= 5. 
            var resultInd = numbers2.Where((n, i) => n % 3 == 0 && i >= 5);
            Console.WriteLine("Numbers divisible by 3 and indexed >= 5:");
            foreach (int number in resultInd)
            {
                Console.WriteLine(number);
            }


            Console.ReadLine();
        }
    }
}
