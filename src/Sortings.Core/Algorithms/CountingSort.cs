using System.Collections.Generic;
using System.Linq;

namespace Sortings.Core.Algorithms
{
    public class CountingSort : BaseAlgorithm
    {
        internal override void Sort(int[] x, IDictionary<string, dynamic> parameters)
        {
            var n = x.Length;
            var min = x.Min();
            var max = x.Max();

            var output = new int[n];

            var count = new int[max - min + 1];
            for (var i = 0; i < x.Length; i++)
            {
                count[x[i] - min]++;
            }

            count[0]--;
            for (var i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            for (var i = 0; i < n; i++)
            {
                output[count[x[i] - min]--] = x[i];
            }

            // ReSharper disable once RedundantAssignment
            x = output;
        }
    }
}
