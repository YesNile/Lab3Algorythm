using System;

namespace AlgorythmsLab3.Structures
{
    public class Tree
    {
        public int Value;
        public int Count;
        public Tree Left;
        public Tree Right;

        public void Insert(int value)
        {
            if (this.Value == null) this.Value = value;
            else
            {
                if (this.Value.CompareTo(value) == 1)
                {
                    if (Left == null) this.Left = new Tree();
                    Left.Insert(value);
                }
                else if (this.Value.CompareTo(value) == -1)
                {
                    if (Right == null) this.Right = new Tree();
                    Right.Insert(value);
                }
                else throw new Exception("Node doesn't exist");
            }
            this.Count = Recount(this);
        }

        public Tree Search(int value)
        {
            if (this.Value == value) return this;
            else if (this.Value.CompareTo(value) == 1)
            {
                if (Left != null) return this.Left.Search(value);
                else throw new Exception("Node doesn't exist");
            }
            else
            {
                if (Right != null) return this.Right.Search(value);
                else throw new Exception("Node doesn't exist");
            }
        }

        public string Display(Tree tree)
        {
            string result = "";
            if (tree.Left != null) result += Display(tree.Left);

            result += tree.Value + " ";

            if (tree.Right != null) result += Display(tree.Right);

            return result;
        }

        private int Recount(Tree tree)
        {
            int count = 0;
            if (tree.Left != null) count += Recount(tree.Left);
            count++;

            if (tree.Right != null) count += Recount(tree.Right);
            return count;
        }

        public void Clear()
        {
            this.Value = 0;
            this.Left = null;
            this.Right = null;
        }

        public bool IsEmpty() => this.Value == null ? true : false;
    }
}