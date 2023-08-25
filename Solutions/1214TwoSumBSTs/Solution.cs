using MyDataStructure;

namespace Solutions._1214TwoSumBSTs;

public class Solution
{
    public bool TwoSumBSTs(TreeNode root1, TreeNode root2, int target)
    {
        if (root1 == null || root2 == null) return false;
        int sum = root1.val + root2.val;
        if (sum == target) return true;
        else if (sum > target) return TwoSumBSTs(root1.left, root2, target) || TwoSumBSTs(root1, root2.left, target);
        else return TwoSumBSTs(root1.right, root2, target) || TwoSumBSTs(root1, root2.right, target);
    }
}