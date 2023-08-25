using MyDataStructure;

namespace Solutions._0222CountCompleteTreeNodes;

public class Solution
{
    public int CountNodes(TreeNode root)
    {
        return GetNodeNum(root);
    }

    public int GetNodeNum(TreeNode node)
    {
        if (node == null) return 0;
        return 1 + GetNodeNum(node.left) + GetNodeNum(node.right);
    }
}