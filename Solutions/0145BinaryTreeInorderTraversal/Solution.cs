using MyDataStructure;

namespace Solutions._0145BinaryTreePostorderTraversal;

public class Solution
{
    private IList<int> result;

    public IList<int> PostorderTraversal(TreeNode root)
    {
        result = new List<int>();
        Traversal(root);
        return result;
    }

    private void Traversal(TreeNode node)
    {
        if (node == null) return;
        Traversal(node.left);

        Traversal(node.right);
        result.Add(node.val);
    }
}