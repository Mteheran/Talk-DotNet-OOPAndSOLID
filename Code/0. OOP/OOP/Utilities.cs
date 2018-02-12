using System;

namespace OOP
{
    public class Utilities<T, TU> where T : IComparable, TU, new()
    {
        public void DoSomething(T value)
        {
            var obj = new T();
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
