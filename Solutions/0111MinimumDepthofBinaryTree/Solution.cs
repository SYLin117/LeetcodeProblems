using MyDataStructure;

namespace Solutions._0111MinimumDepthofBinaryTree;

public class Solution
{
    public int MinDepth(TreeNode root)
    {
        return PathToLeaf(root);
    }

    private int PathToLeaf(TreeNode node)
    {
        if (node == null) return 0;
        if (node.left == null && node.right == null) return 1;
        if (node.left == null) return 1 + PathToLeaf(node.right);
        if (node.right == null) return 1 + PathToLeaf(node.left);
        return 1 + Math.Min(PathToLeaf(node.left), PathToLeaf(node.right));
    }
}