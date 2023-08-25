using Solutions._0707DesignLinkedList;

namespace SolutionTest._0707;

[TestClass]
public class MyLinkedListTest
{
    [TestMethod]
    public void Test()
    {
        // Your test code goes here.
        MyLinkedList myLinkedList = new MyLinkedList();
        myLinkedList.AddAtHead(9);
        myLinkedList.Get(1);
        myLinkedList.AddAtIndex(1,1);
        myLinkedList.AddAtIndex(1,7);
        myLinkedList.DeleteAtIndex(1);
        myLinkedList.AddAtHead(7);
        myLinkedList.Print();
        myLinkedList.AddAtHead(4);
        myLinkedList.DeleteAtIndex(1);
        myLinkedList.AddAtIndex(1,4);
        myLinkedList.AddAtHead(2);
        myLinkedList.DeleteAtIndex(5);
    }
}