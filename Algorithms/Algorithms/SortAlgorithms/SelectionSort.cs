using System;

namespace Algorithms.SortAlgorithms
{
    public class SelectionSort : SortBase<int[]>
    {
        public override void Sort(ref int[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[j] < input[min]) {
                        min = j;
                    }
                }
                Swap(ref input[min], ref input[i]);
            }
        }
    }
}
