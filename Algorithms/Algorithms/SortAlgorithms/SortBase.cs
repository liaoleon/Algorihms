using Algorithms.SortAlgorithms.Interface;

namespace Algorithms.SortAlgorithms
{
    public abstract class SortBase
    {
        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
