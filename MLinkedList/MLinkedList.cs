namespace MLinkedList;

using System.Text;

public class MLinkedList<T>
{
    private Node<T>? _first;

    public void AddLast(T value)
    {
        Node<T>? lastNode = GetLastNode();
        if (lastNode == null) _first = new Node<T>(value);
        else lastNode.Next = new Node<T>(value);
    }

    public T? GetFirst()
    {
        if (_first == null) return default;
        return _first.Value ?? default;
    }

    public T? GetLast()
    {
        Node<T>? lastNode = GetLastNode();
        return lastNode == null ? default : lastNode.Value;
    }

    public T GetByIndex(int index) => GetNodeByIndex(index).Value;

    private Node<T> GetNodeByIndex(int index)
    {
        if (_first == null)
        {
            ThrowerHelper.ThrowElementWasNotFound();
            return null!;
        }

        Node<T> current = _first;
        for (int i = 0; i < index; i++, current = current.Next)
            if (current.Next == null)
            {
                ThrowerHelper.ThrowElementWasNotFound();
                return null!;
            }

        return current;
    }

    public int GetLength()
    {
        if (_first == null) return 0;

        Node<T> current = _first;

        int counter;
        for (counter = 1; current.Next != null; current = current.Next, counter++)
        {
        }

        return counter;
    }

    public void Insert(int index, T value)
    {
        if (index == 0)
        {
            _first = new Node<T>(value) { Next = _first };
            return;
        }

        Node<T> nodeByIndex = GetNodeByIndex(index - 1);
        nodeByIndex.Next = nodeByIndex with { Value = value };
    }

    public void Remove(int index)
    {
        if (index == 0)
        {
            _first = _first?.Next;
            return;
        }

        Node<T> nodeByIndex = GetNodeByIndex(index - 1);
        nodeByIndex.Next = nodeByIndex.Next?.Next;
    }

    private Node<T>? GetLastNode()
    {
        if (_first == null) return null;

        Node<T> current = _first;
        while (current.Next != null) current = current.Next;
        return current;
    }

    public override string ToString()
    {
        StringBuilder builder = new(32);
        builder.Append('[');

        if (_first != null)
        {
            for (Node<T>? current = _first; current != null; current = current.Next)
            {
                builder.Append(current.Value);
                builder.Append(',');
            }

            builder.Remove(builder.Length - 1, 1);
        }

        builder.Append(']');
        return builder.ToString();
    }
}

internal static class ThrowerHelper
{
    public static void ThrowElementWasNotFound()
    {
        throw new MLinkedListException("Element wasn't found");
    }
}

internal class MLinkedListException : Exception
{
    public MLinkedListException(string message) : base(message)
    {
    }
}

public record Node<T>(T Value, Node<T>? Next = null)
{
    public Node<T>? Next = Next;
    public T Value = Value;
}