using MyDataStructure;

namespace Solutions._0437PathSumIII;

public class Solution
{
    public int PathSum(TreeNode root, int targetSum)
    {
        if (root == null) return 0;
        return Helper(root, targetSum) +
               PathSum(root.left, targetSum) + // left child as root
               PathSum(root.right, targetSum); // right child as root
    }

    private int Helper(TreeNode node, long sum)
    {
        if (node == null) return 0;
        return (sum - node.val == 0 ? 1 : 0) + Helper(node.left, sum - node.val) + Helper(node.right, sum - node.val);
    }
}