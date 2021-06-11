using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise16
{
    class SnazzyQueue<T>
    {
        private List<T> list;

        public SnazzyQueue()
        {
            list = new List<T>();
        }

        public void Enqueue(T obj)
        {
            list.Add(obj);
        }

        public T Dequeue()
        {
            T obj = list[0];
            list.RemoveAt(0);
            return obj;
        }
    }
}
