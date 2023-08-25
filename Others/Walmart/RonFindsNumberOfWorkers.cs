namespace Others.Walmart;

public class RonFindsNumberOfWorkers
{
    public static void Solution()
    {
        var input = Input();
        int n = Int32.Parse(input[0]);
        string[] requireStr = input[1].Split(" ");
        List<int> requires = new();
        foreach (string tmp in requireStr)
        {
            requires.Add(Int32.Parse(tmp));
        }

        int k = Int32.Parse(input[2]);
        requires.Sort();
        int result = 0;
        for (int i = 0; i < k; i++)
        {
            result += requires[i];
        }
        Console.Write($"result: {result}");
    }

    public static string[] Input()
    {
        string lines = "";

        while (true)
        {
            string line = Console.ReadLine();

            if (line.Length == 0)
            {
                break;
            }

            lines += line + "\n";
        }

        string[] allLines = lines.Split("\n");
        return allLines;
    }
}