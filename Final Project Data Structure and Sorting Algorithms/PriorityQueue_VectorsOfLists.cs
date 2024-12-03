using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms
{
    internal class PriorityQueue_VectorsOfLists
    {
        private List<int>[] priorityLevels; 
        private int numberOfLevels;        

        public PriorityQueue_VectorsOfLists(int numberOfLevels)
        {
            if (numberOfLevels <= 0)
                throw new ArgumentException("El número de niveles de prioridad debe ser mayor a 0.");

            this.numberOfLevels = numberOfLevels;
            priorityLevels = new List<int>[numberOfLevels];

            // Inicializamos cada nivel como una lista vacía
            for (int i = 0; i < numberOfLevels; i++)
            {
                priorityLevels[i] = new List<int>();
            }
        }

        // Método para agregar elementos a la cola con una prioridad específica
        public void Enqueue(int priority, int value)
        {
            if (priority < 0 || priority >= numberOfLevels)
                throw new ArgumentOutOfRangeException(nameof(priority), "El nivel de prioridad está fuera del rango.");

            // Agrega el valor a la lista correspondiente al nivel de prioridad
            priorityLevels[priority].Add(value);
        }

        // Método para eliminar el primer elemento de la cola (mayor prioridad)
        public int Dequeue()
        {
            for (int i = 0; i < numberOfLevels; i++)
            {
                if (priorityLevels[i].Count > 0) // Si hay elementos en este nivel de prioridad
                {
                    int value = priorityLevels[i][0]; // Tomamos el primer elemento
                    priorityLevels[i].RemoveAt(0);    // Lo eliminamos de la lista
                    return value;
                }
            }

            throw new InvalidOperationException("La cola de prioridad está vacía.");
        }

        // Método para espiar el primer elemento de la cola (mayor prioridad) sin eliminarlo
        public int Peek()
        {
            for (int i = 0; i < numberOfLevels; i++)
            {
                if (priorityLevels[i].Count > 0)
                {
                    return priorityLevels[i][0]; // Devuelve el primer elemento del primer nivel con elementos
                }
            }

            throw new InvalidOperationException("La cola de prioridad está vacía.");
        }

        // Método para obtener el estado actual de la cola en formato de lista de cadenas
        public List<string> GetQueueState()
        {
            List<string> state = new List<string>();

            for (int i = 0; i < numberOfLevels; i++)
            {
                state.Add($"Nivel {i}:");
                if (priorityLevels[i].Count > 0)
                {
                    foreach (var item in priorityLevels[i])
                    {
                        state.Add($"  {item}");
                    }
                }
                else
                {
                    state.Add("  Vacío");
                }
            }

            return state;
        }
    }
}
