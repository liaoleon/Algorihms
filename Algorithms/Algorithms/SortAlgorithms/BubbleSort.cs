using Algorithms.SortAlgorithms.Interface;

namespace Algorithms.SortAlgorithms
{
    public class BubbleSort : SortBase<int[]>
    {
        public override void Sort(ref int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length - 1 - i; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        Swap(ref input[j], ref input[j + 1]);
                    }
                }
            }
        }
    }
}
