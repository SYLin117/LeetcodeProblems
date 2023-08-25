using MyDataStructure;

namespace Solutions._0707DesignLinkedList;

public class MyLinkedList
{
    private ListNode head;
    private ListNode prev;
    private int size;

    public MyLinkedList()
    {
        head = new ListNode();
        prev = new ListNode(next: head);
        size = 0;
    }

    public int Get(int index)
    {
        var cur = head;
        while (index >= 0)
        {
            cur = cur.next;
            if (cur == null)
            {
                return -1;
            }

            index--;
        }

        return cur.val;
    }

    public void AddAtHead(int val)
    {
        ListNode newNode = new ListNode(val);
        if (head.next == null) // no node yet
        {
            head.next = newNode;
        }
        else
        {
            newNode.next = head.next;
            head.next = newNode;
        }

        size++;
    }

    public void AddAtTail(int val)
    {
        var cur = head;
        var precur = prev;
        while (cur != null)
        {
            cur = cur.next;
            precur = precur.next;
        }

        precur.next = new ListNode(val);
        size++;
    }

    public void AddAtIndex(int index, int val)
    {
        if (index > size)
        {
            return;
        }
        else if (index == size)
        {
            AddAtTail(val);
        }
        else
        {
            var cur = head;
            var precur = prev;
            while (index >= 0)
            {
                cur = cur.next;
                precur = precur.next;
                index--;
            }

            ListNode newNode = new ListNode(val, cur);
            precur.next = newNode;
            size++;
        }
    }

    public void DeleteAtIndex(int index)
    {
        if (index >= size)
        {
            return;
        }

        var cur = head;
        var precur = prev;
        while (index >= 0)
        {
            cur = cur.next;
            precur = precur.next;
            index--;
        }

        precur.next = cur.next;
        size--;
    }

    public void Print()
    {
        var cur = head.next;
        while (cur != null)
        {
            Console.Write($"{cur.val.ToString()} ->");
            cur = cur.next;
        }

        Console.WriteLine();
    }
}