using System;

namespace Algorithms.SortAlgorithms.Interface
{
    public interface IQuickSort
    {
        void Partition<T>(T[] input, int left, int right) where T : IComparable;
    }
}
