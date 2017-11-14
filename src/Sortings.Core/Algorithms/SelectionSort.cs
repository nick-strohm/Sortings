using System.Collections.Generic;

namespace Sortings.Core.Algorithms
{
    public class SelectionSort : BaseAlgorithm
    {
        internal override void Sort(int[] x, IDictionary<string, dynamic> parameters)
        {
            var minimum = true;
            var ascending = true;

            if (parameters.ContainsKey("minimum") && parameters["minimum"] is bool min)
            {
                minimum = min;
            }

            if (parameters.ContainsKey("ascending") && parameters["ascending"] is bool asc)
            {
                ascending = asc;
            }

            Sort(x, minimum, ascending);
        }

        private void Sort(int[] x, bool minimum, bool ascending)
        {
            if (minimum && ascending)
            {
                SortMinimumAscending(x);
            }

            if (minimum && !ascending)
            {
                SortMinimumDescending(x);
            }

            if (!minimum && ascending)
            {
                SortMaximumAscending(x);
            }

            if (!minimum && !ascending)
            {
                SortMaximumDescending(x);
            }
        }

        private void SortMinimumAscending(int[] x)
        {
            var n = x.Length;

            var left = 0;

            while (left < n)
            {
                var min = left;

                for (var i = left + 1; i < n; i++)
                {
                    if (x[i] < x[min])
                    {
                        min = i;
                    }
                }

                Swap(x, min, left);
                left++;
            }
        }

        private void SortMinimumDescending(int[] x)
        {
            var n = x.Length;

            var right = n - 1;

            while (right > 0)
            {
                var min = right;

                for (var i = right - 1; i >= 0; i--)
                {
                    if (x[i] < x[min])
                    {
                        min = i;
                    }
                }

                Swap(x, right, min);
                right--;
            }
        }

        private void SortMaximumAscending(int[] x)
        {
            var n = x.Length;

            var left = 0;

            while (left < n)
            {
                var min = left;

                for (var i = left + 1; i < n; i++)
                {
                    if (x[i] > x[min])
                    {
                        min = i;
                    }
                }

                Swap(x, min, left);
                left++;
            }
        }

        private void SortMaximumDescending(int[] x)
        {
            var n = x.Length;

            var right = n - 1;

            while (right > 0)
            {
                var min = right;

                for (var i = right - 1; i >= 0; i--)
                {
                    if (x[i] > x[min])
                    {
                        min = i;
                    }
                }

                Swap(x, right, min);
                right--;
            }
        }
    }
}
