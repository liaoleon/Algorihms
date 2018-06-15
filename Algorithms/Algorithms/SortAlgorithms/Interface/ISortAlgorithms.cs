using System;

namespace Algorithms.SortAlgorithms.Interface
{
    public interface ISortAlgorithms
    {
        void Sort<T>(T[] input) where T : IComparable;
    }
}
