using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorythmsLab3.Structures.LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        public LinkedList(IEnumerable<T> collection)
        {
            foreach (var value in collection)
            {
                Add(value);
            }
        }

        public LinkedList()
        {
            Head = Tail = null;
        }

        public INode<T> Head { get; private set; }
        public INode<T> Tail { get; private set; }
        public int Count { get; private set; }

        public INode<T> this[int index] => Find(index);

        private INode<T> Find(int index)
        {
            if (Head == null)
            {
                return null;
            }

            INode<T> node = Head;
            for (int i = 0; i < index; i++)
            {
                node = node.Next;
            }

            return node;
        }

        public void Add(T element)
        {
            if (Head == null)
            {
                Head = Tail = new LinkedListNode<T>(element);
            }
            else
            {
                INode<T> node = new LinkedListNode<T>(element);
                Tail.Next = node;
                node.Prev = Tail;
                Tail = node;
            }

            Count++;
        }

        public void AddToStart(T element)
        {
            if (Head == null)
            {
                Head = Tail = new LinkedListNode<T>(element);
            }
            else
            {
                INode<T> node = new LinkedListNode<T>(element);
                Head.Prev = node;
                node.Next = Head;
                Head = node;
            }

            Count++;
        }

        public void RemoveFromStart()
        {
            if (Head == Tail)
            {
                Head = Tail = null;
            }
            else
            {
                Head.Next.Prev = null;
                Head = Head.Next;
            }

            Count--;
        }

        public void RemoveFromEnd()
        {
            if (Head == Tail)
            {
                Head = Tail = null;
            }
            else
            {
                Tail.Prev.Next = null;
                Tail = Tail.Prev;
            }

            Count--;
        }

        public void AddOnPosition(T data, int position)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(data);

            if (Head == null)
            {
                Head = node;
                Count++;
            }
            else
            {
                var currentElement = Find(position);
                node.Prev = currentElement.Prev;
                node.Next = currentElement;
                currentElement.Prev = node;
            }
        }

        private void AddAfter(INode<T> nodeBefore, INode<T> newNode)
        {
            newNode.Next = nodeBefore.Next;
            newNode.Prev = nodeBefore;
            nodeBefore.Next = newNode;
            ++Count;
        }

        private void AddBefore(INode<T> nodeAfter, INode<T> newNode)
        {
            if (nodeAfter == Head)
            {
                newNode.Next = nodeAfter;
                nodeAfter.Prev = newNode;
                Head = newNode;
            }
            else
            {
                newNode.Next = nodeAfter;
                newNode.Prev.Next = newNode;
                newNode.Prev = nodeAfter.Prev;
                nodeAfter.Prev = newNode;
            }

            ++Count;
        }

        public override string ToString()
        {
            List<T> list = new List<T>();
            foreach (var value in this)
            {
                list.Add(value);
            }

            return string.Join(" ", list);
        }


        public LinkedList<T> Reverse() // Задание 4.1 
        {
            LinkedList<T> list = new LinkedList<T>();
            foreach (var element in this)
            {
                list.AddToStart(element);
            }

            return list;
        }

        public void SwapFirstAndLast() // Задание 4.2
        {
            var first = Head;
            var second = Tail;
            RemoveFromStart();
            AddToStart(second.Value);
            RemoveFromEnd();
            Add(first.Value);
        }

        public int CountWhole() //Задание 4.3
        {
            List<T> differentElement = new List<T>();

            foreach (var value in this)
            {
                if (!differentElement.Contains(value))
                {
                    differentElement.Add(value);
                }
            }

            return differentElement.Count;
        }

        public void RemovingSecondElement() // задание 4.4
        {
            Dictionary<T, int> countDifferentElements = new Dictionary<T, int>();
            for (int i = 0; i < Count; i++)
            {
                var node = this[i];
                if (!countDifferentElements.ContainsKey(node.Value))
                {
                    countDifferentElements.Add(node.Value, 1);
                }
                else
                {
                    if (countDifferentElements[node.Value] == 1)
                    {
                        Remove(i);
                    }

                    countDifferentElements[node.Value]++;
                }
            }
        }

        public void Clear()
        {
            Head = Tail = null;
            Count = 0;
        }

        public void PasteYourself(T elementInsert) // Задание 4.5
        {
            if (Head == null)
            {
                Add(elementInsert);
                return;
            }

            int index = 0;
            for (int i = 0; i < Count; i++)
            {
                INode<T> node = this[i];
                if (node.Value.Equals(elementInsert))
                {
                    index = i;
                    break;
                }
            }

            var list = new LinkedList<T>(this);
            for (int i = 0; i < list.Count; i++)
            {
                var newNode = new LinkedListNode<T>(this[i].Value);
                AddAfter(list[i + index], newNode);
            }

            Clear();
            foreach (var value in list)
            {
                Add(value);
            }
        }

        public void InsertElementByOrder(T element) // Задание 4.6
        {
            var node = new LinkedListNode<T>(element);
            for (int i = 0; i < Count - 1; i++)
            {
                var current = this[i];
                var nextNode = this[i + 1];
                if (node.Value.GetHashCode() >= current.Value.GetHashCode()
                    && node.Value.GetHashCode() < nextNode.Value.GetHashCode())
                {
                    AddAfter(current, node);
                    break;
                }
                else if (node.Value.GetHashCode() < current.Value.GetHashCode())
                {
                    AddBefore(current, node);
                    break;
                }

                if (i == Count - 2 && nextNode.Value.GetHashCode() < node.Value.GetHashCode())
                {
                    AddAfter(nextNode, node);
                }
            }
        }

        public void Remove(int index)
        {
            var node = this[index];
            if (node == Head)
            {
                var next = node.Next;
                next.Prev = null;
                Head = next;
            }
            else if (node == Tail)
            {
                var prev = node.Prev;
                prev.Next = null;
                Tail = prev;
            }
            else
            {
                var prev = node.Prev;
                var next = node.Next;

                prev.Next = next;

                next.Prev = prev;
            }

            Count--;
        }

        public void RemoveElements(T element) // Задание 4.7
        {
            for (int i = 0; i < Count; i++)
            {
                var node = this[i];
                if (node.Value.Equals(element))
                {
                    Remove(i);
                }
            }
        }

        public void Insert(T elementE, T elementF) //Задание 4.8
        {
            var newNode = new LinkedListNode<T>(elementF);
            for (int i = 0; i < Count; i++)
            {
                var node = this[i];
                if (node.Value.Equals(elementE))
                {
                    AddAfter(node.Prev, newNode);
                    break;
                }
            }
        }

        public void Concat(IEnumerable<T> listSecond) // Задание 4.9
        {
            foreach (var value in listSecond)
            {
                Add(value);
            }
        }

        public (LinkedList<T>, LinkedList<T>) Split(T value) // Задание 4.10
        {
            LinkedList<T> first = new LinkedList<T>();
            LinkedList<T> second = new LinkedList<T>();
            bool toFirst = true;
            for (int i = 0; i < Count; i++)
            {
                INode<T> node = this[i];
                if (toFirst)
                {
                    first.Add(node.Value);
                    if (node.Value.Equals(value))
                    {
                        toFirst = false;
                    }
                }
                else
                {
                    second.Add(node.Value);
                }
            }

            return (first, second);
        }


        public void DoublingList() // Задание 4.11
        {
            var list = new LinkedList<T>(this);
            foreach (var value in list)
            {
                Add(value);
            }
        }

        public void Swap(T item1, T item2) // Задание 4.12
        {
            INode<T> node1 = null;
            INode<T> node2 = null;
            for (int i = 0; i < Count; i++)
            {
                var node = this[i];
                if (node.Value.Equals(item1))
                {
                    node1 = node;
                }

                if (node.Value.Equals(item2))
                {
                    node2 = node;
                }
            }

            if (node1 == null || node2 == null)
            {
                throw new ArgumentException("The specified elements are missing");
            }

            (node1.Value, node2.Value) = (node2.Value, node1.Value);
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) this).GetEnumerator();
        }
    }
}