using System;
using System.Linq;

namespace Generation
{
    class Program
    {
        static void Main(string[] args)
        {
            //DefaultIfEmpty(simple)
            string[] emptyStr = { };
            int[] emptyInt = { };
            string[] words = { "one", "two", "three" };
            //DefaultIfEmpty: If a collection is empty, its default value is returned. 
            //Default value depends on collection type.
            //This Lambda Expression sample returns default values for each of the empty collections, 
            //while "words" array is returned as is.
            var resultStr = emptyStr.DefaultIfEmpty();
            var resultInt = emptyInt.DefaultIfEmpty();
            var resultWords = words.DefaultIfEmpty();
            Console.WriteLine("resultStr has one element with a value of null:");
            Console.WriteLine(resultStr.Count() == 1 && resultStr.First() == null);
            Console.WriteLine("resultInt has one element with a value of 0:");
            Console.WriteLine(resultInt.Count() == 1 && resultInt.First() == 0);
            Console.WriteLine("resultWords has same content as words array:");
            Console.WriteLine(resultWords.SequenceEqual(words));


            //DefaultIfEmpty(default value)
            int[] empty2 = { };
            //DefaultIfEmpty: If a collection is empty, its default value is returned. Default value depends on collection type. 
            //A default value may be specified.
            //This Lambda Expression sample returns specified default value of 5 for empty array.
            var result = empty2.DefaultIfEmpty(5);
            Console.WriteLine("result contains one element with a value of 5:");
            Console.WriteLine(result.Count() == 1 && result.First() == 5);


            //Empty
            var empty = Enumerable.Empty<string>();//Generates an empty collection (with no elements).
            //This Lambda Expression sample creates an empty sequence of type string.
            Console.WriteLine("Sequence is empty:");
            Console.WriteLine(empty.Count() == 0);


            //Range
            var result3 = Enumerable.Range(0, 10);//Range: Generates sequence of numeric values.
            //This Lambda Expression sample generates sequence within a range from 0-10.
            Console.WriteLine("Counting from 0 to 9:");
            foreach (int number in result3)
                Console.WriteLine(number);


            //Repeat
            string word = "Banana";
            //Repeat: Creates a collection of repeated elements, where first argument is value to repeat, 
            //and second argument is number of times to repeat.
            //This Lambda Expression sample repeats the word "Banana" 5 times.
            var result4 = Enumerable.Repeat(word, 5);
            Console.WriteLine("String is repeated 5 times:");
            foreach (string str in result4)
                Console.WriteLine(str);


            Console.ReadLine();

        }
    }
}
