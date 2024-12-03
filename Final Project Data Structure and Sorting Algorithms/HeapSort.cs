using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms
{
    internal class HeapSort
    {
        public static async Task Sort(int[] array, Action<int[], int, int> displayCallback, SortMetrics metrics)
        {
            int n = array.Length;

            // Construir un heap (ordenar en su lugar)
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                await Heapify(array, n, i, displayCallback, metrics);
            }

            // Extraer elementos del heap
            for (int i = n - 1; i >= 0; i--)
            {
                // Mover la raíz del heap al final
                metrics.SwapsCount++;
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                displayCallback(array, 0, i);  // Resaltamos el intercambio
                await Task.Delay(500);  // Pausa para visualizar el intercambio

                // Llamar a heapify en el árbol reducido
                await Heapify(array, i, 0, displayCallback, metrics);
            }

            displayCallback(array, -1, -1); // Visualización final
        }

        private static async Task Heapify(int[] array, int n, int i, Action<int[], int, int> displayCallback, SortMetrics metrics)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            // Comparar si el hijo izquierdo es mayor que la raíz
            metrics.ComparisonsCount++;
            if (left < n && array[left] > array[largest])
            {
                largest = left;
            }

            // Comparar si el hijo derecho es mayor que el mayor hasta ahora
            metrics.ComparisonsCount++;
            if (right < n && array[right] > array[largest])
            {
                largest = right;
            }

            // Si el mayor no es la raíz
            if (largest != i)
            {
                metrics.SwapsCount++;
                int temp = array[i];
                array[i] = array[largest];
                array[largest] = temp;
                displayCallback(array, i, largest);  // Resaltamos el intercambio
                await Task.Delay(500);  // Pausa para visualizar el intercambio

                // Recursivamente heapify el subárbol afectado
                await Heapify(array, n, largest, displayCallback, metrics);
            }
        }
    }
}
