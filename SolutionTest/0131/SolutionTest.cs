namespace SolutionTest._0131;
using Solutions._0131PalindromePartioning;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        string test = "aab";
        var sol = new Solution();
        IList<IList<string>> result = new List<IList<string>>();
        result.Add(new List<string>(){"a", "a", "b"});
        result.Add(new List<string>(){"aa", "b"});
        sol.Partition(test);
    }
}