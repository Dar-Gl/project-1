using System.Collections;

namespace CloneCustomer
{
    public class CustomList<T> : IEnumerable<T>
    {
        private readonly List<T> items = new();

        public void Add(T item) => items.Add(item);

        public int Count => items.Count;

        public T this[int index] => items[index];

        public IEnumerator<T> GetEnumerator() => items.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
