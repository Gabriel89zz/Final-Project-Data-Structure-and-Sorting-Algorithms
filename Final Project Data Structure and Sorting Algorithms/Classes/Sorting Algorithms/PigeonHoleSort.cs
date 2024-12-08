using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms
{
    internal class PigeonHoleSort
    {
        public static async Task Sort(int[] numbers, Action<int[]> displayCallback)
        {
            if (numbers == null || numbers.Length == 0)
                return;

            // Encontrar el mínimo y máximo en el arreglo
            int min = numbers.Min();
            int max = numbers.Max();
            int range = max - min + 1;

            // Crear "pigeonholes" (espacios)
            int[] holes = new int[range];

            // Poner los elementos en sus respectivos "pigeonholes"
            foreach (int number in numbers)
            {
                holes[number - min]++;
                await Task.Delay(500); // Simulación de proceso (opcional)
                displayCallback(numbers); // Mostrar el estado actual
            }

            // Reconstruir el arreglo desde los "pigeonholes"
            int index = 0;
            for (int i = 0; i < range; i++)
            {
                while (holes[i]-- > 0)
                {
                    numbers[index++] = i + min;
                    await Task.Delay(500); // Simulación de proceso (opcional)
                    displayCallback(numbers); // Mostrar el estado actual
                }
            }
        }
    }
}
