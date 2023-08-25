using MyDataStructure;

namespace Solutions._0235LowestCommonAncestorofaBinarySearchTree;

public class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        var val = root.val;
        if (val < p.val && val < q.val) return LowestCommonAncestor(root.right, p, q);
        else if (val > p.val && val > q.val) return LowestCommonAncestor(root.left, p, q);
        else
        {
            return root;
        }
    }
}