using System.ComponentModel;
using MyDataStructure;

namespace Solutions._0226InvertBinaryTree;

public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return root;
        Swap(root);
        InvertTree(root.left);
        InvertTree(root.right);
        return root;
    }

    private void Swap(TreeNode node)
    {
        var tmp = node.left;
        node.left = node.right;
        node.right = tmp;
    }
}