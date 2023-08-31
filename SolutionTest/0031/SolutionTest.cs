namespace SolutionTest._0031;

using Solutions._0031NextPermutation;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        sol.NextPermutation(new int[] { 3, 2, 1 });
    }
}