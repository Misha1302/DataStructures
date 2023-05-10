using LinkedList = MLinkedList2.MLinkedList;

#pragma warning disable CS8321

//MEnumeratorLinkedList();
MLinkedList();

void MEnumeratorLinkedList()
{
    throw new NotImplementedException();
    /*var mLinkedList = new LinkedList();
    mLinkedList.AddLast();
    mLinkedList.AddLast();
    mLinkedList.AddLast();

    var enumerator = new MEnumerator<int>(mLinkedList);
    for (var i = 0; i < 2; i++)
    {
        do
        {
            Console.Write(enumerator.Current + " ");
        } while (enumerator.MoveNext());

        enumerator.Reset();
        Console.WriteLine();
    }*/
}

void MLinkedList()
{
    var mLinkedList = new LinkedList();
    mLinkedList.AddLast();
    mLinkedList.AddLast();
    mLinkedList.AddLast();

    Console.WriteLine(mLinkedList.First); // 0
    Console.WriteLine(mLinkedList.Last); // 2

    Console.WriteLine(mLinkedList[0]); // 0
    Console.WriteLine(mLinkedList[2]); // 2

    Console.WriteLine(mLinkedList.Len); // 3

    Console.WriteLine(mLinkedList.ToString()); // [0,1,2]
    mLinkedList.Insert(0); // [3,0,1,2]
    mLinkedList.Insert(3); // [3,0,1,4,2]
    Console.WriteLine(mLinkedList.ToString()); // [3,0,1,4,2]
    mLinkedList.RemoveAt(1); // [3,1,4,2]
    mLinkedList.RemoveAt(0); // [1,4,2]
    Console.WriteLine(mLinkedList.Len); // 3
    Console.WriteLine(mLinkedList.ToString()); // [1,4,2]
}