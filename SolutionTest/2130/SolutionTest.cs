using MyDataStructure;

namespace SolutionTest._2130;

using Solutions._2130MaximumTwinSumOfALinkedList;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        var test = new int[] { 5, 4, 2, 1 };
        Assert.AreEqual(6, sol.PairSum(test.ToListNode()));
    }
}