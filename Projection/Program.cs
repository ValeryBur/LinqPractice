using System;
using System.Linq;

namespace Projection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Select(simple)
            decimal[] numbers = { 3.4M, 8.33M, 5.225M };
            //Select: Selects, projects and transforms elements in a collection.
            //This Lambda Expression sample selects and rounds down each number in array.
            var resultSimple = numbers.Select(n => Math.Floor(n));
            Console.WriteLine("Numbers rounded down:");
            foreach (int number in resultSimple)
                Console.WriteLine(number);


            //Select(anonymous type)
            double[] angles = { 30D, 60D, 90D }; // Angles in radians
            //Select: Selects, projects and transforms elements in a collection.
            //This Lambda Expression sample calculates cos and sin of selected angles, 
            //and projects result into anonymously typed elements. 
            var resultAnonymous = angles.Select(a => new { Angle = a, Cos = Math.Cos(a), Sin = Math.Sin(a) });
            Console.WriteLine("Calculated values:");
            foreach (var res in resultAnonymous)
                Console.WriteLine(String.Format($"Angle {res.Angle}: Cos = {res.Cos}, Sin = {res.Sin}"));


            //Select(indexed)
            string[] words = { "one", "two", "three" };
            //Select: Selects, projects and transforms elements in a collection. 
            //Can be overloaded to get element index.
            //This Lambda Expression sample selects word and element index from array.
            var resultIndexed = words.Select((w, i) => new
            {
                Index = i,
                Value = w
            });
            Console.WriteLine("Words with index and value:");
            foreach (var word in resultIndexed)
                Console.WriteLine(String.Format("Index {0} is {1}", word.Index, word.Value));


            //SelectMany(crossjoin)
            string[] fruits = { "Grape", "Orange", "Apple" };
            int[] amounts = { 1, 2, 3 };
            //SelectMany: Flattens collections into a single collection (similar to cross join in SQL).
            //This Lambda Expression sample cross joins two arrays, and gets cartesian product.
            var result = fruits.SelectMany(f => amounts, (f, a) => new
            {
                Fruit = f,
                Amount = a
            });
            Console.WriteLine("Selecting all values from each array, and mixing them:");
            foreach (var o in result)
                Console.WriteLine(o.Fruit + ", " + o.Amount);

            Console.ReadLine();
        }
    }
}
