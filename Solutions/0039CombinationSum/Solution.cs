namespace Solutions._0039CombinationSum;

public class Solution
{
    private IList<IList<int>> result = new List<IList<int>>();
    private IList<int> path = new List<int>();

    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        Array.Sort(candidates);
        Backtracking(candidates, target, 0);
        return result;
    }

    private void Backtracking(int[] candidates, int target, int start)
    {
        if (path.Sum() == target)
        {
            result.Add(new List<int>(path));
            return;
        }

        if (candidates[start] > target - path.Sum()) return;

        for (int i = start; i < candidates.Length; i++)
        {
            path.Add(candidates[i]);
            Backtracking(candidates, target, i);
            path.RemoveAt(path.Count - 1);
        }
    }
}