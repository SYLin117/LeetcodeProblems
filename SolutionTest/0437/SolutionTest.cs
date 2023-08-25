using MyDataStructure;

namespace SolutionTest._0437;
using Solutions._0437PathSumIII;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        Assert.AreEqual(0, sol.PathSum(new int?[] {1000000000,1000000000,null,294967296,null,1000000000,null,1000000000,null,1000000000}.ArrayToTree(), 0));
    }
}