using System;
namespace Algorithms.SortAlgorithms.Interface
{
    public interface IHeapSort
    {
        void MaxHeapify<T>(T[] input, int dad, int length) where T : IComparable;
    }
}
