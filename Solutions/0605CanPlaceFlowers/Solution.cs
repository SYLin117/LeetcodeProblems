namespace Solutions._0605CanPlaceFlowers;

public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (flowerbed.Length == 1 && flowerbed[0] == 0 && n <= 1) return true; 
        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (i == 0)
            {
                if (flowerbed[i] == 0 && flowerbed[i + 1] == 0)
                {
                    flowerbed[i] = 1;
                    n--;
                }
            }
            else if (i > 0 && i < flowerbed.Length - 1)
            {
                if (flowerbed[i] == 0 && flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
                {
                    flowerbed[i] = 1;
                    n--;
                }
            }
            else
            {
                if (flowerbed[i - 1] == 0 && flowerbed[i] == 0)
                {
                    flowerbed[i] = 1;
                    n--;
                }
            }
        }

        return (n <= 0);
    }
}