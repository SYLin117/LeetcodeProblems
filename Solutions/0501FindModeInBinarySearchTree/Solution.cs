using MyDataStructure;

namespace Solutions._0501FindModeInBinarySearchTree;

public class Solution
{
    IList<int> resList;
    int maxCount;
    int count;
    TreeNode pre;

    public int[] FindMode(TreeNode root)
    {
        resList = new List<int>();
        maxCount = 0;
        count = 0;
        pre = null;
        findMode1(root);
        int[] res = new int[resList.Count];
        for (int i = 0; i < resList.Count; i++)
        {
            res[i] = resList[i];
        }

        return res;
    }

    /// <summary>
    /// 使用中序
    /// </summary>
    /// <param name="root">當前的node</param>
    public void findMode1(TreeNode root)
    {
        if (root == null)
        {
            return;
        }

        findMode1(root.left);

        int rootValue = root.val;
        // 计数
        if (pre == null || rootValue != pre.val)
        {
            count = 1;
        }
        else
        {
            count++;
        }

        // 更新结果以及maxCount
        if (count > maxCount)
        {
            resList.Clear();
            resList.Add(rootValue);
            maxCount = count;
        }
        else if (count == maxCount)
        {
            resList.Add(rootValue);
        }

        pre = root;

        findMode1(root.right);
    }
}