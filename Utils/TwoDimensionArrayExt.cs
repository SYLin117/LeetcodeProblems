namespace Utils;

public static class TwoDimensionArrayExt
{
    public static void Print2DArray(this int[,] array)
    {
        int row = array.GetLength(0);
        int col = array.GetLength(1);
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(array[i, j].ToString().PadLeft(3));
            }

            Console.WriteLine();
        }
    }
}