using Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Lists
{
    internal class CircularLinkedList : ImethodLists
    {
        private Node head;
        public CircularLinkedList()
        {
            head = null;
        }

        public void Add(Node newNode)
        {
            //Lista vacía
            if (head == null)
            {
                head = newNode;
                head.Next = head;
            }
            //si el valor es menos que el head el valor sera el nuevo head
            else if (newNode.Value < head.Value)
            {
                Node current = head;
                while (current.Next != head)
                {
                    current = current.Next;
                }
                newNode.Next = head;
                current.Next = newNode;
                head = newNode;
            }
            // Buscar la posición correcta en la lista
            else
            {
                Node current = head;

                while (current.Next != head && current.Next.Value < newNode.Value)
                {
                    current = current.Next;
                }
                // Verificamos si el valor ya existe
                if (current.Next.Value == newNode.Value)
                {
                    return;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }



        public void Remove(int value)
        {
            if (head == null)
            {
                MessageBox.Show("The list is empty, no nodes to remove.");
                return;
            }

            Node current = head;

            if (head.Value == value)
            {

                if (head.Next == head)
                {
                    head = null;
                }
                else
                {
                    while (current.Next != head)
                    {
                        current = current.Next;
                    }

                    head = head.Next;
                    current.Next = head;
                }
                MessageBox.Show("Value removed successfully.");
                return;
            }

            // El nodo a eliminar no es el head
            current = head;

            while (current.Next != head)
            {
                if (current.Next.Value == value)
                {
                    current.Next = current.Next.Next;
                    MessageBox.Show("Value removed successfully.");
                    return;
                }

                current = current.Next;
            }

            MessageBox.Show("Value not found.");
        }

        public int Count()
        {
            if (head == null)
            {
                return 0;
            }
            int count = 1;
            Node current = head;
            while (current.Next != head)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        public bool Contains(int value)
        {
            if (head == null)
            {
                return false;
            }
            Node current = head;
            while (current.Next != head)
            {
                if (current.Value == value)
                {
                    return true;
                }
                current = current.Next;
            }
            return current.Value == value;
        }

        public Node GetHead() => head;
    }
}
