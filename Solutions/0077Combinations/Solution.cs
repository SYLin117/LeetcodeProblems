namespace Solutions._0077Combinations;

public class Solution
{
    private IList<IList<int>> result = new List<IList<int>>();
    private IList<int> path = new List<int>();

    public IList<IList<int>> Combine(int n, int k)
    {
        Backtrack(n, k, 1);
        return result;
    }

    private void Backtrack(int n, int k, int start)
    {
        if (path.Count == k)
        {
            result.Add(new List<int>(path));
        }

        for (int i = start; i <= n; i++)
        {
            path.Add(i);
            Backtrack(n, k, i + 1);
            path.RemoveAt(path.Count - 1);
        }
    }
}