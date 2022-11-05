using System;

namespace AlgorythmsLab3
{

    public class Stack<T>
    {

        private LinkedList<T> list = new LinkedList<T>();

        public bool IsEmpty
        {
            get => list.Count == 0;
        }

        public int Count
        {
            get => list.Count;
        }

        public void Push(T element)
        {
            list.AddToStart(element);
        }

        public T Pop()
        {
            if (IsEmpty) throw new InvalidOperationException("Стек пуст!");
            LinkedList<T>.Node<T> temp = list.Head;
            list.RemoveFromStart();
            return temp.Element;
        }

        public T Top()
        {
            if (IsEmpty) throw new InvalidOperationException("Стек пуст!");
            return list.Head.Element;
        }

        public void Print()
        {
            foreach (var elem in list)
            {
                Console.WriteLine(elem);
            }
        }

        public override string ToString()
        {
            return string.Join(", ", list);
        }

        public T Peek()
        {
            return list.Head.Element;
        }
    }
}