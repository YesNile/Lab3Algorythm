using System;
using AlgorythmsLab3.Structures.LinkedList;

namespace AlgorythmsLab3
{

    public class Stack<T>
    {

        private LinkedList<T> _list = new LinkedList<T>();

        public bool IsEmpty() =>  _list.Count == 0;

        public int Count()  => _list.Count;

        public void Push(T element)
        {
            _list.AddToStart(element);
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            INode<T> temp = _list.Head;
            _list.RemoveFromStart();
            return temp.Value;
        }

        public T Top()
        {
            if (IsEmpty()) throw new InvalidOperationException("Stack is empty");
            return _list.Head.Value;
        }

        public void Print()
        {
            foreach (var elem in _list)
            {
                Console.WriteLine(elem);
            }
        }

        public override string ToString()
        {
            return string.Join(", ", _list);
        }

        public T Peek()
        {
            return _list.Head.Value;
        }
    }
}