using System;
using System.Collections.Generic;

namespace Sortings.Core.Algorithms
{
    public class HeapSort : BaseAlgorithm
    {
        private int Parent(int i) => (int) Math.Floor((i - 1) / 2d);
        private int LeftChild(int i) => 2 * i + 1;
        private int RightChild(int i) => 2 * i + 2;

        internal override void Sort(int[] x, IDictionary<string, dynamic> parameters)
        {
            Heapify(x);

            var end = x.Length - 1;

            while (end > 0)
            {
                Swap(x, end, 0);
                end--;
                SiftDown(x, 0, end);
            }
        }

        private void Heapify(int[] x)
        {
            var count = x.Length;
            var start = Parent(count - 1);

            while (start >= 0)
            {
                SiftDown(x, start, count - 1);
                start--;
            }
        }

        private void SiftDown(int[] x, int start, int end)
        {
            var root = start;

            while (LeftChild(root) <= end)
            {
                var child = LeftChild(root);
                var swap = root;
                if (x[swap] < x[child])
                {
                    swap = child;
                }

                if (child + 1 <= end && x[swap] < x[child + 1])
                {
                    swap = child + 1;
                }

                if (swap == root)
                {
                    return;
                }

                Swap(x, root, swap);
                root = swap;
            }
        }
    }
}