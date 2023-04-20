namespace MLinkedList;

using System.Text;

public class MLinkedList<T>
{
    private Node<T> _first;
    private Node<T> _last;
    private int _len;

    public void AddLast(T value)
    {
        var newLastNode = new Node<T>(value);

        if (_len == 0)
            _first = newLastNode;
        else
            _last.Next = newLastNode;

        _last = newLastNode;
        _len++;
    }

    public T GetFirst() => GetNodeByIndex(0).Value;

    public T GetLast()
    {
        if (_len == 0)
            throw new ArgumentOutOfRangeException();
        return _last.Value;
    }

    public T GetByIndex(int index) => GetNodeByIndex(index).Value;

    private Node<T> GetNodeByIndex(int index)
    {
        if (_len <= index)
            throw new ArgumentOutOfRangeException(nameof(index));

        var current = _first;
        for (var i = 0; i < index; i++)
            current = current.Next!;

        return current;
    }

    public int GetLength() => _len;

    public void Insert(int index, T value)
    {
        _len++;
        if (index == 0)
        {
            _first = new Node<T>(value) { Next = _first };
            return;
        }

        var nodeByIndex = GetNodeByIndex(index - 1);
        nodeByIndex.Next = nodeByIndex with { Value = value };
    }

    public void Remove(int index)
    {
        if (_len <= index)
            throw new ArgumentOutOfRangeException(nameof(index));

        if (index != 0)
        {
            var nodeByIndex = GetNodeByIndex(index - 1);
            nodeByIndex.Next = nodeByIndex.Next?.Next;
        }
        else
        {
            _first = _first.Next!;
        }

        _len--;
    }

    public override string ToString()
    {
        var builder = new StringBuilder(32);
        builder.Append('[');

        if (_len != 0)
        {
            for (var current = _first; current != null; current = current.Next)
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