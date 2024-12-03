using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms
{
    internal class PriorityQueue_ListOfVectors
    {
        private List<int[]> priorityLevels;  // Lista que contiene arreglos para cada nivel
        private int maxElementsPerLevel;     // Número máximo de elementos por nivel

        public PriorityQueue_ListOfVectors(int maxElementsPerLevel)
        {
            if (maxElementsPerLevel <= 0)
                throw new ArgumentException("El número de elementos por nivel debe ser mayor a 0.");

            this.maxElementsPerLevel = maxElementsPerLevel;
            priorityLevels = new List<int[]>();  // Lista dinámica de niveles
        }

        // Método para agregar un elemento a la cola con una prioridad específica
        public void Enqueue(int priority, int value)
        {
            // Si el nivel de prioridad es mayor que los niveles existentes, agregamos nuevos niveles
            while (priority >= priorityLevels.Count)
            {
                priorityLevels.Add(new int[0]);  // Crear un nuevo nivel vacío
            }

            int[] currentLevel = priorityLevels[priority];

            // Si el nivel está lleno, redimensionamos el arreglo
            if (currentLevel.Length == maxElementsPerLevel)
            {
                //Array.Resize(ref currentLevel, maxElementsPerLevel * 2);  // Doblamos el tamaño
                throw new InvalidOperationException("El numero de elementos de la cola de prioridad con lista de vectores esta lleno");
            }

            // Agregamos el valor al final del arreglo en el nivel de prioridad
            currentLevel[Array.FindIndex(currentLevel, x => x == 0)] = value;
            priorityLevels[priority] = currentLevel;  // Actualizamos el nivel
        }

        // Método para eliminar el primer elemento de la cola (mayor prioridad)
        public int Dequeue()
        {
            for (int i = 0; i < priorityLevels.Count; i++)
            {
                int[] currentLevel = priorityLevels[i];
                if (currentLevel.Length > 0)
                {
                    int value = currentLevel[0];

                    // Desplazamos los elementos hacia la izquierda
                    for (int j = 1; j < currentLevel.Length; j++)
                    {
                        currentLevel[j - 1] = currentLevel[j];
                    }

                    // Redimensionamos el arreglo para eliminar el último elemento
                    Array.Resize(ref currentLevel, currentLevel.Length - 1);
                    priorityLevels[i] = currentLevel;  // Actualizamos el nivel
                    return value;
                }
            }

            throw new InvalidOperationException("La cola de prioridad está vacía.");
        }

        // Método para espiar el primer elemento de la cola (mayor prioridad) sin eliminarlo
        public int Peek()
        {
            for (int i = 0; i < priorityLevels.Count; i++)
            {
                int[] currentLevel = priorityLevels[i];
                if (currentLevel.Length > 0)
                {
                    return currentLevel[0];  // Devuelve el primer elemento del primer nivel con elementos
                }
            }

            throw new InvalidOperationException("La cola de prioridad está vacía.");
        }

        // Método para obtener el estado actual de la cola en formato de lista de cadenas
        public List<string> GetQueueState()
        {
            List<string> state = new List<string>();

            for (int i = 0; i < priorityLevels.Count; i++)
            {
                state.Add($"Nivel {i}:");
                int[] currentLevel = priorityLevels[i];
                if (currentLevel.Length > 0)
                {
                    foreach (var item in currentLevel)
                    {
                        if (item != 0) state.Add($"  {item}");
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
