namespace MLinkedList;

public record Node<T>(T Value)
{
    public Node<T> Next;
    public T Value = Value;
}