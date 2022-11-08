using AlgorythmsLab3.Structures;

namespace AlgorythmsLab3.ThirdPart
{
    public class TreeExample
    {
        public static int Example(Tree root)
        {
            if (root == null) return 0;
            return root.Value + Example(root.Left) + Example(root.Right);
        }
    }
}