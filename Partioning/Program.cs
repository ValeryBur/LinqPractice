using System;
using System.Linq;

namespace Partitioning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skip
            string[] words1 = { "one", "two", "three", "four", "five", "six" };
            //Skip: Skips specified number of elements in a collection.
            //This Lambda Expression sample skips first 4 words in array.
            var resultSkip = words1.Skip(4);
            Console.WriteLine("Skips the first 4 words:");
            foreach (string word in resultSkip)
            {
                Console.WriteLine(word);
            }


            //SkipWhile
            string[] words2 = { "one", "two", "three", "four", "five", "six" };
            //SkipWhile: Skips elements in a collection while specified condition is met.
            //This Lambda Expression sample skips words in array, as long as word has length of 3 characters.
            var resultSkipWhile = words2.SkipWhile(w => w.Length == 3);
            Console.WriteLine("Skips words while the condition is met:");
            foreach (var word in resultSkipWhile)
            {
                Console.WriteLine(word);
            }

            //Take
            int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Take: Takes specified number of elements in a collection, starting from first element.
            //This Lambda Expression sample takes only 5 first numbers in array.
            var resultTake = numbers1.Take(5);
            Console.WriteLine("Takes the first 5 numbers only:");
            foreach (int number in resultTake)
            {
                Console.WriteLine(number);
            }


            //TakeWhile
            int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Takes elements in a collection while specified condition is met, starting from first element.
            //This Lambda Expression sample takes numbers from array, while number is less than 5.
            var resultTakeWhile = numbers2.TakeWhile(n => n < 5);
            Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
            foreach (int number in resultTakeWhile)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
