using MyDataStructure;

namespace Solutions._1448CountGoodNodesInBinaryTree;

public class Solution
{
    int count = 0;

    public int GoodNodes(TreeNode root)
    {
        Traversal(root, Int32.MinValue);
        return count;
    }

    private void Traversal(TreeNode node, int max)
    {
        if (node == null) return;
        if (node.val >= max) count++;
        max = Math.Max(max, node.val);
        
        Traversal(node.left, max);
        Traversal(node.right, max);
    }
}