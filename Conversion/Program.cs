using System;
using System.Collections.Generic;
using System.Linq;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "David", "Jack", "Suzie" };
            var resultAsEnumerable = names.AsEnumerable();//AsEnumerable: casts a collection to IEnumerable of same type.
            Console.WriteLine("Iterating over IEnumerable collection:");
            foreach (var name in resultAsEnumerable)
                Console.WriteLine(name);

            List<string> cars = new List<string> { "BMW", "Mercedes", "Lexus" };
            //This Lambda Expression sample casts list of strings to a simple string array.
            var resultCast = names.Cast<string>();//Cast: Casts a collection to a specified type.
            Console.WriteLine("List of cars casted to a simple string array:");
            foreach (string car in resultCast)
                Console.WriteLine(car);

            object[] objects = { "Man", 100, 9.9, true, null };
            var resultOfTypeString = objects.OfType<string>();//	OfType: Filters elements of specified type in a collection.
            Console.WriteLine("Objects being of type string have the values:");
            foreach (string str in resultOfTypeString)
                Console.WriteLine(str);

            var resultOfTypeInt = objects.OfType<int>();//	OfType: Filters elements of specified type in a collection.
            Console.WriteLine("Objects being of type int have the values:");
            foreach (int number in resultOfTypeInt)
                Console.WriteLine(number);

            var resultOfTypeBoolean = objects.OfType<bool>();//	OfType: Filters elements of specified type in a collection.
            Console.WriteLine("Objects being of type bool have the values:");
            foreach (bool value in resultOfTypeBoolean)
                Console.WriteLine(value);

            int[] numbers = { 1, 2, 3, 4, 5 };
            //ToArray: Converts type to a new array.
            var resultToArray = numbers.ToArray();//This Lambda Expression sample converts one array to another.
            Console.WriteLine("New array contains identical values:");
            foreach (int number in resultToArray)
                Console.WriteLine(number);

            English2German[] english2German =
            {
                new English2German { EnglishSalute = "Good morning", GermanSalute = "Guten Morgen" },
                new English2German { EnglishSalute = "Good day", GermanSalute = "Guten Tag" },
                new English2German { EnglishSalute = "Good evening", GermanSalute = "Guten Abend" },
            };
            //ToDictionary: Converts collection into a Dictionary with Key and Value.
            var resultToDictionarySimple = english2German.ToDictionary(k => k.EnglishSalute, v => v.GermanSalute);
            Console.WriteLine("Values inserted into dictionary:");
            foreach (KeyValuePair<string, string> dic in resultToDictionarySimple)
                Console.WriteLine(String.Format($"English salute {dic.Key} is {dic.Value} in German"));

            int[] numbersDict = { 1, 2, 3, 4, 5 };
            //ToDictionary: Converts collection into a Dictionary with Key and Value.
            //This Lambda Expression sample uses ToDictionary to make a new array based on condition.
            var result = numbersDict.ToDictionary(k => k, v => (v % 2) == 1 ? "Odd" : "Even");
            Console.WriteLine("Numbers labeled Odd and Even in dictionary:");
            foreach (var dictionary in result)
            {
                Console.WriteLine($"Value {dictionary.Key} is {dictionary.Value}");
            }

            string[] namesToList = { "Jack", "David", "Alex" };
            //ToList: Converts collection into a List.
            //	This Lambda Expression sample converts string array to List of strings.
            List<string> resultToList1 = namesToList.ToList();
            Console.WriteLine($"name is of type {namesToList.GetType().Name}");
            Console.WriteLine($"result is of type {namesToList.GetType().Name}");

            int[] numbersToList = { 1, 2, 3, 4, 5 };
            //ToList: Converts collection into a List.
            //	This Lambda Expression sample converts int array to List of int.
            List<int> resultToList2 = numbersToList.ToList();
            Console.WriteLine($"number is of type {numbersToList.GetType().Name}");
            Console.WriteLine($"result2 is of type {resultToList2.GetType().Name}");

            string[] wordsArray = { "one", "two", "three", "four", "five", "six", "seven" };
            //ToLookup: Converts a collection into a Lookup, grouped by key.
            //This Lambda Expression sample puts array elements into a one-to-many Lookup, where key equals element length.
            var resultToLookUp = wordsArray.ToLookup(w => w.Length);

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(String.Format($"Elements with a length of {i}:"));
                foreach (string word in resultToLookUp[i])
                    Console.WriteLine(word);
            }
                Console.WriteLine("Hello World!");
        }
    }
}
