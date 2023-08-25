namespace MyDataStructure;

public class Node
{
    public int Value { get; set; }
    public Node Next { get; set; }

    public Node(int value, Node next)
    {
        Value = value;
        Next = next;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public override string ToString()
    {
        return val.ToString().PadLeft(4);
    }

    public void Print()
    {
        var cur = this;
        while (cur != null)
        {
            Console.Write($"{cur.val.ToString().PadLeft(3)} ->");
            cur = cur.next;
        }

        Console.WriteLine();
    }
}

public static class ListNodeExt
{
    public static ListNode ToListNode(this int[] arr)
    {
        ListNode head = new ListNode();
        var dummy = head;
        foreach (var tmp in arr)
        {
            dummy.next = new ListNode(tmp);
            dummy = dummy.next;
        }

        return head.next;
    }
}