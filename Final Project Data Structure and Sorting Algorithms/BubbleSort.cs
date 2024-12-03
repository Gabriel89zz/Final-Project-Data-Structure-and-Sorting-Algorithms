using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms
{
    internal class BubbleSort
    {
        public static async Task Sort(int[] arr, Action<int[], int, int> displayCallback, TextBox logTextBox)
        {
            int n = arr.Length;
            int i, j, temp;
            bool swapped;

            // Contadores de comparaciones e intercambios
            int comparisonsCount = 0;
            int swapsCount = 0;

            // Recorre el arreglo para realizar las comparaciones e intercambios
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (j = 0; j < n - i - 1; j++)
                {
                    comparisonsCount++;  // Incrementa el contador de comparaciones

                    // Mostrar los números que se están comparando
                    displayCallback(arr, j, j + 1);

                    // Esperar para mostrar la comparación
                    await Task.Delay(400);

                    if (arr[j] > arr[j + 1])
                    {
                        // Intercambiar los elementos
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true;
                        swapsCount++;  // Incrementa el contador de intercambios

                        // Mostrar los números después de intercambiarlos
                        displayCallback(arr, j, j + 1);
                        await Task.Delay(400);
                    }
                }

                // Si no se hicieron intercambios, el arreglo está ordenado
                if (!swapped)
                    break;
            }

            // Mostrar el resultado final en el TextBox
            logTextBox.AppendText($"Comparaciones: {comparisonsCount}\n");
            logTextBox.AppendText($"Intercambios: {swapsCount}\n");
        }
    }
}
