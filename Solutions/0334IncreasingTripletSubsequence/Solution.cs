namespace Solutions._0334IncreasingTripletSubsequence;

public class Solution
{
    public bool IncreasingTriplet(int[] nums)
    {
        int left = Int32.MaxValue;
        int mid = Int32.MaxValue;
        // figure out first two value
        // if there is a value greater than the first two then return true
        foreach (int x in nums) 
        {
            if (x <= left) left = x;
            else if (x <= mid) mid = x; // greater than left
            else return true; // greater than left and mid
        }

        return false;
    }
}