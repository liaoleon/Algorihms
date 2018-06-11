using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.SortAlgorithms.Interface
{
    public interface ISortAlgorithms<T>
    {
        void Sort(ref T input);
    }
}
