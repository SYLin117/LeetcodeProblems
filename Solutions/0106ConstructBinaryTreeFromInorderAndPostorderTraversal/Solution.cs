using MyDataStructure;

namespace Solutions._0106ConstructBinaryTreeFromInorderAndPostorderTraversal;

public class Solution
{
    private IDictionary<int, int> dict = new Dictionary<int, int>();

    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        for (int i = 0; i < inorder.Length; i++)
        {
            dict.Add(inorder[i], i);
        }

        var root = FindNode(inorder, 0, inorder.Length, postorder, 0, postorder.Length);
        return root;
    }

    /// <summary>
    /// left close right open(not inlcude)
    /// </summary>
    /// <param name="inorder">inorder array</param>
    /// <param name="inBegin">start of inorder</param>
    /// <param name="inEnd">end of inorder (not include)</param>
    /// <param name="postorder"></param>
    /// <param name="postBegin"></param>
    /// <param name="postEnd"></param>
    /// <returns></returns>
    private TreeNode FindNode(int[] inorder, int inBegin, int inEnd, int[] postorder, int postBegin, int postEnd)
    {
        if (inBegin >= inEnd || postBegin >= postEnd)
        {
            return null;
        }

        var rootVal = postorder[postEnd - 1];
        TreeNode rootNode = new TreeNode(rootVal);
        var inRootIndex = dict[rootVal];
        var lenOfLeft = inRootIndex - inBegin;

        rootNode.left = FindNode(inorder, inBegin, inRootIndex, postorder, postBegin, postBegin + lenOfLeft);
        // postEnd-1 because root node is remove
        rootNode.right = FindNode(inorder, inRootIndex + 1, inEnd, postorder, postBegin + lenOfLeft, postEnd - 1);
        return rootNode;
    }
}