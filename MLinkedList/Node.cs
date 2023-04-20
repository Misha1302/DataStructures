namespace MLinkedList;

public record Node<T>(T Value)
{
    public T Value = Value;
    public Node<T> Next;
}