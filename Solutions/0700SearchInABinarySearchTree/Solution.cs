using MyDataStructure;

namespace Solutions._0700SearchInABinarySearchTree;

public class Solution
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        if (root == null) return null;
        if (root.val == val) return root;
        if (val < root.val) return SearchBST(root.left, val);
        else return SearchBST(root.right, val);
    }
}