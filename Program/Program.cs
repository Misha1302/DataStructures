using MLinkedList;

#pragma warning disable CS8321

MEnumeratorLinkedList();

void MEnumeratorLinkedList()
{
    var mLinkedList = new MLinkedList<int>();
    mLinkedList.AddLast(2);
    mLinkedList.AddLast(3);
    mLinkedList.AddLast(5);

    var enumerator = new MEnumerator<int>(mLinkedList);
    for (var i = 0; i < 2; i++)
    {
        do
        {
            Console.Write(enumerator.Current + " ");
        } while (enumerator.MoveNext());

        enumerator.Reset();
        Console.WriteLine();
    }
}

void MLinkedList()
{
    var mLinkedList = new MLinkedList<int>();
    mLinkedList.AddLast(2);
    mLinkedList.AddLast(3);
    mLinkedList.AddLast(5);

    Console.WriteLine(mLinkedList.GetFirst()); // 2
    Console.WriteLine(mLinkedList.GetLast()); // 3

    Console.WriteLine(mLinkedList.GetByIndex(0)); // 2
    Console.WriteLine(mLinkedList.GetByIndex(2)); // 5

    Console.WriteLine(mLinkedList.GetLength()); // 3

    Console.WriteLine(mLinkedList.ToString()); // [2,3,5]
    mLinkedList.Insert(0, -5); // [-5,2,3,5]
    mLinkedList.Insert(3, -3); // [-5,2,3,-3,5]
    mLinkedList.Remove(1); // [-5,3,-3,5]
    Console.WriteLine(mLinkedList.GetLength()); // 3
    Console.WriteLine(mLinkedList.ToString()); // [-5,3,-3,5]
}