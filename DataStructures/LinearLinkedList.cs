using System.Collections.Generic;
using System;

namespace DataStructures
{
    public class LinearLinkedList<T> : IEnumerable<T>
    {
        private Node _head;
        private Node _tail;

        public int Count { get; } = 0;

        public LinearLinkedList()
        { }

        public void AddFirst(T newValue)
        {
            throw new NotImplementedException();
        }

        public void AddLast(T newValue)
        {
            throw new NotImplementedException();
        }

        public T Get(int index)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public void Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }

        private class Node
        {
            public T Value { get; set; }
            public Node Next { get; }
        }
    }
}
