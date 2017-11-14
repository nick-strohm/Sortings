using System.Collections.Generic;
using System.Linq;

namespace Sortings.Core.Algorithms
{
    public class RadixSort : BaseAlgorithm
    {
        internal override void Sort(int[] x, IDictionary<string, dynamic> parameters)
        {
            var max = x.Max();
            var iteration = 0;
            var baseValue = 10;
            while (baseValue * iteration >= max)
            {
                x = BucketsToList(ListToBuckets(x, baseValue, iteration)).ToArray();
                iteration++;
            }
        }

        private List<int>[] ListToBuckets(IEnumerable<int> array, int baseValue, int iteration)
        {
            var buckets = new List<int>[baseValue];
            foreach (var number in array)
            {
                var digit = number / (baseValue * iteration) % baseValue;

                buckets[digit].Add(number);
            }

            return buckets;
        }

        private IEnumerable<int> BucketsToList(List<int>[] buckets)
        {
            foreach (var bucket in buckets)
            {
                foreach (var x in bucket)
                {
                    yield return x;
                }
            }
        }
    }
}
