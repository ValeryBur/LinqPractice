using System;
using System.Linq;

namespace GroupBy
{
    class Program
    {
        static void Main(string[] args)
        {
            //GroupBy
            int[] numbers = { 10, 15, 20, 25, 30, 35 };
            //GroupBy: Projects elements of a collection into groups by key.
            //his Lambda Expression sample splits array of numbers into two groups: 
            //one which is divisible by 10, and one which is not.
            var result = numbers.GroupBy(n => (n % 2) == 0);

            Console.WriteLine("GroupBy has created two groups:");
            foreach (IGrouping<bool, int> group in result)
            {
                if (group.Key == true)
                    Console.WriteLine("Divisible by 2");
                else
                    Console.WriteLine("Not Divisible by 2");
                foreach (var number in group)
                {
                    Console.WriteLine(number);
                }
            }
            Console.ReadLine();
        }
    }
}
