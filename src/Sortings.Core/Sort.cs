using System;
using System.Collections.Generic;
using Sortings.Core.Algorithms;

namespace Sortings.Core
{
    public static class Sort
    {
        /// <summary>
        /// Sorts an Array with an unspecified amount of parameters.
        /// Valid algorithms can be found in Sortings.Core.Algorithms. They inherit the BaseAlgorithm class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="parameters"></param>
        public static void SortArray<T>(int[] x, IDictionary<string, dynamic> parameters = null) where T : BaseAlgorithm
        {
            Activator.CreateInstance<T>().Sort(x, parameters ?? new Dictionary<string, dynamic>());
        }
    }
}
