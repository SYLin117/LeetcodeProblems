namespace Solutions._1207UniqueNumberofOccurrences;

public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        Dictionary<int, int> dict = new();
        foreach (var tmp in arr)
        {
            dict[tmp] = dict.GetValueOrDefault(tmp) + 1;
        }

        HashSet<int> set = new();
        foreach (var tmp in dict.Values)
        {
            if (!set.Contains(tmp)) set.Add(tmp);
            else return false;
        }

        return true;
    }
}