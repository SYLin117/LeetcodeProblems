using MyDataStructure;

namespace Solutions._0110BalancedBinaryTree;

public class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        if (root == null) return true;
        var leftValid = IsBalanced(root.left);
        var rightValid = IsBalanced(root.right);
        int diff = Math.Abs(GetNodeHeight(root.left) - GetNodeHeight(root.right));
        return leftValid && rightValid && diff < 2;
    }

    public int GetNodeHeight(TreeNode node)
    {
        if (node == null) return 0;
        return 1 + Math.Max(GetNodeHeight(node.left), GetNodeHeight(node.right));
    }
}