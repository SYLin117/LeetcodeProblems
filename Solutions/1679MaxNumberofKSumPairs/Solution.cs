namespace Solutions._1679MaxNumberofKSumPairs;

public class Solution
{
    public int MaxOperations(int[] nums, int k)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            dict[num] = dict.GetValueOrDefault(num) + 1;
        }

        int result = 0;
        foreach (var pair in dict)
        {
            var val1 = pair.Key;
            var val2 = k - val1;
            // skip duplicate consider, for example: if 1 already consider 3 then 3 should consider 1 again
            if (val2 < val1) continue;
            if (val1 != val2)
                result += Math.Min(pair.Value, dict.GetValueOrDefault(val2));
            else
                result += pair.Value / 2;
        }

        return result;
    }
}