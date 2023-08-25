namespace Solutions._0163MissingRanges;

public class Solution
{
    public IList<IList<int>> FindMissingRanges(int[] nums, int lower, int upper)
    {
        List<int> numsLs = new List<int>();
        IList<IList<int>> result = new List<IList<int>>();

        if (nums.Length == 0)
        {
            result.Add(new List<int>() { lower, upper });
            return result;
        }

        numsLs.Add(lower);
        numsLs.AddRange(nums);
        numsLs.Add(upper);
        for (int i = 0; i < numsLs.Count - 1; i++)
        {
            if ((i == 0 && numsLs[i] != numsLs[i + 1]) || // start
                (i > 0 && numsLs[i] != numsLs[i + 1] && numsLs[i] + 1 != numsLs[i + 1]) ||
                (i == numsLs.Count - 2 && numsLs[i] != numsLs[i + 1])) // end
            {
                result.Add(new List<int>()
                {
                    (i == 0) ? numsLs[i] : numsLs[i] + 1, // start need to be included
                    (i + 1 == numsLs.Count - 1) ? numsLs[i + 1] : numsLs[i + 1] - 1 // upper need to be included
                });
            }
        }

        return result;
    }
}