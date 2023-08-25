using Utils;

namespace SolutionTest._0040;

using Solutions._0040CombinationSumII;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        int[] test = new[] { 10, 1, 2, 7, 6, 1, 5 };
        var sol = new Solution();
        // [[1,1,6],[1,2,5],[1,7],[2,6]]
        IList<IList<int>> result = new List<IList<int>>()
        {
            new List<int>() { 1, 1, 6 },
            new List<int>() { 1, 2, 5 },
            new List<int>() { 1, 7 },
            new List<int>() { 2, 6 },
        };
        // CollectionAssert.AreEqual(result, sol.CombinationSum2(test, 8));
        sol.CombinationSum2(test, 8).Print2dList();
    }
}