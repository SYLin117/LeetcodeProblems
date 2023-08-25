namespace Solutions._0216CombinationSumIII;

public class Solution
{
    private IList<IList<int>> result = new List<IList<int>>();
    private IList<int> path = new List<int>();

    public IList<IList<int>> CombinationSum3(int k, int n)
    {
        Backtrack(k, n, 1);
        return result;
    }

    private void Backtrack(int k, int n, int start)
    {
        if (path.Count == k && path.Sum() == n)
        {
            result.Add(new List<int>(path));
            return;
        }

        for (int i = start; i <= 9; i++)
        {
            var left = n - path.Sum();
            if (i > left) return;
            path.Add(i);
            Backtrack(k, n, i + 1);
            path.RemoveAt(path.Count - 1);
        }
    }
}