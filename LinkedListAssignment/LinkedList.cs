﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }
        }

        internal string Search(int value)
        {
            while (this.head != null)
            {
                if (this.head.data == value)
                {
                    return $"the given data {value} is Presrent in Linked List";
                }
                this.head = this.head.next;
            }
            return $"the given data {value} is Not Presrent in Linked List";
        }
    }
}





