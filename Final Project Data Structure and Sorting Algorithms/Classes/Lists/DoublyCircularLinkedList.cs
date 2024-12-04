using Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Lists
{
    internal class DoublyCircularLinkedList : ImethodLists
    {
        private DoubleNode head;

        public DoublyCircularLinkedList()
        {
            head = null;
        }

        public void Add(DoubleNode newNode)
        {
            //If the list is empty 
            if (head == null)
            {
                head = newNode;
                head.Next = head;
                head.Prev = head;
                return;
            }

            //Agregegar un nodo si ya hay nodos en la lista 
            //Insertar un nodo al inicio 
            if (newNode.Value < head.Value)
            {
                newNode.Next = head;
                newNode.Prev = head.Prev;
                head.Prev.Next = newNode; //Se actualiza en next del ultimo nodo para que apunte al nuevo nodo
                head.Prev = newNode;
                head = newNode;
                return;
            }

            //Insertar un nodo al final 
            //Evalua si el valor del nuevo nodo es mayor al valor de ultimo nodo (head.Prev.Value)
            if (newNode.Value > head.Prev.Value)
            {
                newNode.Next = head; // El siguiente de newNode
                newNode.Prev = head.Prev;
                head.Prev.Next = newNode; // Update the next of the last node
                head.Prev = newNode; // Update head's previous to the new node
                return;
            }


            // Find the correct position for the new node
            DoubleNode current = head;

            // Traverse the list to find the right spot
            while (current.Next != head && current.Next.Value < newNode.Value)
            {
                current = current.Next;
            }

            // Insert the new node
            newNode.Next = current.Next;
            newNode.Prev = current;

            current.Next.Prev = newNode; // Update the next node's previous
            current.Next = newNode; // Link current node to the new node
        }

        public void Remove(int value)
        {
            if (head == null)
            {
                return;
            }

            if (head.Next == head) // Solo hay un nodo en la lista
            {
                head = null; // La lista queda vacía
                return;
            }

            //Eliminación al inicio 
            if (head.Value == value)
            {
                head.Prev.Next = head.Next; // Update last node's next
                head.Next.Prev = head.Prev; // Update second node's previous
                head = head.Next; // Update head to the next node
                return;
            }

            //Eliminación al final 
            if (head.Prev.Value == value)
            {
                // Aquí eliminamos el último nodo
                head.Prev = head.Prev.Prev; // Mover el puntero de cabeza hacia atrás
                head.Prev.Next = head; // Actualizar el siguiente del nuevo último nodo
                return;
            }

            // Eliminación de un nodo intermedio
            DoubleNode current = head;
            while (current.Next != head && current.Value != value)
            {
                current = current.Next;
            }

            // Si el nodo con el valor fue encontrado
            if (current.Value == value)
            {
                current.Prev.Next = current.Next; // Actualizar el siguiente del nodo anterior
                current.Next.Prev = current.Prev; // Actualizar el anterior del nodo siguiente
            }
        }


        public bool Contains(int value)
        {

            if (head == null)
            {
                return false;
            }

            DoubleNode current = head;
            do
            {
                if (current.Value == value)
                {
                    return true;
                }
                current = current.Next;

            } while (current != head);
            return false;
        }

        //implement the method count
        public int Count()
        {
            if (head == null)
            {
                return 0;
            }
            int count = 0;
            DoubleNode current = head;
            do
            {
                count++;
                current = current.Next;
            } while (current != head);
            return count;
        }

        public override string ToString()
        {
            if (head == null)

                return "The doubly circular linked list is void";

            string result = "";
            DoubleNode? current = head;

            do
            {
                result += current.ToString() + " "; // Llama al ToString del nodo
                current = current.Next; // Avanza al siguiente nodo
            } while (current != head); // Detenerse cuando se regrese al nodo cabeza

            return result;
        }

        public DoubleNode GetHead() => head;
    }
}
