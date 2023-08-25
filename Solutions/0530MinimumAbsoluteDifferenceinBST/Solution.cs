using MyDataStructure;

namespace Solutions._0530MinimumAbsoluteDifferenceinBST;

public class Solution
{
    private IList<int> arr = new List<int>();

    public int GetMinimumDifference(TreeNode root)
    {
        InOrder(root);
        int result = Int32.MaxValue;
        for (int i = 0; i < arr.Count - 1; i++)
        {
            result = Math.Min(Math.Abs(arr[i] - arr[i + 1]), result);
        }

        return result;
    }

    private void InOrder(TreeNode node)
    {
        if (node == null) return;
        InOrder(node.left);
        arr.Add(node.val);
        InOrder(node.right);
    }
}