using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{
    public class LinkedList
    {
       
        // Single Linked list
        internal class Node
        {
            internal String data;
            internal Node next;
            internal Node(String d)
            {
                this.data = d;
                this.next = null;
            }
        }

        internal class SingleLinkedList
        {
            internal Node head;
        }

        internal void InsertFront(SingleLinkedList singlyList, String new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = singlyList.head;
            singlyList.head = new_node;
        }

        internal void InsertLast(SingleLinkedList singlyList, String new_data)
        {
            Node new_node = new Node(new_data);

            if (singlyList.head == null)
            {
                singlyList.head = new_node;
                return;
            }

            Node lastNode = GetLastNode(singlyList);
            lastNode.next = new_node;
        }

        internal Node GetLastNode(SingleLinkedList singlyList)
        {
            Node temp = singlyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        internal void InsertAfter(Node prev_node, String new_data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }
            Node new_node = new Node(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }


        internal void DeleteNodebyKey(SingleLinkedList singlyList, String key)
        {
            Node temp = singlyList.head;
            Node prev = null;

            if (temp != null && temp.data == key)
            {
                singlyList.head = temp.next;
                return;
            }

            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }

            if (temp == null)
            {
                return;
            }

            prev.next = temp.next;
        }


        // Doubly Linked list
        internal class DNode
        {
            internal String data;
            internal DNode next;
            internal DNode prev;

            internal DNode(String d)
            {
                this.data = d;
                this.next = null;
                this.prev = null;
            }
        }

        internal class DoubleLinkedList
        {
            internal DNode head;
        }

        internal void InsertFront(DoubleLinkedList doubleLinkedList, String data)
        {
            DNode newNode = new DNode(data);
            newNode.next = doubleLinkedList.head;
            newNode.prev = null;
            if (doubleLinkedList.head != null)
            {
                doubleLinkedList.head.prev = newNode;
            }
            doubleLinkedList.head = newNode;
        }


        internal void InsertLast(DoubleLinkedList doubleLinkedList, String data)
        {
            DNode newNode = new DNode(data);
            if (doubleLinkedList.head == null)
            {
                newNode.prev = null;
                doubleLinkedList.head = newNode;
                return;
            }
            DNode lastNode = GetLastNode(doubleLinkedList);
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }

        internal DNode GetLastNode(DoubleLinkedList doubleList)
        {
            DNode temp = doubleList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }


        internal void InsertAfter(DNode prev_node, String data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given prevoius node cannot be null");
                return;
            }
            DNode newNode = new DNode(data);
            newNode.next = prev_node.next;
            prev_node.next = newNode;
            newNode.prev = prev_node;
            if (newNode.next != null)
            {
                newNode.next.prev = newNode;
            }
        }


        internal void DeleteNodebyKey(DoubleLinkedList doubleLinkedList, String key)
        {
            DNode temp = doubleLinkedList.head;
            if (temp != null && temp.data == key)
            {
                doubleLinkedList.head = temp.next;
                doubleLinkedList.head.prev = null;
                return;
            }

            while (temp != null && temp.data != key)
            {
                temp = temp.next;
            }

            if (temp == null)
            {
                return;
            }

            if (temp.next != null)
            {
                temp.next.prev = temp.prev;
            }

            if (temp.prev != null)
            {
                temp.prev.next = temp.next;
            }
        }

    }
}
