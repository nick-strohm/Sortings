using System;
using System.Collections.Generic;
using System.Linq;

namespace Sortings.Core.Algorithms
{
    public class GravitySort : BaseAlgorithm
    {
        internal override void Sort(int[] x, IDictionary<string, dynamic> parameters)
        {
#warning: TODO
            /*if (!x.All(v => v >= 0))
            {
                throw new ArgumentOutOfRangeException(nameof(x), "All elemens must be positive integers.");
            }

            var len = x.Length;
            var min = x.Min();
            var max = x.Max();

            var ori = new int[len];
            Array.Copy(x, ori, len);

            var reference = new int[max];

            for (var i = 0; i < len; i++)
            {
                reference[x[i]]++;
            }

            var inter = new List<int>();
            var ind = 0;
            var prev = reference.Sum()*/
        }
    }
}
