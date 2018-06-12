using Algorithms.SortAlgorithms.Interface;

namespace Algorithms.SortAlgorithms
{
    public class SortBase<T> : ISortBase<T>
    {
        public void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
