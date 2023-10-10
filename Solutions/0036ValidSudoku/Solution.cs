namespace Solutions._0036ValidSudoku;

public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        bool valid = true;
        for (int row = 0; row < 9; row++)
        {
            bool[] exist = new bool[9];
            for (int i = 0; i < 9; i++)
            {
                if (board[row][i] != '.')
                {
                    if (exist[board[row][i] - '1'])
                    {
                        valid = false;
                        goto LoopEnd;
                    }

                    exist[board[row][i] - '1'] = true;
                }
            }
        }

        for (int col = 0; col < 9; col++)
        {
            bool[] exist = new bool[9];
            for (int i = 0; i < 9; i++)
            {
                if (board[i][col] != '.')
                {
                    if (exist[board[i][col] - '1'])
                    {
                        valid = false;
                        goto LoopEnd;
                    }

                    exist[board[i][col] - '1'] = true;
                }
            }
        }

        for (int i = 0; i < 9; i += 3)
        {
            for (int j = 0; j < 9; j += 3)
            {
                bool[] exist = new bool[9];
                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        if (board[i + x][j + y] != '.')
                        {
                            if (exist[board[i + x][j + y] - '1'])
                            {
                                valid = false;
                                goto LoopEnd;
                            }

                            exist[board[i + x][j + y] - '1'] = true;
                        }
                    }
                }
            }
        }

        LoopEnd:
        return valid;
    }
}