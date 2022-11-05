namespace AlgorythmsLab3.Structures.LinkedList
{
    public class LinkedListNode<T> : INode<T>
    {
        public LinkedListNode(T value)
        {
            Value = value ?? default(T);
        }

        public T Value { get; set; }
        public INode<T> Next { get; set; }
        public INode<T> Prev { get; set; }
    }
}