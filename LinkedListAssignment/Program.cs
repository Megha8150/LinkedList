﻿// See https://aka.ms/new-console-template for more information
using LinkedListAssignment;
Console.WriteLine("Welcome to DataStructure Linkedlist!");


LinkedList list = new LinkedList();
list.Add(56);
list.Add(30);
list.Add(40);
list.Add(70);
list.Display();
Console.WriteLine();

list.RemoveElement(40);

Console.Write("\n  :\n Linked List : ");
list.Display();
Console.WriteLine("");
list.size();