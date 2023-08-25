namespace SolutionTest._0547;

using Solutions._0547NumberOfProvinces;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        int[][] test = new int[3][];
        test[0] = new int[] { 1, 1, 0 };
        test[1] = new int[] { 1, 1, 0 };
        test[2] = new int[] { 0, 0, 1 };

        var sol = new Solution();
        Console.WriteLine(sol.FindCircleNum(test));
    }
}