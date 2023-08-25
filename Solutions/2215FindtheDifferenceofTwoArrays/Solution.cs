namespace Solutions._2215FindtheDifferenceofTwoArrays;

public class Solution
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> set2 = new HashSet<int>(nums2);
        List<int> list1 = new();
        List<int> list2 = new();
        List<IList<int>> answer = new List<IList<int>>();
        foreach (var tmp in set1)
        {
            if (!set2.Contains(tmp)) list1.Add(tmp);
        }

        foreach (var tmp in set2)
        {
            if (!set1.Contains(tmp)) list2.Add(tmp);
        }

        answer.Add(list1);
        answer.Add(list2);
        return answer;
    }
}