namespace Solutions._0455AssignCookie;

public class Solution
{
    public int FindContentChirldren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);
        int idx = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= g[idx])
            {
                idx++;
            }

            if (!(idx < g.Length)) break;
        }

        return idx;
    }
}