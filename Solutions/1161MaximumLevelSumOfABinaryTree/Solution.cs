using MyDataStructure;

namespace Solutions._1161MaximumLevelSumOfABinaryTree;

public class Solution
{
    int minLevel = 1;
    int maxSum = Int32.MinValue;

    public int MaxLevelSum(TreeNode root)
    {
        int currentLevel = 1;
        Queue<TreeNode> q = new();
        q.Enqueue(root);
        while (q.Count > 0)
        {
            int currentSum = 0;
            int qCnt = q.Count;
            for (int i = 0; i < qCnt; i++)
            {
                var node = q.Dequeue();
                currentSum += node.val;
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                minLevel = currentLevel;
            }

            currentLevel++;
        }

        return minLevel;
    }
}