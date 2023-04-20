namespace MLinkedList;

using System.Text;

public static class Extensions
{
    public static string ToStringExt<T>(this MLinkedList<T> linkedList)
    {
        var builder = new StringBuilder(32);
        builder.Append('[');

        if (linkedList.GetLength() != 0)
        {
            for (var current = linkedList.GetFirstNode(); current != null; current = current.Next)
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