using System.Collections.Generic;

namespace Sortings.Core.Algorithms
{
    public abstract class BaseAlgorithm
    {
        internal abstract void Sort(int[] x, IDictionary<string, dynamic> parameters);

        internal static void Swap(int[] x, int index1, int index2)
        {
            var tmp = x[index1];
            x[index1] = x[index2];
            x[index2] = tmp;
        }

        internal static void Swap<T>(ref T left, ref T right)
        {
            var tmp = left;
            left = right;
            right = tmp;
        }
    }
}
