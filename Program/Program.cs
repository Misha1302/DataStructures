using MLinkedList;

MLinkedList<int> myLinkedList = new();
myLinkedList.AddLast(2);
myLinkedList.AddLast(3);
myLinkedList.AddLast(5);

Console.WriteLine(myLinkedList.GetFirst()); // 2
Console.WriteLine(myLinkedList.GetLast()); // 3

Console.WriteLine(myLinkedList.GetByIndex(0)); // 2
Console.WriteLine(myLinkedList.GetByIndex(2)); // 5

Console.WriteLine(myLinkedList.GetLength()); // 3

Console.WriteLine(myLinkedList.ToString()); // [2,3,5]
myLinkedList.Insert(0, -5); // [-5,2,3,5]
myLinkedList.Insert(3, -3); // [-5,2,3,-3,5]
myLinkedList.Remove(1); // [-5,3,-3,5]
Console.WriteLine(myLinkedList.GetLength()); // 3
Console.WriteLine(myLinkedList.ToString()); // [-5,3,-3,5]