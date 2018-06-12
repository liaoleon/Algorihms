using Algorithms.SortAlgorithms.Interface;

namespace Algorithms.SortAlgorithms
{
    public class BubbleSort : ISortAlgorithms<int[]>
    {
        public virtual void Sort(ref int[] input)
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
        protected void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
