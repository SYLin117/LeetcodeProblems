using MyDataStructure;

namespace Solutions._0102BinaryTreeLevelOrderTraversal;

public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        if (root == null) return result;
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            List<int> layer = new List<int>();
            var currentSize = queue.Count;
            for (int i = 0; i < currentSize; i++)
            {
                var tmp = queue.Dequeue();
                layer.Add(tmp.val);

                if (tmp.left != null) queue.Enqueue(tmp.left);
                if (tmp.right != null) queue.Enqueue(tmp.right);
            }

            result.Add(layer);
        }

        return result;
    }
}