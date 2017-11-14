using System.Collections.Generic;

namespace Sortings.Core.Algorithms
{
    public class MergeSort : BaseAlgorithm
    {
        internal override void Sort(int[] x, IDictionary<string, dynamic> parameters)
        {
            if (x.Length <= 1)
            {
                return;
            }

            var pivot = x.Length / 2;

            var left = new int[pivot];
            var right = new int[x.Length - pivot];

            for (var i = 0; i <= left.Length - 1; i++)
            {
                left[i] = x[i];
            }

            for (var i = pivot; i <= left.Length - 1; i++)
            {
                right[i - pivot] = x[i];
            }

            Sort(left, parameters);
            Sort(right, parameters);

            // ReSharper disable once RedundantAssignment
            x = Merge(left, right);
        }

        int[] Merge(int[] left, int[] right)
        {
            var x = new int[left.Length + right.Length];
            var indexLeft = 0;
            var indexRight = 0;
            var indexResult = 0;

            while (indexLeft < left.Length && indexResult < right.Length)
            {
                if (left[indexLeft] < right[indexRight])
                {
                    x[indexResult] = left[indexLeft];
                    indexLeft++;
                }
                else
                {
                    x[indexResult] = right[indexRight];
                    indexRight++;
                }

                indexResult++;
            }

            while (indexLeft < left.Length)
            {
                x[indexResult] = left[indexLeft];
                indexLeft++;
                indexResult++;
            }

            while (indexRight < right.Length)
            {
                x[indexResult] = right[indexRight];
                indexRight++;
                indexResult++;
            }

            return x;
        }
    }
}
