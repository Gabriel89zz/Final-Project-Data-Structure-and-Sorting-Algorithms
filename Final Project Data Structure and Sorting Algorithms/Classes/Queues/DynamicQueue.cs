using Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Queues
{
    internal class DynamicQueue
    {
        private Node front; // Nodo al frente de la cola
        private Node rear;  // Nodo al final de la cola
        private int count;  // Número de elementos en la cola

        public int Count => count; // Propiedad para obtener el tamaño de la cola

        public DynamicQueue()
        {
            front = null;
            rear = null;
            count = 0;
        }

        // Método para agregar un número a la cola
        public void Enqueue(int number)
        {
            Node newNode = new Node(number);

            if (IsEmpty())
            {
                front = rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }

            count++;
        }

        // Método para eliminar y devolver el número al frente de la cola
        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("La cola está vacía.");
            }

            int data = front.Value;
            front = front.Next;

            if (front == null)
            {
                rear = null; // La cola queda vacía
            }

            count--;
            return data;
        }

        // Método para ver el número al frente de la cola sin eliminarlo
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("La cola está vacía.");
            }

            return front.Value;
        }

        // Método para verificar si la cola está vacía
        public bool IsEmpty()
        {
            return front == null;
        }

        //method to get size of the queue
        public int Size()
        {
            return count;
        }
    }
}
