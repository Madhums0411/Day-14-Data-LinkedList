using DataStructureProblem;

LinkedLists linkedLists = new LinkedLists();

Node node1 = new Node(56);
Node node2 = new Node(30);
Node node3 = new Node(70);
node1.next = node2;
node2.next = node3;
linkedLists.Head = node1;
Console.WriteLine("Search For Node value 30");
linkedLists.Display();
if (linkedLists.Search(30))
{
    Console.WriteLine("\nNode with value 30 is available in Linked list");
}