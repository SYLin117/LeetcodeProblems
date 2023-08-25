using MyDataStructure;

namespace Solutions._0101SummetricTree;

public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        return IsSym(root.left, root.right);
    }

    private bool IsSym(TreeNode head1, TreeNode head2)
    {
        if (head1 == null && head2 != null) return false;
        if (head1 != null && head2 == null) return false;
        if (head1 == null && head2 == null) return true;
        return (head1.val == head2.val && IsSym(head1.left, head2.right) && IsSym(head1.right, head2.left));
    }
}