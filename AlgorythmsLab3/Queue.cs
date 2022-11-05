using System;

namespace AlgorythmsLab3
{

    public class Queue<T>
    {

        private LinkedList<T> list = new LinkedList<T>();

        public bool IsEmpty
        {
            get => list.Count == 0;
        }

        public void Enqueue(T element)
        {
            list.AddToEnd(element);
        }

        public T Dequeue()
        {
            T output = list.Head.Element;
            list.RemoveFromStart();
            return output;
        }

        public T First()
        {
            if (IsEmpty) throw new InvalidOperationException("Очередь пуста!");
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
    }
}