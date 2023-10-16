int[] numbers = { 6, 3, 7, 5, 4, 8, 9, 10, 2, 1 };

Console.WriteLine("this is your array: ");
foreach (int number in numbers)
    Console.Write($"[{number}] ");

public class Node
{
    public int value;
    public Node right;
    public Node left;
}

class Tree
{
    public Node insert(Node root ,int data)
    {
        if (root == null)
        {
            root = new Node();
            root.value = data;
        }
        else if (root.value<data)
                root.right=insert(root.right ,data);

        else
            root.left=insert(root.left ,data);

        return root;

    }
}
