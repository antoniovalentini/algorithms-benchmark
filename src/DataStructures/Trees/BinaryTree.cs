namespace CodingChallengeCollection.DataStructures.Trees;

public class BinaryTree
{
    private TreeNode? _root;

    public BinaryTree()
    {
        _root = null;
    }

    public void Insert(int value)
    {
        _root = InsertRec(_root, value);
    }

    private TreeNode InsertRec(TreeNode? node, int value)
    {
        if (node == null)
        {
            return new TreeNode(value);
        }

        if (value < node.Value)
        {
            node.Left = InsertRec(node.Left, value);
        }
        else if (value > node.Value)
        {
            node.Right = InsertRec(node.Right, value);
        }

        return node; // return the unchanged node pointer
    }

    public bool Contains(int value)
    {
        return Contains(_root, value);
    }

    public static bool Contains(TreeNode? root, int value)
    {
        var current = root;
        while (current != null)
        {
            if (value == current.Value) return true;
            if (value < current.Value)
            {
                current = current.Left;
            }
            else
            {
                current = current.Right;
            }
        }
        return false;
    }
}

public class TreeNode
{
    public int Value { get; set; }

    public TreeNode? Left { get; set; }

    public TreeNode? Right { get; set; }

    public TreeNode(int value, TreeNode? left = null, TreeNode? right = null)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}