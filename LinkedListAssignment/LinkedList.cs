using System;
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

        internal Node InsertAtParticularPosition(int PreviousData, Node Newdata)
        {
            Node temp = this.head;
            while (temp != null)
            {
                while (temp.data == PreviousData)
                {
                    Node newnode = temp.next;
                    temp.next = Newdata;
                    temp.next.next = newnode;
                    break;
                }
                temp = temp.next;
            }
            return head;
        }

        internal Node Search(int value)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    return temp;
                }
                temp = temp.next;
            }
            return null;
        }


        internal void RemoveElement(int data)
        {
            Node temp = this.head;
            Node searchedNode = Search(data);
            while(temp.next != searchedNode)
            {
                temp = temp.next;
            }
            temp.next = searchedNode.next;
            
        }

        internal void size()
        {
            int count = 0;
            Node temp = this.head;
            while(temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine(count);
        }
    }


}

