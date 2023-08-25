namespace Solutions._0134GasStation;

public class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int len = gas.Length;
        bool find = false;
        int result = 0;
        for (int i = 0; i < len; i++)
        {
            int tank = 0;
            int current = i;
            int step = 0;
            while(true)
            {
                if (step == len)
                {
                    find = true;
                    result = i;
                    break;
                }

                if (tank + gas[current] - cost[current] >= 0)
                {
                    tank = tank + gas[current] - cost[current];
                    current = (current + 1) % len;
                    step++;
                }
                else break;
            }

            if (find) break;
        }

        if (find) return result;
        else return -1;
    }
}