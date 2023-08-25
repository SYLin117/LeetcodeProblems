namespace Solutions._0933NumberOfRecentCalls;

public class RecentCounter
{
    Queue<int> queue;

    public RecentCounter()
    {
        queue = new();
    }

    public int Ping(int t)
    {
        var min = t - 3000;
        int peekVal;
        while (queue.TryPeek(out peekVal) && peekVal < min)
        {
            queue.Dequeue();
        }
        queue.Enqueue(t);
        return queue.Count;
    }
}