namespace SolutionTest.KnapsackTest;

using Solutions.BagProblem;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Knapsack01Test()
    {
        var sol = new KnapsackProblem01();
        int[] weight = new[] { 1, 2, 3, 8, 7, 4 };
        int[] value = new[] { 20, 5, 10, 40, 15, 25 };
        int size = 10;
        Assert.AreEqual(60, sol.Solution(weight, value, size));
        value = new[] { 1, 2, 3 };
        weight = new[] { 4, 5, 1 };
        size = 3;
        Assert.AreEqual(3, sol.Solution(weight, value, size));
    }
}