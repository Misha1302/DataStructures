using System.Text;

namespace MLinkedList2;

internal static class MLinkedListExt
{
    public static string ToStringExt(this MLinkedList list)
    {
        var builder = new StringBuilder();

        var current = list.First;
        while (current != null)
        {
            builder.Append(current.ToString()).Append("->");
            current = current.Next;
        }

        builder.Remove(builder.Length - 2, 2);
        return builder.ToString();
    }
}