namespace Solutions._0435Non_overlappingIntervals;

public class Solution
{
    public int EraseOverlapIntervals(int[][] intervals)
    {
        int currentEnd = Int32.MinValue;
        int result = 0;
        Array.Sort(intervals, (a, b) => { return a[1] - b[1]; }); // sort by finishing time

        // find the maximum valid interval (Greedy: choose every interval with earlier ending time)
        int end = intervals[0][1];
        int count = 1;
        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] >= end)
            {
                end = intervals[i][1];
                count++;
            }
        }
        
        return intervals.Length - count;
    }
}