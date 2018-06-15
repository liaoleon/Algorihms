using System;
using System.Collections;

namespace Algorithms.SortAlgorithms
{
    public class BubbleSort : SortBase
    {
        public override void Sort<T>(ref T[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length - 1 - i; j++)
                {
                    if (input[j].CompareTo(input[j + 1]) > 0)
                    {
                        Swap(ref input[j], ref input[j + 1]);
                    }
                }
            }
        }
    }
}
