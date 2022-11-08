using System;
using System.Diagnostics.CodeAnalysis;
using AlgorythmsLab3.Structures.LinkedList;

namespace AlgorythmsLab3
{

    public class Queue<T>
    {

        private readonly LinkedList<T> _list = new LinkedList<T>();

        public bool IsEmpty => _list.Count == 0;

        public int Count => _list.Count;

        public void Enqueue(T element)
        {
            _list.Add(element);
        }

        public object Peek()
        {
            return _list.Head;
        }

        public T Dequeue()
        {
            T output = _list.Head.Value;
            _list.RemoveFromStart();
            return output;
        }

        public T First()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Queue is Empty!");
            }
            return _list.Head.Value;
        }
        
        public void Print()
        {
            foreach (var elem in _list)
            {
                Console.Write($"{elem} ");
            }
        }

        public override string ToString()
        {
            return string.Join(", ", _list);
        }
    }
}