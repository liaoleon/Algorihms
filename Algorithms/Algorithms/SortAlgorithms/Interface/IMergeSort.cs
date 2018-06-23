using System;

namespace Algorithms.SortAlgorithms.Interface
{
    public interface IMergeSort
    {
        void Merge<T>(T[] input, int left, int right) where T : IComparable;
        void Divide<T>(T[] input, int left, int right) where T : IComparable;
    }
}
