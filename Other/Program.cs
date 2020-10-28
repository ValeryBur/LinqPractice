using System;
using System.Linq;

namespace Other
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concat(simple numbers)
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 4, 5, 6 };
            //Concat: Concatenates (combines) two collections.
            //This Lambda Expression sample concatenates two arrays of numbers.
            var resultNumbers = numbers1.Concat(numbers2);
            Console.WriteLine("Concatenating numbers1 and numbers2 gives:");
            foreach (var number in resultNumbers)
            {
                Console.WriteLine(number);
            }


            //Concat(simple strings)
            string[] vegetables = { "Tomato", "Cucumber", "Carrot" };
            string[] fruits = { "Apples", "Grapes", "Banana" };
            //Concat: Concatenates (combines) two collections.
            //This Lambda Expression sample concatenates two arrays of strings.
            var resultStrings = vegetables.Concat(fruits);
            Console.WriteLine("Concatinating vegetables and fruits gives:");
            foreach (string item in resultStrings)
            {
                Console.WriteLine(item);
            }


            //SequenceEqual
            string[] words = { "one", "two", "three" };
            string[] wordsSame = { "one", "two", "three" };
            string[] wordsOrder = { "two", "three", "one" };
            string[] wordsCase = { "one", "TWO", "three" };
            //SequenceEqual: Checks whether two collections are equal. 
            //Use StringComparer.OrdinalIgnoreCase parameter to ignore case.
            //This Lambda Expression sample shows different methods to test for array equality.
            var resultSame = words.SequenceEqual(wordsSame);
            var resultOrder = words.SequenceEqual(wordsOrder);
            var resultCase = words.SequenceEqual(wordsCase);
            var resultCaseIgnored = words.SequenceEqual(wordsCase, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine("SequenceEqual on two identical arrays:");
            Console.WriteLine(resultSame);

            Console.WriteLine("SequenceEqual on two differently ordered but otherwise identical arrays:");
            Console.WriteLine(resultOrder);

            Console.WriteLine("SequenceEqual on two differently cased but otherwise identical arrays:");
            Console.WriteLine(resultCase);

            Console.WriteLine("SequenceEqual on two differently cased but otherwise identical arrays, where case is ignored:");
            Console.WriteLine(resultCaseIgnored);


            //Zip
            int[] numbersA = { 1, 2, 3 };
            int[] numbersB = { 10, 11, 12 };
            //Zip: Processes two collections in parallel with func instance, and combines result into a new collection.
            //This Lambda Expression sample uses Zip to process two arrays in parallel, while each processed pair is summed.
            var result = numbersA.Zip(numbersB, (a, b) => (a * b));
            Console.WriteLine("Using Zip to combine two arrays into one (1*10, 2*11, 3*12):");
            foreach (int number in result)
                Console.WriteLine(number);


            Console.ReadLine();
        }
    }
}
