using Others.CDKGlobal;

namespace SolutionTest.Others;

[TestClass]
public class CDKTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new FindTop3NumberInString();
        string input = "Here we have four number: 23, 43, 2, 98, 102, 24, 1, 9";
        CollectionAssert.AreEqual(new List<int>() { 102, 98, 43 }, sol.Solution(input));
    }
}