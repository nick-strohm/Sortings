using System.Collections.Generic;

namespace Sortings.Core.Algorithms
{
    public class BubbleSort : BaseAlgorithm
    {
        internal override void Sort(int[] x, IDictionary<string, dynamic> parameters)
        {
            var ascending = true;

            if (parameters.ContainsKey("ascending") && parameters["ascending"] is bool b)
            {
                ascending = b;
            }

            Sort(x, ascending);
        }

        private void Sort(int[] x, bool ascending)
        {
            var n = x.Length - 1;
            var comparison = 0;
            var swaps = 0;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n - i; j++)
                {
                    if (x[j] > x[j + 1] && ascending)
                    {
                        Swap(x, j, j + 1);
                        swaps++;
                    }
                    else if (x[j] < x[j + 1] && !ascending)
                    {
                        Swap(x, j, j + 1);
                        swaps++;
                    }

                    comparison++;
                }
            }
        }
    }
}
