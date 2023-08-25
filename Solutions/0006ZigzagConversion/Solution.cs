using System.Text;

namespace Solutions._0006ZigzagConversion;

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows <= 1) return s;
        bool down = true;
        int len = s.Length;
        int cols = (len / numRows) + (len % numRows);
        char[,] result = new char[numRows, len];
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < len; j++)
            {
                result[i, j] = ' ';
            }
        }
        int x = 0;
        int y = 0;
        foreach (char c in s)
        {
            result[x, y] = c;
            if (down)
            {
                // doing down
                if (x == numRows - 1)
                {
                    // reach the bottom
                    down = false;
                    x--;
                    y++;
                }
                else
                {
                    x++;
                }
            }
            else
            {
                // going up
                if (x == 0)
                {
                    down = true;
                    x++;
                }
                else
                {
                    x--;
                    y++;
                }
            }
        }

        StringBuilder sb = new();
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j <= y; j++)
            {
                if (result[i, j] == ' ') continue;
                sb.Append(result[i, j]);
            }
        }
        return sb.ToString();
    }
}