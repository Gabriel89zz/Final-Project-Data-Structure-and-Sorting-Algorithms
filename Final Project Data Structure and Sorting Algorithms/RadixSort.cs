using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms
{
    internal class RadixSort
    {
        public static class RadixMSDSort
        {
            public static async Task Sort(int[] numbers, Action<int[]> displayCallback, Action<string> messageCallback)
            {
                if (numbers == null || numbers.Length == 0)
                    return;

                int maxNumber = numbers.Max();
                int maxDigits = maxNumber.ToString().Length;

                await SortRecursive(numbers, 0, numbers.Length - 1, (int)Math.Pow(10, maxDigits - 1), displayCallback, messageCallback);
            }

            private static async Task SortRecursive(
                int[] numbers,
                int low,
                int high,
                int divisor,
                Action<int[]> displayCallback,
                Action<string> messageCallback)
            {
                if (low >= high || divisor == 0)
                    return;

                // Mensaje de progreso
                string digitName = divisor switch
                {
                    >= 100 => "centenas",
                    10 => "decenas",
                    1 => "unidades",
                    _ => $"dígitos de orden {divisor}"
                };
                messageCallback?.Invoke($"Ordenando por {digitName}...");

                // Crear los buckets para los dígitos (0-9)
                List<int>[] buckets = new List<int>[10];
                for (int i = 0; i < 10; i++)
                    buckets[i] = new List<int>();

                // Distribuir los números en los buckets según el dígito actual
                for (int i = low; i <= high; i++)
                {
                    int bucketIndex = (numbers[i] / divisor) % 10;
                    buckets[bucketIndex].Add(numbers[i]);
                }

                // Reconstruir el arreglo completamente desde los buckets
                int index = low;
                foreach (var bucket in buckets)
                {
                    foreach (var number in bucket)
                    {
                        numbers[index++] = number;
                    }
                }

                // Mostrar los números después de esta etapa
                displayCallback?.Invoke(numbers);
                await Task.Delay(1000); // Pausa para observar

                // Ordenar recursivamente cada bucket
                index = low;
                foreach (var bucket in buckets)
                {
                    if (bucket.Count > 1)
                    {
                        await SortRecursive(numbers, index, index + bucket.Count - 1, divisor / 10, displayCallback, messageCallback);
                    }
                    index += bucket.Count;
                }
            }
        }



        public static class RadixLSDSort
        {
            public static async Task Sort(int[] numbers, Action<int[]> displayCallback, Action<string> messageCallback)
            {
                if (numbers == null || numbers.Length == 0)
                    return;

                int maxNumber = numbers.Max();
                int maxDigits = maxNumber.ToString().Length;

                int divisor = 1;

                for (int i = 0; i < maxDigits; i++)
                {
                    // Mensaje del paso actual
                    string digitName = divisor switch
                    {
                        >= 100 => "centenas",
                        10 => "decenas",
                        1 => "unidades",
                        _ => $"dígitos de orden {divisor}"
                    };
                    messageCallback?.Invoke($"Ordenando por {digitName}...");

                    // Crear buckets para los dígitos (0-9)
                    List<int>[] buckets = new List<int>[10];
                    for (int j = 0; j < 10; j++)
                        buckets[j] = new List<int>();

                    // Distribuir los números en los buckets según el dígito actual
                    foreach (var number in numbers)
                    {
                        int bucketIndex = (number / divisor) % 10;
                        buckets[bucketIndex].Add(number);
                    }

                    // Reconstruir el arreglo desde los buckets
                    int index = 0;
                    foreach (var bucket in buckets)
                    {
                        foreach (var number in bucket)
                        {
                            numbers[index++] = number;
                        }
                    }

                    // Mostrar el estado actual del arreglo
                    displayCallback?.Invoke(numbers);
                    await Task.Delay(1000); // Pausa para observar

                    // Avanzar al siguiente dígito
                    divisor *= 10;
                }

                messageCallback?.Invoke("Ordenamiento completo.");
            }
        }
    }
}
