using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Queues
{
    internal class CircularQueue
    {
        private int[] array;
        private int front;
        private int rear;
        private int count;
        public int Capacity { get; }

        // Constructor para inicializar la cola circular con un tamaño determinado
        public CircularQueue(int capacity)
        {
            Capacity = capacity;
            array = new int[capacity];
            front = 0;
            rear = -1;
            count = 0;
        }

        // Método para agregar un elemento al final de la cola
        public void Enqueue(int value)
        {
            if (count == Capacity)
            {
                MessageBox.Show("The Queueu is full.");
                return;
            }

            rear = (rear + 1) % Capacity;  // Mover el índice rear de forma circular
            array[rear] = value;
            count++;
        }

        // Método para eliminar un elemento del frente de la cola
        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("La cola está vacía.");
            }

            int dequeuedValue = array[front];
            front = (front + 1) % Capacity;  // Mover el índice front de forma circular
            count--;
            return dequeuedValue;
        }

        // Método para ver el valor del frente de la cola sin eliminarlo
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("La cola está vacía.");
            }

            return array[front];
        }

        // Método para obtener el número de elementos en la cola
        public int Size()
        {
            return count;
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
    }
}
