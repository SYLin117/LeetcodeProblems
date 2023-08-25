namespace Solutions._0225ImplementStackusingQueues;

public class MyStack
{
    private Queue<int> q1;
    private Queue<int> q2;

    public MyStack()
    {
        q1 = new Queue<int>();
        q2 = new Queue<int>();
    }

    public void Push(int x)
    {
        q1.Enqueue(x);
    }

    public int Pop()
    {
        while (q1.Count > 1)
        {
            q2.Enqueue(q1.Dequeue());
        }

        var tmp = q1.Dequeue();
        while (q2.Count > 0)
        {
            q1.Enqueue(q2.Dequeue());
        }

        return tmp;
    }

    public int Top()
    {
        while (q1.Count > 1)
        {
            q2.Enqueue(q1.Dequeue());
        }

        var tmp = q1.Dequeue();
        q2.Enqueue(tmp);
        while (q2.Count > 0)
        {
            q1.Enqueue(q2.Dequeue());
        }

        return tmp;
    }

    public bool Empty()
    {
        return (q1.Count == 0 && q2.Count == 0);
    }
}