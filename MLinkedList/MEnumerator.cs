namespace MLinkedList;

public class MEnumerator<T>
{
    private readonly Node<T> _start;
    private Node<T> _currentNode;

    public MEnumerator(MLinkedList<T> linkedList)
    {
        _start = linkedList.GetFirstNode();
        _currentNode = _start;
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