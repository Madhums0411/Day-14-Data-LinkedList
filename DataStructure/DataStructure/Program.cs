using DataStructureProblem;

LinkedLists linkedLists = new LinkedLists();

linkedLists.AppendNode(56);
linkedLists.AppendNode(30);
linkedLists.AppendNode(70);
Console.WriteLine("Delete Last element");
linkedLists.DeleteNodeAtLast();
linkedLists.Display();