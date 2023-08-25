using Microsoft.VisualBasic;

namespace SolutionTest._0735;

using Solutions._0735AsteroidsCollision;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        // CollectionAssert.AreEqual(new int[] { -2, -1, 1, 2 }, sol.AsteroidCollision(new[] { -2, -1, 1, 2 }));
        CollectionAssert.AreEqual(new int[] { -2, -2, -2 }, sol.AsteroidCollision(new[] { -2, -2, 1, -2 }));
    }
}