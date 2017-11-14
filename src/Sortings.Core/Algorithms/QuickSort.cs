using System.Collections.Generic;

namespace Sortings.Core.Algorithms
{
    public class QuickSort : BaseAlgorithm
    {
        internal override void Sort(int[] x, IDictionary<string, dynamic> parameters)
        {
            var low = 0;
            var high = x.Length - 1;

            if (parameters.ContainsKey("low") && parameters.ContainsKey("high") && parameters["low"] is int lowParam && parameters["high"] is int highParam)
            {
                low = lowParam;
                high = highParam;
            }

            Sort(x, low, high);
        }

        private void Sort(int[] x, int low, int high)
        {
            if (low < high)
            {
                var pi = QuickPartition(x, low, high);

                Sort(x, low, pi - 1);
                Sort(x, pi + 1, high);
            }
        }

        private int QuickPartition(int[] x, int low, int high)
        {
            var pivot = x[high];
            var i = low - 1;

            for (var j = low; j <= high - 1; j++)
            {
                if (x[j] <= pivot)
                {
                    i++;
                    Swap(x, i, j);
                }
            }

            Swap(x, i + 1, high);
            return i + 1;
        }
    }
}