using System;

namespace BubbleSort
{
    class Program
    {
        static void Main()
        {
            int[] arr = GenerateRandomArray(10, 1, 100);

            Console.WriteLine("Original Array:");
            PrintArray(arr);

            BubbleSort(arr);

            Console.WriteLine("\nSorted Array:");
            PrintArray(arr);
        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            // Outer loop for the number of passes
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                // Inner loop for comparing and swapping adjacent elements
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Compare adjacent elements
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j + 1]
                        Swap(arr, j, j + 1);

                        swapped = true;
                    }
                }

                // If no swaps were made in this pass, the array is already sorted
                if (!swapped)
                    break;
            }
        }

        static void Swap(int[] arr, int i, int j)
        {
            // Swap two elements in the array
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static int[] GenerateRandomArray(int size, int minValue, int maxValue)
        {
            // Generate an array of random integers
            Random random = new Random();
            int[] randomArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                randomArray[i] = random.Next(minValue, maxValue + 1);
            }

            return randomArray;
        }

        static void PrintArray(int[] arr)
        {
            // Print the elements of the array
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
