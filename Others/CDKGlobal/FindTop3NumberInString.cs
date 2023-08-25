namespace Others.CDKGlobal;

public class FindTop3NumberInString
{
    public List<int> Solution(string input)
    {
        var tmps = input.Split(new char[] { ',', ' ' });
        List<int> numbers = new List<int>();
        foreach (var tmp in tmps)
        {
            int num;
            if (int.TryParse(tmp, out num)) numbers.Add(num);
        }

        if (numbers.Count == 0) return null;
        return numbers.OrderByDescending(i => i).Take(3).ToList();
    }
}