using System;

public class Node
{
    public Node left;
    public Node right;
    public int val;

    public Node(int val, Node left = null, Node right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Program
{
    public static int Search(Node current, int max)
    {
        if(current.left != null)
        {
            max = Search(current.left, max);
        }

        if(current.right != null)
        {
            max = Search(current.right, max);
        }

        return current.val > max ? current.val : max;
    }
    public static void Main()
    {
        Node tree = new Node(
            5,
            new Node(7, new Node(4, null, null), new Node(3, null, null)),
            new Node(10, new Node(2, null, null), new Node(13, null, null))
        );
        int res = Search(tree, tree.val);
        Console.WriteLine(res);
    }
}
