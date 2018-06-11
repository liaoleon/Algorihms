using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.SortAlgorithms.Interface;

namespace Algorithms.SortAlgorithms
{
    public class Exchange<T> : IExchange<T>
    {
        public void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
