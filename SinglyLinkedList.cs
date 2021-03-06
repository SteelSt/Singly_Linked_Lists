using System;

public class SinglyLinkedList
{
    public SllNode Head;
    public SinglyLinkedList() 
    {
        this.Head = null;
    }
    // SLL methods go here. As a starter, we will show you how to add a node to the list.
    public void Add(int value) 
    {
        SllNode newNode = new SllNode(value);
        if(Head == null) 
        {
            Head = newNode;
        } 
        else
        {
            SllNode runner = Head;
            while(runner.Next != null) 
            {
                runner = runner.Next;
            }
            runner.Next = newNode;
        }
    }

    public int Remove()
    {
        var runner = this.Head;
        ////This handles an empty list
        if(this.Head == null)
        {
            return 0;
        }
        ////This handles if our List only has one node
        if(runner.Next == null)
        {
            int returnValue = runner.Value;
            this.Head = null;
            return runner.Value;
        }
        else
        {
            while(runner != null)
            {
                ////This jumps sets us forward one node so we can grab it's value
                ////and set the .Next from our previous node to null.
                if(runner.Next.Next == null)
                {
                    int returnValue = runner.Next.Value;
                    runner.Next = null;
                    return returnValue;
                }
                runner = runner.Next;
            }
        }
        return 0;
    }

    public void PrintValues()
    {
        var runner = this.Head;
        while(runner != null)
        {
            Console.WriteLine($"Node Value: {runner.Value}");
            runner = runner.Next;
        }
    }
}