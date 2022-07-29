using DataStructureProblem;

LinkedLists linkedLists = new LinkedLists();

Console.WriteLine("Add Node After Node value 30 ");
linkedLists.AppendNode(56);
linkedLists.AppendNode(30);
linkedLists.AppendNode(40);
linkedLists.AppendNode(70);
Console.WriteLine("Before deleting:");
linkedLists.Display();
linkedLists.deleteNode(40);
Console.WriteLine("\nAfter deleting:");
linkedLists.Display();
Console.WriteLine("\nSize of LinkedList is " + linkedLists.getCount());