using System;
using Algorithms.SortAlgorithms.Interface;

namespace Algorithms.SortAlgorithms
{
    public class QuickSort : SortBase, IQuickSort
    {
        public void Partition<T>(T[] input, int left, int right) where T : IComparable
        {
            if (left >= right)
            {
                return;
            }
            T pivot = input[right];
            int nextLeft = left;
            for (int i = left; i < right; i++)
            {
                if (input[i].CompareTo(pivot) < 0)
                {
                    Swap(ref input[left], ref input[i]);
                    left++;
                }
            }
            Swap(ref input[left], ref input[right]);
            //left is pivot index
            Partition(input, nextLeft, left - 1);
            Partition(input, left + 1, right);
        }

        public override void Sort<T>(T[] input)
        {
            Partition(input, 0, input.Length - 1);
        }
    }
}
