using System;
using System.Runtime.InteropServices;

namespace Aggregate

{
    class Program
    {
        static void Main(string[] args)
        {
            var AggregateExamples = new Aggregator();
            AggregateExamples.Run();

            Console.ReadLine();
        }
    }
}
