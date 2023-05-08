namespace MLinkedList2;

public class MLinkedList
{
    public MNode First { get; private set; }
    public MNode Last { get; private set; }
    public int Len { get; private set; }

    public void AddLast()
    {
        var node = new MNode();
        if (Len == 0)
        {
            First = node;
            Last = First;
            Len++;
            return;
        }

        Last = Last.Next = node;
        Len++;
    }

    public void Insert(int index)
    {
        if (Len == 0)
        {
            AddLast();
            return;
        }

        var nodeByIndex = GetNodeByIndex(index - 1);
        nodeByIndex.Next = new MNode { Next = nodeByIndex.Next };
        Len++;
    }

    public void RemoveAt(int index)
    {
        GetNodeByIndex(index - 1).Next = Len < index ? GetNodeByIndex(index + 1) : null;
    }

    public MNode GetNodeByIndex(int index)
    {
        if (Len <= index) throw new ArgumentOutOfRangeException(nameof(index));

        var current = First;
        for (var i = 0; i < index; i++)
            current = current.Next;

        return current;
    }
}