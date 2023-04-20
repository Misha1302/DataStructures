namespace MLinkedList;

public record Node<T>(T Value, Node<T>? Next = null)
{
    public Node<T>? Next = Next;
    public T Value = Value;
}