using MyDataStructure;

namespace Solutions._0104MaximumDepthofBinaryTree;

public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        return CurrentDepth(root);
    }

    private int CurrentDepth(TreeNode node)
    {
        if (node == null) return 0;
        return 1 + Math.Max(CurrentDepth(node.left), CurrentDepth(node.right));
    }
}