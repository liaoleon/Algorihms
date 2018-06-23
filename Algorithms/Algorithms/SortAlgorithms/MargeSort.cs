using System;
using Algorithms.SortAlgorithms.Interface;

namespace Algorithms.SortAlgorithms
{
    public class MargeSort : SortBase, IMargeSort
    {
        public void Marge<T>(T[] input, int left, int right) where T : IComparable
        {
            T[] Sorted = new T[right - left];
            int mid = (left + right) / 2;
            int l = left;
            int r = mid;

            for (int i = 0; i < Sorted.Length; i++)
            {
                if (r < right && l < mid && input[l].CompareTo(input[r]) < 0)
                {
                    Sorted[i] = input[l++];
                }
                else if (r < right)
                {
                    Sorted[i] = input[r++];
                }
                else if (l < mid)
                {
                    Sorted[i] = input[l++];
                }
            }
            for (int i = 0; i < Sorted.Length; i++)
            {
                Swap(ref input[left + i], ref Sorted[i]);
            }
        }
        public void Divide<T>(T[] input, int left, int right) where T : IComparable
        {
            if (right - left > 1)
            {
                int mid = (left + right) / 2;
                Divide(input, left, mid);
                Divide(input, mid, right);
                Marge(input, left, right);
            }
        }

        public override void Sort<T>(T[] input)
        {
            Divide(input, 0, input.Length);
        }
    }
}
