using MyDataStructure;

namespace Solutions._0257BinaryTreePaths;

public class Solution
{
    private IList<string> result;

    public IList<string> BinaryTreePaths(TreeNode root)
    {
        result = new List<string>();
        var path = new List<int>();
        IsLeaf(root, path);
        return result;
    }

    private void IsLeaf(TreeNode node, IList<int> path)
    {
        if (node == null) return;
        if (node.left == null && node.right == null)
        {
            path.Add(node.val);
            result.Add(String.Join("->", path.ToArray()));
            path.RemoveAt(path.Count - 1);
            return;
        }

        path.Add(node.val);
        IsLeaf(node.left, path);
        IsLeaf(node.right, path);
        path.RemoveAt(path.Count - 1);
    }
}