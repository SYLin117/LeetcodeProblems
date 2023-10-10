namespace SolutionTest._0036;

using Solutions._0036ValidSudoku;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        char[][] test = new char[9][];
        test[0] = new char[] { '8','3','.','.','7','.','.','.','.' };
        test[1] = new char[] { '6','.','.','1','9','5','.','.','.' };
        test[2] = new char[] { '.','9','8','.','.','.','.','6','.' };
        test[3] = new char[] { '8','.','.','.','6','.','.','.','3' };
        test[4] = new char[] { '4','.','.','8','.','3','.','.','1' };
        test[5] = new char[] { '7','.','.','.','2','.','.','.','6' };
        test[6] = new char[] { '.','6','.','.','.','.','2','8','.' };
        test[7] = new char[] { '.','.','.','4','1','9','.','.','5' };
        test[8] = new char[] { '.','.','.','.','8','.','.','7','9' };
        var sol = new Solution();
        Assert.AreEqual(false, sol.IsValidSudoku(test));
    }
}