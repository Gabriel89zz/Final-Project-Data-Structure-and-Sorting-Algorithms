using Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Queues
{
    internal class DoubleEndedDynamicQueue
    {
        private DoubleNode front;  // Frente de la cola
        private DoubleNode back;   // Final de la cola
        private int size;    // Tamaño de la cola

        public DoubleEndedDynamicQueue()
        {
            front = null;
            back = null;
            size = 0;
        }

        // Agregar un elemento al frente de la cola
        public void InsertFront(int value)
        {
            DoubleNode newNode = new DoubleNode(value);

            if (IsEmpty())
            {
                front = back = newNode;  // Si la cola está vacía, el nuevo nodo es tanto el frente como el final
            }
            else
            {
                newNode.Next = front;
                front.Prev = newNode;
                front = newNode;
            }

            size++;
        }

        // Agregar un elemento al final de la cola
        public void InsertRear(int value)
        {
            DoubleNode newNode = new DoubleNode(value);

            if (IsEmpty())
            {
                front = back = newNode;  // Si la cola está vacía, el nuevo nodo es tanto el frente como el final
            }
            else
            {
                newNode.Prev = back;
                back.Next = newNode;
                back = newNode;
            }

            size++;
        }

        // Eliminar un elemento del frente de la cola
        public int DeleteFront()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            int frontValue = front.Value;
            front = front.Next;

            if (front != null)
            {
                front.Prev = null;
            }
            else
            {
                back = null;  // Si la cola queda vacía, el final también debe ser nulo
            }

            size--;
            return frontValue;
        }

        // Eliminar un elemento del final de la cola
        public int DeleteRear()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            int backValue = back.Value;
            back = back.Prev;

            if (back != null)
            {
                back.Next = null;
            }
            else
            {
                front = null;  // Si la cola queda vacía, el frente también debe ser nulo
            }

            size--;
            return backValue;
        }

        // Ver el elemento del frente de la cola sin eliminarlo
        public int GetFront()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return front.Value;
        }

        // Ver el elemento del final de la cola sin eliminarlo
        public int GetRear()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return back.Value;
        }

        // Obtener el tamaño de la cola
        public int Size()
        {
            return size;
        }

        // Verificar si la cola está vacía
        public bool IsEmpty()
        {
            return size == 0;
        }

        public List<int> GetQueueElements()
        {
            List<int> elements = new List<int>();
            DoubleNode current = front;

            while (current != null)
            {
                elements.Add(current.Value);
                current = current.Next;
            }

            return elements;
        }
    }
}
