using System.Collections.Generic;

namespace Sortings.Core.Algorithms
{
    public class InsertionSort : BaseAlgorithm
    {
        internal override void Sort(int[] x, IDictionary<string, dynamic> parameters)
        {
            var n = x.Length;

            for (var i = 1; i < n; i++)
            {
                var key = x[i];
                var j = i - 1;

                while (j >= 0 && x[j] > key)
                {
                    x[j + 1] = x[j];
                    j = j - 1;
                }

                x[j + 1] = key;
            }
        }
    }
}