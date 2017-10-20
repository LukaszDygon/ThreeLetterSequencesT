using System.Collections.Generic;

namespace GenericCounter
{
    public class Counter<T> : ICountable
    {
        private readonly List<T> _objectList;

        public Counter()
        {
            _objectList = new List<T>();
        }

        public void Add(T obj)
        {
            _objectList.Add(obj);
        }

        public int Count()
        {
            return _objectList.Count;
        }
    }
}
