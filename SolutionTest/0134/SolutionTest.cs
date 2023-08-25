namespace SolutionTest._0134;

using Solutions._0134GasStation;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        int[] gas = new[] { 2, 3, 4 };
        int[] cost = new[] { 3, 4, 3 };
        Console.WriteLine(sol.CanCompleteCircuit(gas, cost));
    }
}