namespace Algorithms.SortAlgorithms
{
    public class BubbleSortWithFlag : BubbleSort
    {
        public override void Sort<T>(ref T[] input)
        {
            bool flag;
            for (int i = 0; i < input.Length; i++)
            {
                flag = false;
                for (int j = 0; j < input.Length - 1 - i; j++)
                {
                    if (input[j].CompareTo(input[j + 1]) > 0)
                    {
                        Swap(ref input[j], ref input[j + 1]);
                        flag = true;
                    }
                }
                if (!flag)
                    return;
            }
        }
    }
}
