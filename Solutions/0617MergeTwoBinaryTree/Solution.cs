using MyDataStructure;

namespace Solutions._0617MergeTwoBinaryTree;

public class Solution
{
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
    {
        var head = Dfs(root1, root2);
        return head;
    }

    public TreeNode Dfs(TreeNode node1, TreeNode node2)
    {
        if (node1 == null && node2 != null) return node2;
        if (node1 != null && node2 == null) return node1;
        if (node1 == null && node2 == null) return null;
        var newNode = new TreeNode(node1.val + node2.val);
        newNode.left = Dfs(node1.left, node2.left);
        newNode.right = Dfs(node1.right, node2.right);
        return newNode;
    }
}