namespace Solutions._0011ContainerWithMostWater;

public class Solution
{
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int max = 0;
        while (left < right)
        {
            var tmp = (right - left) * Math.Min(height[left], height[right]);
            if (tmp > max) max = tmp;
            if (height[left] > height[right])
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return max;
    }
}