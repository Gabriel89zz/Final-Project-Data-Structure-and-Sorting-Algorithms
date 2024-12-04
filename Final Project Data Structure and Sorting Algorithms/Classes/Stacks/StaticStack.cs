﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Stacks
{
    internal class StaticStack
    {
        private int[] elements; // Arreglo para almacenar los elementos
        private int top;        // Índice del elemento en el tope de la pila

        // Constructor que inicializa la pila con un tamaño fijo
        public StaticStack()
        {
            elements = new int[8];
            top = -1;           // Inicialmente, la pila está vacía
        }

        // Método para insertar un elemento en la pila
        public void Push(int dato)
        {
            if (IsFull())
            {
                MessageBox.Show("La pila estatica está llena.");
                return;
            }
            elements[++top] = dato; // Incrementar 'top' y agregar el dato
        }

        // Método para eliminar y devolver el elemento en el tope de la pila
        public string Pop()
        {
            if (IsEmpty())
            {
                return "La pila está vacía.";
            }
            return elements[top--].ToString(); // Devolver y decrementar 'top'
        }

        // Método para devolver el elemento en el tope de la pila sin eliminarlo
        public string Peek()
        {
            if (IsEmpty())
            {
                return "La pila está vacía.";
            }
            return elements[top].ToString(); // Devolver el valor sin modificar 'top'
        }

        // Método para verificar si la pila está vacía
        public bool IsEmpty()
        {
            return top == -1; // La pila está vacía si 'top' es -1
        }

        // Método para verificar si la pila está llena
        public bool IsFull()
        {
            return top == elements.Length - 1; // La pila está llena si 'top' alcanza el tamaño máximo
        }

        // Método para devolver el tamaño de la pila
        public int Size()
        {
            return top + 1; // El tamaño actual es 'top + 1'
        }
    }
}