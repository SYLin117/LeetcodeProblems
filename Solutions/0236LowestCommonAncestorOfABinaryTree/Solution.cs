using MyDataStructure;

namespace Solutions._0236LowestCommonAncestorOfABinaryTree;

public class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root == null || root == p || root == q)
        {
            return root;
        }

        var left = LowestCommonAncestor(root.left, p, q);
        var right = LowestCommonAncestor(root.right, p, q);
        if (left == null && right == null)
        {
            return null;
        }
        else if (left != null && right == null)
        {
            return left;
        }
        else if (left == null && right != null)
        {
            return right;
        }
        else // left!=null && right != null
        {
            return root;
        }
    }
}