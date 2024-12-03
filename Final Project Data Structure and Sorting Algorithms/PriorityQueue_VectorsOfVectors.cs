using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms
{
    internal class PriorityQueue_VectorsOfVectors
    {
        private int[][] priorityLevels;
        private int[] sizes;

        public PriorityQueue_VectorsOfVectors(int numberOfLevels, int maxElementsPerLevel)
        {
            if (numberOfLevels <= 0 || maxElementsPerLevel <= 0)
                throw new ArgumentException("El número de niveles y elementos por nivel deben ser mayores a 0.");

            priorityLevels = new int[numberOfLevels][];
            sizes = new int[numberOfLevels];

            for (int i = 0; i < numberOfLevels; i++)
            {
                priorityLevels[i] = new int[maxElementsPerLevel];
                sizes[i] = 0;
            }
        }

        // Agrega un elemento a un nivel de prioridad específico
        public void Enqueue(int priority, int value)
        {
            if (priority < 0 || priority >= priorityLevels.Length)
                throw new ArgumentOutOfRangeException(nameof(priority), "El nivel de prioridad está fuera del rango.");

            if (sizes[priority] >= priorityLevels[priority].Length)
                throw new InvalidOperationException($"El nivel de prioridad {priority} está lleno.");

            priorityLevels[priority][sizes[priority]] = value;
            sizes[priority]++;
        }

        // Elimina y devuelve el primer elemento de la cola con la mayor prioridad disponible
        public int Dequeue()
        {
            for (int i = 0; i < priorityLevels.Length; i++)
            {
                if (sizes[i] > 0)
                {
                    int value = priorityLevels[i][0];
                    ShiftLeft(i);
                    sizes[i]--;
                    return value;
                }
            }

            throw new InvalidOperationException("La cola de prioridad está vacía.");
        }

        // Devuelve el primer elemento de la cola con la mayor prioridad disponible sin eliminarlo
        public int Peek()
        {
            for (int i = 0; i < priorityLevels.Length; i++)
            {
                if (sizes[i] > 0)
                {
                    return priorityLevels[i][0];
                }
            }

            throw new InvalidOperationException("La cola de prioridad está vacía.");
        }

        // Verifica si la cola de prioridad está vacía
        public bool IsEmpty()
        {
            foreach (var size in sizes)
            {
                if (size > 0)
                    return false;
            }
            return true;
        }

        // Desplaza los elementos hacia la izquierda después de un Dequeue
        private void ShiftLeft(int level)
        {
            for (int j = 1; j < sizes[level]; j++)
            {
                priorityLevels[level][j - 1] = priorityLevels[level][j];
            }
        }

        public List<string> GetQueueState()
        {
            List<string> state = new List<string>();

            for (int i = 0; i < priorityLevels.Length; i++)
            {
                state.Add($"Level {i}:");
                for (int j = 0; j < sizes[i]; j++)
                {
                    state.Add($"  {priorityLevels[i][j]}");
                }

                if (sizes[i] == 0)
                {
                    state.Add("  Empty");
                }
            }

            return state;
        }
    }
}
