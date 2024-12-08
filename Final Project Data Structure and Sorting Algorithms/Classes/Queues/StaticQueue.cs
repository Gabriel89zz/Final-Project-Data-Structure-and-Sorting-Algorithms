using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Queues
{
    internal class StaticQueue
    {
        private int[] elements; // Arreglo para almacenar elementos de la cola
        private int front;      // Índice del primer elemento de la cola
        private int rear;       // Índice del último elemento de la cola
        private int count;      // Número de elementos en la cola

        public int Capacity { get; } // Capacidad máxima de la cola

        public StaticQueue(int capacity)
        {
            Capacity = capacity;
            elements = new int[capacity];
            front = 0;
            rear = -1;
            count = 0;
        }

        // Método para agregar un número a la cola
        public void Enqueue(int number)
        {
            if (count == Capacity)
            {
                MessageBox.Show("The Queueu is full.");
                return;
            }

            rear = (rear + 1) % Capacity;
            elements[rear] = number;
            count++;
        }

        // Método para eliminar y devolver el número al frente de la cola
        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("La cola está vacía.");
            }

            int number = elements[front];
            front = (front + 1) % Capacity;
            count--;
            return number;
        }

        // Método para ver el número al frente de la cola sin eliminarlo
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("La cola está vacía.");
            }

            return elements[front];
        }

        // Método para verificar si la cola está vacía
        public bool IsEmpty()
        {
            return count == 0;
        }

        // Método para verificar si la cola está llena
        public bool IsFull()
        {
            return count == Capacity;
        }

        //method to get size of the queue
        public int Size()
        {
            return count;
        }
    }
}
