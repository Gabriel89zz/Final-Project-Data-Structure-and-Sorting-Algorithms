using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Queues
{
    internal class DoubleEndedStaticQueue
    {
        private int[] array;
        private int front;
        private int rear;
        private int size;
        private int capacity;

        public DoubleEndedStaticQueue(int capacity)
        {
            this.capacity = capacity;
            array = new int[capacity];
            front = -1;
            rear = -1;
            size = 0;
        }

        // Verifica si la cola está vacía
        public bool IsEmpty()
        {
            return size == 0;
        }

        // Verifica si la cola está llena
        public bool IsFull()
        {
            return size == capacity;
        }

        // Inserta un elemento en el frente de la cola
        public void InsertFront(int value)
        {
            if (size == array.Length) throw new InvalidOperationException("Queue is full.");

            // Mover todos los elementos una posición hacia atrás
            for (int i = size - 1; i >= 0; i--)
            {
                array[i + 1] = array[i];
            }

            // Insertar el valor al frente
            array[0] = value;
            if (front == -1) front = 0;
            rear = (rear + 1) % array.Length;
            size++;
        }

        // Inserta un elemento en el final de la cola
        public void InsertRear(int value)
        {
            if (IsFull()) throw new InvalidOperationException("Queue is full.");

            if (rear == -1) // Si la cola está vacía
            {
                front = 0;
                rear = 0;
            }
            else
            {
                rear = (rear + 1) % capacity; // Mover el índice del final hacia adelante
            }

            array[rear] = value;
            size++;
        }

        // Elimina un elemento del frente de la cola
        public int DeleteFront()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Deque is empty.");
                return -1;
            }

            int value = array[front];
            if (front == rear) // Si hay un solo elemento
            {
                front = -1;
                rear = -1;
            }
            else
            {
                front = (front + 1) % capacity; // Mover el índice del frente hacia adelante
            }

            size--;
            return value;
        }

        // Elimina un elemento del final de la cola
        public int DeleteRear()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Deque is empty.");
                return -1;
            }

            int value = array[rear];
            if (front == rear) // Si hay un solo elemento
            {
                front = -1;
                rear = -1;
            }
            else
            {
                rear = (rear - 1 + capacity) % capacity; // Mover el índice del final hacia atrás
            }

            size--;
            return value;
        }

        // Ver el valor en el frente sin eliminarlo
        public int GetFront()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Deque is empty.");
                return -1;
            }
            return array[front];
        }

        // Ver el valor en el final sin eliminarlo
        public int GetRear()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Deque is empty.");
                return -1;
            }
            return array[rear];
        }

        // Obtener el tamaño actual de la cola
        public int Size()
        {
            return size;
        }

        public List<int> GetQueueElements()
        {
            List<int> elements = new List<int>();

            if (front != -1)
            {
                for (int i = front; i <= rear; i++)
                {
                    elements.Add(array[i]);
                }
            }

            return elements;
        }
    }
}
