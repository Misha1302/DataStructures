namespace MLinkedList;

internal static class ThrowerHelper
{
    public static void ThrowElementWasNotFound()
    {
        throw new IndexOutOfRangeException("Element wasn't found");
    }
}