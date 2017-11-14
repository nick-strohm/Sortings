using System;
using System.Linq;
using Sortings.Core.Algorithms;
using static Sortings.Core.Sort;

namespace Sortings.Application
{
    public static class Program
    {
        private static void Main()
        {
            var tests = 1;
            var elements = 100;
            var maxValue = elements;

            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine($"Generating random values to sort ({elements} elements with a max value of {maxValue}).");

            //var baseArr = GetRandomValues(elements, maxValue);
            var baseArr = new int[elements];
            for (var i = 0; i < elements; i++)
            {
                baseArr[i] = i;
            }

            Console.WriteLine($"Starting to sort. Running {tests} tests per sorting algorithm.");

            var headerl = "==========[ ";
            var headerm = "RESULTS";
            var headerr = " ]==========";
            var header = headerl + headerm + headerr;
            var len = (Console.WindowWidth - header.Length) / 2;

            Console.WriteLine();
            Console.Write($"{new string(' ', len)}{headerl}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{headerm}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{headerr}{new string(' ', len)}{Environment.NewLine}");

            MeasureSortingTime<BubbleSort>(baseArr, tests, elements, maxValue);
            //MeasureSortingTime<QuickSort>(baseArr, tests, elements, maxValue);
            //MeasureSortingTime<SelectionSort>(baseArr, tests, elements, maxValue);
            //MeasureSortingTime<CountingSort>(baseArr, tests, elements, maxValue);
            //MeasureSortingTime<InsertionSort>(baseArr, tests, elements, maxValue);
            //MeasureSortingTime<MergeSort>(baseArr, tests, elements, maxValue);
            //MeasureSortingTime<CSharpSort>(baseArr, tests, elements, maxValue);
            //MeasureSortingTime<RadixSort>(baseArr, tests, elements, maxValue);
            //MeasureSortingTime<HeapSort>(baseArr, tests, elements, maxValue);

            Console.WriteLine($"Worst-case: {((Math.Pow(elements, 2) - elements) / 2)}");

            Console.ReadLine();
        }

        private static void Output(string name, int tests, int elements, int maxValue, double neededTime)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{name,15}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" | Tests: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{tests,5}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" | Elemente: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{elements,10}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" | Max-Value: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{maxValue,10}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" | Median Zeit: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{$"{neededTime:0.0000}",10}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($" Millisekunden{Environment.NewLine}");
        }

        private static void MeasureSortingTime<T>(int[] baseArr, int tests = 10, int elements = 10000, int maxValue = 10000) where T : BaseAlgorithm
        {
            var times = new TimeSpan[tests];

            var row = Console.CursorTop;

            var name = typeof(T).Name;

            for (var i = 0; i < tests; i++)
            {
                Console.CursorLeft = 0;
                Console.CursorTop = row;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{name,15}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($" | Running test no {i + 1}");

                var arr = new int[baseArr.Length];
                Array.Copy(baseArr, arr, arr.Length);
                var start = DateTime.UtcNow;
                SortArray<T>(arr);
                var end = DateTime.UtcNow;
                var requiredTime = end - start;
                times[i] = requiredTime;

                //Console.WriteLine();
                //Console.WriteLine(string.Join(", ", arr));
            }

            Console.CursorLeft = 0;
            Console.CursorTop = row;

            Output(name, tests, elements, maxValue, times.Select(x => x.TotalMilliseconds).Average());
        }

        private static int[] GetRandomValues(int length, int maxValue)
        {
            var arr = new int[length];
            var rng = new Random();
            for (var i = 0; i < length; i++)
            {
                arr[i] = rng.Next(maxValue);
            }

            return arr;
        }
    }
}
