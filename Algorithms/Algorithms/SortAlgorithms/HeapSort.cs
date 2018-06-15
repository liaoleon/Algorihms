using System;
using Algorithms.SortAlgorithms.Interface;

namespace Algorithms.SortAlgorithms
{
    public class HeapSort : SortBase, IHeapSort
    {
        public void MaxHeapify<T>(T[] input, int dad, int length) where T : IComparable
        {
            int son = dad * 2 + 1;
            while (son <= length)
            {
                if (son + 1 <= length && input[son].CompareTo(input[son + 1]) < 0)
                {
                    son++;
                }
                if (input[dad].CompareTo(input[son]) < 0)
                {
                    Swap(ref input[dad], ref input[son]);
                    dad = son;
                    son = dad * 2 + 1;
                }
                else
                    return;
            }
        }

        public override void Sort<T>(T[] input)
        {
            for (int i = input.Length / 2 - 1; i >= 0; i--)
            {
                MaxHeapify(input, i, input.Length - 1);
            }
            for (int i = input.Length - 1; i > 0; i--)
            {
                Swap(ref input[0], ref input[i]);
                MaxHeapify(input, 0, i - 1);
            }
        }
    }
}
