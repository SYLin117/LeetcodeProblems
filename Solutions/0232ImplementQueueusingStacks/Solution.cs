namespace Solutions._0232ImplementQueueusingStacks;

public class MyQueue
{
    private Stack<int> stack1;
    private Stack<int> stack2;

    public MyQueue()
    {
        stack1 = new Stack<int>();
        stack2 = new Stack<int>();
    }

    public void Push(int x)
    {
        stack1.Push(x);
    }

    public int Pop()
    {
        if (stack2.Count > 0)
        {
            return stack2.Pop();
        }
        else
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }

            return stack2.Pop();
        }
    }

    public int Peek()
    {
        if (stack2.Count > 0) return stack2.Peek();
        else
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }

            return stack2.Peek();
        }
    }

    public bool Empty()
    {
        return (stack1.Count == 0 && stack2.Count == 0);
    }
}