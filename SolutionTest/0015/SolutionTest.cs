using Solutions._00153Sum;

namespace SolutionTest._0015;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        var result = sol.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4 });
        Console.WriteLine();
    }
}