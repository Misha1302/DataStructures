namespace MLinkedList2;

public class MNode
{
    private static int _nextId;
    private readonly int _id = _nextId++;

    public MNode(MNode next = null)
    {
        Next = next;
    }

    public MNode Next { get; set; }

    public override string ToString() => _id.ToString();
}