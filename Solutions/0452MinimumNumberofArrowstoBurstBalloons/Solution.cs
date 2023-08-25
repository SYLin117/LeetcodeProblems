namespace Solutions._0452MinimumNumberofArrowstoBurstBalloons;

public class Solution
{
    public int FindMinArrowShots(int[][] points)
    {
        Array.Sort(points, (int[] a, int[] b) => a[1] - b[1]); //sort by end
        int arrow = 1;
        int arrowPos = points[0][1];
        for (int i = 0; i < points.Length; i++)
        {
            if (points[i][0] <= arrowPos) continue; // is include in interval
            arrowPos = points[i][1]; // meet new balloon not in range
            arrow++; // new arrow
        }

        return arrow;
    }
}