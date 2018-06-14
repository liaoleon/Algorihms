using Algorithms.SortAlgorithms.Interface;

namespace Algorithms.SortAlgorithms
{
    public abstract class SortBase<T> : ISortAlgorithms<T>
    {
        public abstract void Sort(ref T input);

        protected void Swap<T2>(ref T2 a, ref T2 b)
        {
            T2 temp = a;
            a = b;
            b = temp;
        }
    }
}
