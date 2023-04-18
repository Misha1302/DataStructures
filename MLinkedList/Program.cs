namespace MLinkedList;

public static class Program
{
    private static void Main()
    {
        MLinkedList<int> myLinkedList = new();
        LinkedList<int> linkedList = new();
            
        myLinkedList.Add(1);
        myLinkedList.Add(2);
        myLinkedList.Add(5);

        string s = myLinkedList.ToString();
        
        Console.WriteLine(myLinkedList.Find((a) => a == 2));
        Console.WriteLine(myLinkedList.Contains((a) => a == 2));
        Console.WriteLine(myLinkedList);
        Console.WriteLine(myLinkedList.Last);
        Console.WriteLine(new MLinkedList<int>().Last);
    }
}