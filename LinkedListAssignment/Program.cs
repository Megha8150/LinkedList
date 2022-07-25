// See https://aka.ms/new-console-template for more information
using LinkedListAssignment;
Console.WriteLine("Welcome to DataStructure Linkedlist!");


LinkedList list = new LinkedList();
list.Add(56);
list.Add(30);
list.Add(70);
list.Display();
Console.Write("\n After Remove First Node :\n Linked List : ");
list.RemoveFirstNode();
list.Display();