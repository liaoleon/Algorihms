using Algorithms.SortAlgorithms.Interface;

namespace Algorithms.SortAlgorithms
{
    public abstract class SortBase
    {
        protected void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
