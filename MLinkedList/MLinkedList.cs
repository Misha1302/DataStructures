namespace MLinkedList;

using System.Text;

public class MLinkedList<T> 
{
    private Node<T>? _start;

    public Node<T>? Last
    {
        get
        {
            Node<T>? currentNode = _start;
            while (currentNode?.Next != null) currentNode = currentNode.Next;
            return currentNode;
        }
    }

    public void Add(T obj)
    {
        if (_start == null)
        {
            _start = new Node<T>(obj, null);
        }
        else
        {
            Node<T> currentNode = _start;
            while (currentNode.Next != null) currentNode = currentNode.Next;
            currentNode.Next = new Node<T>(obj, null);
        }
    }

    public T Find(Predicate<T> predicate)
    {
        if (_start == null) ThrowHelper.ThrowNotFoundException();

        Node<T>? currentNode = _start!;
        do
        {
            if (predicate(currentNode.Value))
                return currentNode.Value;
            currentNode = currentNode.Next;
        } while (currentNode != null);

        ThrowHelper.ThrowNotFoundException();
        return default!;
    }

    public bool Contains(Predicate<T> predicate)
    {
        if (_start == null) return false;

        Node<T>? currentNode = _start!;
        do
        {
            if (predicate(currentNode.Value))
                return true;
            currentNode = currentNode.Next;
        } while (currentNode != null);

        return false;
    }

    public override string ToString()
    {
        StringBuilder builder = new(32);
        builder.Append('[');

        if (_start == null) goto end;

        Node<T>? currentNode = _start!;
        do
        {
            builder.Append(currentNode.Value);
            builder.Append(',');
            currentNode = currentNode.Next;
        } while (currentNode != null);

        end:
        builder.Append(']');
        return builder.ToString();
    }
}

public static class ThrowHelper
{
    public static void ThrowNotFoundException()
    {
        throw new MLinkedListException("Value was not found");
    }
}

public class MLinkedListException : Exception
{
    public MLinkedListException(string message) : base(message)
    {
    }
}

public record Node<T>(T Value, Node<T>? Next)
{
    public readonly T Value = Value;
    public Node<T>? Next = Next;
}