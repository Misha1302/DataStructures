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

        if (index == 0)
        {
            First = new MNode { Next = First };
            Len++;
            return;
        }

        var nodeByIndex = GetNodeByIndex(index - 1);
        nodeByIndex.Next = new MNode { Next = nodeByIndex.Next };
        Len++;
    }

    public void RemoveAt(int index)
    {
        if (index != 0)
            GetNodeByIndex(index - 1).Next = Len >= index ? GetNodeByIndex(index + 1) : null;
        else
            First = First?.Next;

        Len--;
    }

    public MNode GetNodeByIndex(int index)
    {
        if (Len <= index || index < 0) throw new ArgumentOutOfRangeException(nameof(index));

        var current = First;
        for (var i = 0; i < index; i++)
            current = current.Next;

        return current;
    }

    public MNode this[int index]
    {
        get => GetNodeByIndex(index);
    }

    public override string ToString()
    {
        return this.ToStringExt();
    }
}
