using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms
{
    internal class MergeAlgorithms
    {
        public static async Task MergeSort(int[] array, int left, int right, Action<int[], int, int> displayCallback)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                // Ordenar la mitad izquierda
                await MergeSort(array, left, mid, displayCallback);

                // Ordenar la mitad derecha
                await MergeSort(array, mid + 1, right, displayCallback);

                // Fusionar las dos mitades
                await Merge(array, left, mid, right, displayCallback);
            }
        }

        private static async Task Merge(int[] array, int left, int mid, int right, Action<int[], int, int> displayCallback)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            // Copiar los datos a los arrays temporales
            Array.Copy(array, left, leftArray, 0, n1);
            Array.Copy(array, mid + 1, rightArray, 0, n2);

            int i = 0, j = 0, k = left;

            // Mezclar las dos mitades
            while (i < n1 && j < n2)
            {
                // Mostrar la comparación
                displayCallback(array, i, j);
                await Task.Delay(500); // Pausa para visualización

                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            // Copiar los elementos restantes si los hay
            while (i < n1)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }

            // Mostrar el arreglo después de la fusión
            displayCallback(array, left, right);
            await Task.Delay(500); // Pausa para visualización
        }
    }
}
