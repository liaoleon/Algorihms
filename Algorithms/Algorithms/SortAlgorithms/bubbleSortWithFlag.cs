using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.SortAlgorithms.Interface;

namespace Algorithms.SortAlgorithms
{
    public class BubbleSortWithFlag : Exchange<int>, ISortAlgorithms<int[]>
    {
        public void Sort(ref int[] input)
        {
            bool flag;
            for (int i = 0; i < input.Length; i++)
            {
                flag = false;
                for (int j = 0; j < input.Length - 1 - i; j++)
                {
                    if (input[j] > input[j + 1])
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
