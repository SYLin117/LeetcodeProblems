using MyDataStructure;

namespace Solutions._0513FindBottomLeftTreeValue;

public class Solution
{
    private int result = 0;

    public int FindBottomLeftValue(TreeNode root)
    {
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                var node = queue.Dequeue();
                if (i == 0) result = node.val;
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
        }

        return result;
    }
}