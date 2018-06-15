using System;

namespace Algorithms.SortAlgorithms.Interface
{
    public interface ISortAlgorithms
    {
        void Sort<T>(ref T[] input) where T : IComparable;
    }
}
