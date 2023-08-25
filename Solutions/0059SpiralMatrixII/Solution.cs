namespace Solutions._0059SpiralMatrixII;

public class Solution
{
    public int[,] GenerateMatrix(int n)
    {
        int[,] result = new int[n, n];
        int startx = 0, starty = 0; // 定义每循环一个圈的起始位置
        int loop = n / 2; // 每个圈循环几次，例如n为奇数3，那么loop = 1 只是循环一圈，矩阵中间的值需要单独处理
        int mid = n / 2; // 矩阵中间的位置，例如：n为3， 中间的位置就是(1，1)，n为5，中间位置为(2, 2)
        int count = 1; // 用来给矩阵中每一个空格赋值
        int offset = 1; // 需要控制每一条边遍历的长度，每次循环右边界收缩一位
        while (loop > 0)
        {
            int i = startx; // col
            int j = starty; // row
            for (i = startx; i <= (n - 1 - offset); i++)
            {
                result[starty, i] = count++;
            }

            for (j = starty; j <= (n - 1 - offset); j++)
            {
                result[j, i] = count++;
            }

            for (; i > offset - 1; i--)
            {
                result[j, i] = count++;
            }

            for (; j > offset - 1; j--)
            {
                result[j, i] = count++;
            }

            startx++;
            starty++;
            loop--;
            offset++;
        }

        if (n % 2 != 0)
        {
            result[mid, mid] = count;
        }

        return result;
    }
}