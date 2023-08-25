namespace Solutions._0018FourSum;

public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);

        for (int k = 0; k < nums.Length; k++)
        {
            // 剪枝处理(因為sort過，如果第一個就大於零就不可能等於零)
            if (nums[k] > target && nums[k] >= 0)
            {
                break; // 这里使用break，统一通过最后的return返回
            }

            // 对nums[k]去重
            if (k > 0 && nums[k] == nums[k - 1])
            {
                continue;
            }

            for (int i = k + 1; i < nums.Length; i++)
            {
                // 2级剪枝处理 (如果當前大魚target且之後的數也大於零就不可能滿足和等於target)
                if (nums[k] + nums[i] > target && nums[k] + nums[i] >= 0)
                {
                    break;
                }

                // 对nums[i]去重
                if (i > k + 1 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int left = i + 1;
                int right = nums.Length - 1;
                while (right > left)
                {
                    // nums[k] + nums[i] + nums[left] + nums[right] > target 会溢出
                    if ((long)nums[k] + nums[i] + nums[left] + nums[right] > target)
                    {
                        right--;
                        // nums[k] + nums[i] + nums[left] + nums[right] < target 会溢出
                    }
                    else if ((long)nums[k] + nums[i] + nums[left] + nums[right] < target)
                    {
                        left++;
                    }
                    else
                    {
                        result.Add(new List<int>() { nums[k], nums[i], nums[left], nums[right] });
                        // 对nums[left]和nums[right]去重
                        while (right > left && nums[right] == nums[right - 1]) right--;
                        while (right > left && nums[left] == nums[left + 1]) left++;

                        // 找到答案时，双指针同时收缩
                        right--;
                        left++;
                    }
                }
            }
        }

        return result;
    }
}