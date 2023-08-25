using MyDataStructure;

namespace Solutions._0098ValidateBinarySearchTree;

public class Solution
{
    public bool IsValidBST(TreeNode root)
    {
        return validBST(Int64.MinValue, Int64.MaxValue, root);
    }

    private bool validBST(long lower, long upper, TreeNode root)
    {
        if (root == null) return true;
        if (root.val <= lower || root.val >= upper) return false;
        return validBST(lower, root.val, root.left) && validBST(root.val, upper, root.right);
    }
}