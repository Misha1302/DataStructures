namespace MLinkedList;

public class MEnumerator<T>
{
    private readonly Node<T> _start;
    private Node<T> _currentNode;

    public MEnumerator(MLinkedList<T> linkedList)
    {
        const string message = "There are no items in the collection";

        _start = linkedList.GetFirstNode();
        _currentNode = _start ?? throw new ArgumentOutOfRangeException(nameof(linkedList), message);
    }

    public T Current => _currentNode.Value;

    public bool MoveNext()
    {
        _currentNode = _currentNode.Next;
        return _currentNode != null;
    }

    public void Reset()
    {
        _currentNode = _start;
    }
}