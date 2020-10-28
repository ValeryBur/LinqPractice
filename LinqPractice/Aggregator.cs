using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

namespace Aggregate
{
    public class Aggregator
    {
        public void Run()
        {
            var numbers = new int[] { 1, 4, 6, 3, 5 };
            var strings = new string[] { "Jack", "David", "Roy", "Edwin" };
            var numbersAggAdd = numbers.Aggregate((current, next) => current + next);
            var numbersAggSubstract = numbers.Aggregate((current, next) => current - next);
            var numbersAggMultiply = numbers.Aggregate((current, next) => current * next);
            var numbersAggDivide = numbers.Aggregate((current, next) => current / next);
            var numbersAggSeed = numbers.Aggregate(1000, (current, next) => current++ * next);
            var numbersAggSum = numbers.Sum();
            var numbersAggMax = numbers.Max();
            var numbersAggMin = numbers.Min();
            var numbersAggAverage = numbers.Average();
            var numbersAggCount = numbers.Count();


            var stringsAggregateSeed = strings.Aggregate("cool", (current, next) =>
             {
                 if (next.Count() == 4 || next.Count() == 5)
                 {
                     next = next.ToUpper();
                 }
                 current = current.Replace("a", "u");
                 if (next.EndsWith("k") || next.EndsWith("y"))
                 {
                     var nextList = Enumerable.Repeat(next, 2);
                 }
                 return current + next;
             });

            Console.WriteLine(numbersAggAdd);
            Console.WriteLine(numbersAggSubstract);
            Console.WriteLine(numbersAggMultiply);
            Console.WriteLine(numbersAggDivide);
            Console.WriteLine(numbersAggSeed);
            Console.WriteLine(numbersAggSum);
            Console.WriteLine(numbersAggMax);
            Console.WriteLine(numbersAggMin);
            Console.WriteLine(numbersAggAverage);
            Console.WriteLine(numbersAggCount);
            Console.WriteLine(stringsAggregateSeed);

        }
    }
}
