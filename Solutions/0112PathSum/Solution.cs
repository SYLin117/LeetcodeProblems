using MyDataStructure;

namespace Solutions._0112PathSum;

public class Solution
{
    private Stack<int> stack = new();
    private bool result = false;

    public bool HasPathSum(TreeNode root, int targetSum)
    {
        Dfs(root, targetSum);
        return result;
    }

    private void Dfs(TreeNode node, int targetSum)
    {
        if (node == null) return;
        stack.Push(node.val);
        if (stack.Sum() == targetSum && node.left == null && node.right == null)
        {
            result = true;
            return;
        }

        Dfs(node.left, targetSum);
        Dfs(node.right, targetSum);
        stack.Pop();
    }
}