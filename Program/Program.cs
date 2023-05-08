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

    Console.WriteLine(mLinkedList.First); // 2
    Console.WriteLine(mLinkedList.Last); // 3

    Console.WriteLine(mLinkedList[0]); // 2
    Console.WriteLine(mLinkedList[2]); // 5

    Console.WriteLine(mLinkedList.Len); // 3

    Console.WriteLine(mLinkedList.ToString()); // [2,3,5]
    mLinkedList.Insert(0); // [-5,2,3,5]
    mLinkedList.Insert(3); // [-5,2,3,-3,5]
    //mLinkedList.Remove(1); // [-5,3,-3,5]
    Console.WriteLine(mLinkedList.Len); // 3
    Console.WriteLine(mLinkedList.ToString()); // [-5,3,-3,5]
}