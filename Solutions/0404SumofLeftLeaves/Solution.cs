using MyDataStructure;

namespace Solutions._0404SumofLeftLeaves;

public class Solution
{
    private int result = 0;

    public int SumOfLeftLeaves(TreeNode root)
    {
        Dfs(root, false);
        return result;
    }

    public void Dfs(TreeNode node, bool isLeft)
    {
        if (node == null) return;
        if (isLeft && node.left == null && node.right == null)
        {
            result += node.val;
            return;
        }

        Dfs(node.left, true);
        Dfs(node.right, false);
    }
}