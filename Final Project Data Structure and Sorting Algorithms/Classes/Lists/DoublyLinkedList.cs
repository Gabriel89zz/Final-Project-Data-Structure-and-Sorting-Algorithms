using Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Lists
{
    internal class DoublyLinkedList : ImethodLists
    {
        private DoubleNode head;
        public DoublyLinkedList()
        {
            head = null;
        }

        public void Add(DoubleNode newNode)
        {

            if (head == null || head.Value >= newNode.Value) // Insertar al inicio si está vacía o el valor es menor.
            {
                newNode.Next = head!;
                if (head != null) head.Prev = newNode;
                head = newNode;
            }
            else
            {
                DoubleNode current = head;
                while (current.Next != null && current.Next.Value < newNode.Value)
                {
                    current = current.Next;
                }

                newNode.Next = current.Next!;
                if (current.Next != null) current.Next.Prev = newNode;
                current.Next = newNode;
                newNode.Prev = current;
            }
        }

        public void Remove(int value)
        {
            if (head == null)
            {
                return;
            }
            if (head.Value == value)
            {
                head = head.Next;
                head.Prev = null;
                return;
            }
            DoubleNode current = head;
            while (current.Next != null)
            {
                if (current.Next.Value == value)
                {
                    current.Next = current.Next.Next;
                    if (current.Next != null)
                    {
                        current.Next.Prev = current;
                    }
                    return;
                }
                current = current.Next;
            }
        }

        public int Count()
        {
            int count = 0;
            DoubleNode current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
        public bool Contains(int value)
        {
            DoubleNode current = head;
            while (current != null)
            {
                if (current.Value == value)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public DoubleNode GetHead() => head;
    }
}
