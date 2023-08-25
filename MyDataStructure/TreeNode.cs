namespace MyDataStructure;

public class TreeNode
{
    public int val { get; set; }
    public TreeNode? left { get; set; }
    public TreeNode? right { get; set; }

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public static class ArrayToTreeExt
{
    public static TreeNode ArrayToTree(this int?[] array)
    {
        TreeNode root = InsertLevelOrder(array, 0);
        return root;
    }

    private static TreeNode InsertLevelOrder(int?[] arr, int i)
    {
        TreeNode root = null;
        // Base case for recursion
        if (i < arr.Length && arr[i] != null)
        {
            root = new TreeNode(arr[i].Value);


            // insert left child
            root.left = InsertLevelOrder(arr, 2 * i + 1);

            // insert right child
            root.right = InsertLevelOrder(arr, 2 * i + 2);
        }

        return root;
    }
}