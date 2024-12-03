using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms
{
    internal static class GnomeSort
    {
        public static async Task Sort(int[] array, Action<int[], int, int> displayCallback)
        {
            int index = 0;

            while (index < array.Length)
            {
                if (index == 0 || array[index] >= array[index - 1])
                {
                    displayCallback(array, index, index - 1);  // Llamada correcta
                    await Task.Delay(1000);
                    index++;
                }
                else
                {
                    (array[index], array[index - 1]) = (array[index - 1], array[index]);
                    displayCallback(array, index, index - 1);  // Llamada correcta
                    await Task.Delay(1000);
                    index--;
                }
            }
            displayCallback(array, -1, -1); // Final
        }
    }
}
