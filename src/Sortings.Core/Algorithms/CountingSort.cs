using System;
using System.Collections.Generic;
using System.Linq;

namespace Sortings.Core.Algorithms
{
    public class CountingSort : BaseAlgorithm
    {
        internal override void Sort(int[] x, IDictionary<string, dynamic> parameters)
        {
            var n = x.Length;
            var max = x.Max();

            var count = new int[max + 1];
            for (var i = 0; i < x.Length; i++)
            {
                count[x[i]]++;
            }

            var currIndex = 0;

            for (var i = 0; i < max; i++)
            {
                for (var j = 0; j < count[i]; j++)
                {
                    x[currIndex] = i;
                    currIndex++;
                }
            }
        }
    }
}
