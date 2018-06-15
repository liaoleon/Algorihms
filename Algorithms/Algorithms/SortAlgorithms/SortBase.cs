using System;
using Algorithms.SortAlgorithms.Interface;

namespace Algorithms.SortAlgorithms
{
    public abstract class SortBase : ISortAlgorithms
    {
        public abstract void Sort<T>(ref T[] input) where T : IComparable;

        protected void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
