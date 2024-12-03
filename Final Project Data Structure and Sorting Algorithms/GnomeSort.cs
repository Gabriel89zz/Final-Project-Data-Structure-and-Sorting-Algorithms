using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms
{
    internal static class GnomeSort
    {
        public static async Task Sort(int[] array, Action<int[], int, int> displayCallback, SortMetrics metrics)
        {
            int index = 0;

            while (index < array.Length)
            {
                // Comparación
                metrics.ComparisonsCount++;
                if (index == 0 || array[index] >= array[index - 1])
                {
                    displayCallback(array, index, index - 1);  // Resaltamos los números que estamos comparando
                    await Task.Delay(500);  // Pausa para visualizar la comparación sin intercambio
                    index++;
                }
                else
                {
                    // Intercambio
                    metrics.SwapsCount++;
                    displayCallback(array, index, index - 1);  // Resaltamos los números que estamos intercambiando
                    await Task.Delay(500);  // Pausa para visualizar el intercambio

                    int temp = array[index];
                    array[index] = array[index - 1];
                    array[index - 1] = temp;

                    index--;
                    if (index < 0)
                    {
                        index = 0;
                    }

                    displayCallback(array, -1, -1);  // Actualización visual
                    await Task.Delay(500);  // Pausa para visualizar el estado después del intercambio
                }
            }

            displayCallback(array, -1, -1); // Visualización final
        }
    }
}
