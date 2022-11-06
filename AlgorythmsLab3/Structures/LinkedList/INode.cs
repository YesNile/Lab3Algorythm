namespace AlgorythmsLab3
{
    public interface INode<T>
    {
        public T Value { get; set; }
        public INode<T> Next { get; set; }
        public INode<T> Prev { get; set; }
    }
}