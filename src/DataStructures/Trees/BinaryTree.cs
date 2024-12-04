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

        if (value < node.val)
        {
            node.left = InsertRec(node.left, value);
        }
        else if (value > node.val)
        {
            node.right = InsertRec(node.right, value);
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
            if (value == current.val) return true;
            if (value < current.val)
            {
                current = current.left;
            }
            else
            {
                current = current.right;
            }
        }
        return false;
    }
}

public class TreeNode
{
    public int val { get; set; }

    public TreeNode? left { get; set; }

    public TreeNode? right { get; set; }

    public TreeNode(int val, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
