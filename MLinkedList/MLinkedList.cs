namespace MLinkedList;

using System.Text;

public class MLinkedList<T>
{
    private Node<T>? _first;
    private Node<T>? _last;
    private int _len;

    public void AddLast(T value)
    {
        Node<T>? lastNode = _last;
        Node<T> newLastNode = new(value);

        if (lastNode == null) _first = newLastNode;
        else lastNode.Next = newLastNode;

        _last = newLastNode;
        _len++;
    }

    public T GetFirst() => GetNodeByIndex(0).Value;

    public T GetLast()
    {
        if (_len == 0) ThrowerHelper.ThrowElementWasNotFound();
        return _last!.Value;
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

    public int GetLength() => _len;

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