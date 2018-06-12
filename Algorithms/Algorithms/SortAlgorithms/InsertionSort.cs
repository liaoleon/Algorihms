using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.SortAlgorithms.Interface;

namespace Algorithms.SortAlgorithms
{
    public class InsertionSort : SortBase<int>, ISortAlgorithms<int[]>
    {
        public void Sort(ref int[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                for (int j = i - 1; j >= 0 && input[j + 1] < input[j]; j--)
                {
                    Swap(ref input[j], ref input[j + 1]);
                }
            }
        }

        private void OldSort(ref int[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                //int temp = input[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (input[j + 1] < input[j])
                    {
                        //j+1 is always temp index
                        Swap(ref input[j], ref input[j + 1]);
                        //input[j + 1] = input[j];
                        //input[j] = temp;
                    }
                    else
                        break;
                }
            }
        }
    }
}
