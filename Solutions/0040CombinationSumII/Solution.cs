namespace Solutions._0040CombinationSumII;

public class Solution
{
    private IList<IList<int>> result = new List<IList<int>>();
    private IList<int> path = new List<int>();
    bool[] used;
    int sum = 0;

    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        used = new bool[candidates.Length];
        Array.Sort(candidates);
        Backtracking(candidates, target, 0);
        return result;
    }

    private void Backtracking(int[] candidates, int target, int start)
    {
        if (sum == target)
        {
            result.Add(new List<int>(path));
            return;
        }

        for (int i = start; i < candidates.Length; i++)
        {
            if (candidates[i] > sum + candidates[i]) break;

            // 前面的數沒有使用後面這個數也不可使用(會出現重複結果)
            if (i > start && candidates[i] == candidates[i - 1] && !used[i - 1]) 
                continue;

            path.Add(candidates[i]);
            used[i] = true;
            sum += candidates[i];

            Backtracking(candidates, target, i + 1);


            path.RemoveAt(path.Count - 1);
            used[i] = false;
            sum -= candidates[i];
        }
    }
}