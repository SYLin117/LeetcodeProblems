namespace Solutions._0547NumberOfProvinces;

public class Solution
{
    public int FindCircleNum(int[][] isConnected)
    {
        int nodeNum = isConnected.Length;
        bool[] visited = new bool[isConnected.Length];
        int result = 0;
        for (int i = 0; i < visited.Length; i++)
        {
            if (visited[i]) continue;
            Queue<int> q = new();
            q.Enqueue(i);
            while (q.Count > 0)
            {
                int qCnt = q.Count;
                for (int j = 0; j < qCnt; j++)
                {
                    var node = q.Dequeue();
                    if (visited[node]) continue;
                    visited[node] = true;
                    for (int k = node+1; k < nodeNum; k++)
                    {
                        if(isConnected[node][k]==1 && !visited[k]) q.Enqueue(k);
                    }
                }
            }

            result++;
        }

        return result;
    }
}