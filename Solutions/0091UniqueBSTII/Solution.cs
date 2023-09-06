using MyDataStructure;

namespace Solutions._0091UniqueBSTII;

public class Solution
{
    private List<TreeNode> result = new List<TreeNode>();

    public IList<TreeNode> GenerateTrees(int n)
    {
        List<TreeNode> ans = new List<TreeNode>();
        if (n == 0)
        {
            return ans;
        }

        return Backtracking(1, n);
    }

    public List<TreeNode> Backtracking(int start, int end)
    {
        List<TreeNode> ans = new List<TreeNode>();
        if (start > end)
        {
            ans.Add(null);
            return ans;
        }

        if (start == end)
        {
            ans.Add(new TreeNode(start));
            return ans;
        }

        for (int i = start; i <= end; i++) // iterate all node as root
        {
            List<TreeNode> leftTrees = Backtracking(start, i - 1);
            List<TreeNode> rightTrees = Backtracking(i + 1, end);
            foreach (TreeNode left in leftTrees)
            {
                foreach (TreeNode right in rightTrees)
                {
                    TreeNode root = new TreeNode(i);
                    root.left = left;
                    root.right = right;
                    ans.Add(root);
                }
            }
        }

        return ans;
    }
}