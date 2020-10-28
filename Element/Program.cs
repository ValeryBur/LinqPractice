using System;
using System.Linq;

namespace Element
{
    class Program
    {
        static void Main(string[] args)
        {
            //ElementAt
            string[] words = { "One", "Two", "Three" };
            //ElementAt: Retrieves element from a collection at specified (zero-based) index.
            //This Lambda Expression sample retrieves second element from an array.
            var resultElementAt = words.ElementAt(1);
            Console.WriteLine($"Element at index 1 in the array is: {resultElementAt}");

            
            //ElementAtOrDefault
            string[] colors = { "Red", "Green", "Blue" };
            //ElementAtOrDefault: Retrieves element from a collection at specified (zero-based) index,
            //but gets default value if out-of-range.
            //This Lambda Expression sample retrieves elements at index 1 and 10 from array, 
            //and because index 10 is out-of-range, it gets default value (null).
            var resultIndex1 = colors.ElementAtOrDefault(1);
            var resultIndex10 = colors.ElementAtOrDefault(10);
            Console.WriteLine("Element at index 1 in the array contains:");
            Console.WriteLine(resultIndex1);
            Console.WriteLine("Element at index 10 does not exist");
            Console.WriteLine("resultIndex10 is null");
            Console.WriteLine(resultIndex10 == null);

            
            //First(simple)
            string[] fruits = { "Banana", "Apple", "Orange" };
            //First: Retrieves first element from a collection. Throws exception if collection is empty.
            //This Lambda Expression sample retrieves first element from an array.
            var firstSimple = fruits.First();
            Console.WriteLine("First element in the array is:");
            Console.WriteLine(firstSimple);

            
            //First(conditional)
            string[] countries = { "Denmark", "Sweden", "Norway" };
            //First: Retrieves first element from a collection. Throws exception if collection is empty.
            //This Lambda Expression sample takes first element from collection which is 6 characters long.
            var firstConditional = countries.First(c => c.Length == 6);
            Console.WriteLine("First element with a length of 6 characters:");
            Console.WriteLine(firstConditional);


            //FirstOrDefault
            string[] countriesNew = { "Denmark", "Sweden", "Norway" };
            string[] empty = { };
            //FirstOrDefault: Retrieves first element from a collection, or default value if collection is empty.
            //This Lambda Expression sample retrieves first element from "countries" array,
            //but from "empty" array it gets default value (null).
            var result = countriesNew.FirstOrDefault();
            var resultEmpty = empty.FirstOrDefault();
            Console.WriteLine("First element in the countriesNew array contains:");
            Console.WriteLine(result);
            Console.WriteLine("First element in the empty array does not exist:");
            Console.WriteLine(resultEmpty == null);

            
            //Last
            int[] numbers = { 7, 3, 5 };
            //Last: Retrieves last element from a collection. Throws exception if collection is empty.
            //This Lambda Expression sample retrieves last element from array.
            var resultLast = numbers.Last();
            Console.WriteLine("Last number in array is:");
            Console.WriteLine(resultLast);

            
            //LastOrDefault(simple)
            string[] wordsLastOrDefault = { "one", "two", "three" };
            string[] empty2 = { };
            //LastOrDefault: Retrieves last element from a collection, or default value if collection is empty.
            //his Lambda Expression sample retrieves last element from words array,
            //but from empty array it gets default value (null).
            var result2 = wordsLastOrDefault.LastOrDefault();
            var resultEmpty2 = empty2.LastOrDefault();
            Console.WriteLine("Last element in the words array contains:");
            Console.WriteLine(result2);
            Console.WriteLine("Last element in the empty array does not exist:");
            Console.WriteLine(resultEmpty2 == null);

            
            //LastOrDefault(conditional)
            string[] wordsLastOrDefaultConditional = { "one", "two", "three" };
            //LastOrDefault: Retrieves last element from a collection, or default value if collection is empty.
            //This Lambda Expression sample retrieves last element from "words" array having a length of 3 and 2 respectively.
            //As no elements have a length of 2, "resultNoMatch" array gets default value(null).
            var result3 = wordsLastOrDefaultConditional.LastOrDefault(w => w.Length == 3);
            var resultNoMatch = wordsLastOrDefaultConditional.LastOrDefault(w => w.Length == 2);
            Console.WriteLine("Last element in the words array having a length of 3:");
            Console.WriteLine(result3);
            Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
            Console.WriteLine(resultNoMatch == null);

            //Single
            string[] names5 = { "Peter" };
            string[] names6 = { "Peter", "Joe", "Wilma" };
            string[] empty3 = { };
            //Single: Retrieves only element in a collection. Throws exception if not exactly one element in collection.
            //This Lambda Expression sample retrieves a single element from each array, 
            //but from arrays with not exactly one element it throws exception.
            var result1 = names5.Single();
            Console.WriteLine("The only name in the array is:");
            Console.WriteLine(result1);
            try
            {
                var resultEmpty1 = empty3.Single();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                var result4 = names6.Single();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            //SingleOrDefault
            string[] names10 = { "Peter" };
            string[] names30 = { "Peter", "Joe", "Wilma" };
            string[] empty10 = { };
            //	Single: Retrieves only element in a collection. 
            //Throws exception if not exactly one element in collection.
            //This Lambda Expression sample retrieves a single element from each array, 
            //but from arrays with not exactly one element it throws exception.
            var result10 = names10.SingleOrDefault();
            var resultEmpty10 = empty10.SingleOrDefault();

            Console.WriteLine("The only name in the array is:");
            Console.WriteLine(result10);

            Console.WriteLine("As array is empty, SingleOrDefault yields null:");
            Console.WriteLine(resultEmpty10 == null);

            try
            {
                var resultEx = names30.SingleOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
