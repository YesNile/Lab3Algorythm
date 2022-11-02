using System.Collections;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;


namespace AlgorhythmsLab3;

public class LinkedList<T> : IEnumerable<T>
{

    public Node<T> Head { get; set; }
    public Node<T> Tail { get; set; }
    public int Count { get; private set; }

    public void AddToEnd(T element)
    {
        if (Head == null && Tail == null)
        {
            Head = Tail = new Node<T>(element);
        } else {
            Node<T> node = new Node<T>(element);
            Tail.Next = node;
            node.Previous = Tail;
            Tail = node;
        }

        Count++;
    }
        
    public void AddToStart(T element)
    {
        if (Head == null && Tail == null)
        {
            Head = Tail = new Node<T>(element);
        }
        else
        {
            Node<T> node = new Node<T>(element);
            Head.Previous = node;
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
            Head.Next.Previous = null;
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
            Tail.Previous.Next = null;
            Tail = Tail.Previous;
        }

        Count--;
    }

    public void AddPosition(T data, int position)
    {
        Node<T> currentElement = Head;
        Node<T> previous = null;
        LinkedList<T>.Node<T> node = new Node<T>(data);
        var countNum = 0;

        if (Head == null)
        {
            Head = node;
            Count++;
            return;
        }

        if (position == 0)
        {
            node.Next = Head;
            Head = node;
            Count++;
            return;
        }

        if (position == Count)
        {
            Tail.Next = node;
            Tail = node;
            Count++;
            return;
        }

        while (currentElement != null && countNum < Count)
        {
            if (countNum == position)
            {
                previous.Next = node;
                node.Next = currentElement;
                Count++;
                return;
            }
            countNum++;
            previous = currentElement;
            currentElement = currentElement.Next;
        }
    }

    public override string ToString()
    {
        List<Node<T>> list = new List<Node<T>>();
        Node<T> node = Head;
        do
        {
            list.Add(node);
            node = node?.Next;
        } while (node != null);

        return string.Join(" ", list);
    }

 
    public LinkedList<T> Reverse() // Задание 4.1 
    {
        LinkedList<T> list = new LinkedList<T>();
        foreach(var element in this)
        {
            list.AddToStart(element);
        }
        return list;
    }
    public void SwapFirstAndLast() // Задание 4.2
    {
        var first = this.Head.Element;
        var second = this.Tail.Element;
        this.RemoveFromStart();
        this.AddToStart(second);
        this.RemoveFromEnd();
        this.AddToEnd(first);
    }

    public int CountWhole() //Задание 4.3
    {
          Node<T> node = Head;
          Dictionary<T, bool> contained = new Dictionary<T, bool>();
          int countNumbers = 0;

          while (node != null)
          {
              if (!contained.ContainsKey(node.Element))
              {
                  contained.Add(node.Element, true);
                  countNumbers++;
              }
            node = node.Next;
          }

          return countNumbers;
        
    }
    public void RemovingSecondElement(T element) // задание 4.4
    {
        var node = Head;
        List<Node<T>> listNode = new List<Node<T>>();
        for (int i = 0; i < Count; i++)
        {
            if (node.Element.Equals(element))
            {
                listNode.Add(node);
            }
            node = node.Next;
        }
        var removedNode = listNode[1];
        removedNode.Next.Previous = removedNode.Previous;
        removedNode.Previous.Next = removedNode.Next;
        Count--;
    }

    public void ListPasteYourself(T elementInsert) // Задание 4.5
    {
        {
            LinkedList<T>.Node<T> currentElement = Head;
            Node<T> previous = null;
            var countOld = Count;
            var countNew = 0;

            do
            {
                if (previous != null && previous.Element.Equals(elementInsert))
                {
                    var previousNode = Head;
                    var previousCount = countNew;
                    for (var i = 0; i < previousCount; i++)
                    {
                        AddPosition(previousNode.Element, countNew);
                        countNew++;
                        previousNode = previousNode.Next;
                    }

                    var afterNode = currentElement;
                    for (var i = countNew; i < countOld - previousCount + countNew; i++)
                    {
                        AddPosition(afterNode.Element, i);
                        afterNode = afterNode.Next;
                    }

                    break;
                }

                countNew++;
                previous = currentElement;
                currentElement = currentElement.Next;
            } while (previous != null);
        }
    }

    public void RemoveElement(T element) // Задание 4.7
    {
        var node = Head;
        List<Node<T>> listNode = new List<Node<T>>();
        Console.WriteLine(ToString());
        for (int i = 0; i < Count; i++)
        {
            if (node.Element.Equals(element))
            {
                listNode.Add(node);
            }
            node = node.Next;
        }
        for (int i = 0; i < listNode.Count; i++)
        {
            var removedNode = listNode[i];
            removedNode.Next.Previous = removedNode.Previous;
            removedNode.Previous.Next = removedNode.Next;
            Count--;
        }
    }

    public void Insert(T ElementE, T ElementF) //Задание 4.8
    {
        Node<T> node = Head;
        Node<T> elementF = new Node<T>(ElementF);
        for (int i = 0; i < Count; i++)
        {
            if (node.Element.Equals(ElementE))
            {
                break;
            }
            node = node.Next;
        }
        elementF.Next = node;
        elementF.Previous = node.Previous;
        node.Previous.Next = elementF;
    }
    public void AddList(List<T> listSecond) // Задание 4.9
    {
        for (int i = 0; i < listSecond.Count; i++)
        {
            AddToEnd(listSecond[i]);
        }
    }

    
    public void DoublingList() // Задание 4.11
    {
        Node<T> node = Head;
        int count = Count;
        for (int i = 0; i < count; i++)
        {
            AddToEnd(node.Element);
            node = node.Next;
        }
    }
    public void Swap(T item1, T item2) // Задание 4.12
    {
        Node<T> node = Head;
        Node<T> node1 = null;
        Node<T> node2 = null;
        for (int i = 0; i < Count; i++)
        {
            if (node.Element.Equals(item1))
            {
                node1 = node;
            }
            if (node.Element.Equals(item2))
            {
                node2 = node;
            }
            node = node.Next;
        }
        if (node1 == null || node2 == null)
        {
            throw new Exception("No element");
        }
        else
        {
            var nodeFirst = new Node<T>(node1.Element);
            var nodeSecond = new Node<T>(node2.Element);
            nodeFirst.Next = node2.Next;
            nodeSecond.Next = node1.Next;
            nodeFirst.Previous = node2.Previous;
            nodeSecond.Previous = node1.Previous;
            node1.Previous.Next = nodeSecond;
            node1.Next.Previous = nodeSecond;
            node2.Previous.Next = nodeFirst;
            node2.Next.Previous = nodeFirst;
        }
    }



    // public int FindDistinctValueCount<T>()where T:struct
    // {
    //     if (T is not int)
    //     {
    //         throw new Exception("Не целочисленный тип");
    //     }
    //     // int count = 0;
    //     // List<int> xz = new List<int>();
    //     // foreach (var t in this)
    //     // {
    //     //     if ())
    //     //     {
    //     //         
    //     //     }
    //     // }
    //
    //     return 1;
    // }

    public IEnumerator<T> GetEnumerator()
    {
        var current = Head;
        while(current != null)
        {
            yield return current.Element;
            current = current.Next;
        }
    }
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)this).GetEnumerator();
    }

    public class Node<T>
    {
        public Node(T element)
        {
            if(element == null)
            {
                throw new ArgumentNullException(nameof(element));
            }
            Element = element;
        }

        public T Element { get; set; }
        public Node<T> Previous { get; set; }
        public Node<T> Next { get; set; }
        

        public override string ToString()
        {
            return Element.ToString();
        }
    }
}