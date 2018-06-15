using System;

namespace Algorithms.SortAlgorithms
{
    public class SelectionSort : SortBase
    {
        public override void Sort<T>(ref T[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[j].CompareTo(input[min]) < 0)
                    {
                        min = j;
                    }
                }
                Swap(ref input[min], ref input[i]);
            }
        }
    }
}
