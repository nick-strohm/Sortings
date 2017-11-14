using System;
using System.Collections.Generic;
using System.Linq;

namespace Sortings.Core.Algorithms
{
    public class CSharpSort : BaseAlgorithm
    {
        internal override void Sort(int[] x, IDictionary<string, dynamic> parameters)
        {
            var sort = new Func<int, int>(y => y);

            if (parameters.ContainsKey("sort") && parameters["sort"] is Func<int, int> sortFunc)
            {
                sort = sortFunc;
            }

            // ReSharper disable once RedundantAssignment
            x = x.OrderBy(sort).ToArray();
        }
    }
}
