// See https://aka.ms/new-console-template for more information
using LinkedListAssignment;
Console.WriteLine("Welcome to DataStructure Linkedlist!");


LinkedList list = new LinkedList();
Node node = new Node(30);
list.Add(56);
list.Add(70);
list.Display();
list.InsertAtParticularPosition(56, node);
Console.Write("\n After Inserted 30 in between 56 and 70 :\n Linked List : ");
list.Display();