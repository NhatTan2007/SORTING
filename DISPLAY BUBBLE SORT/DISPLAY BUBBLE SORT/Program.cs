using System;

namespace DISPLAY_BUBBLE_SORT
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 640, 4, 250, -12, 232, 11, -90 };
            BubbleSort(arr);
        }

        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                        swapped = true;
                    }
                }
                Console.WriteLine($"Pass {i + 1}: \t{DisplayArrayBubbleSort(arr)}");
                if (!swapped) break;
            }
        }
        
        static string DisplayArrayBubbleSort(int[] arr)
        {
            string resultToPrint = "";
            foreach (int item in arr)
            {
                resultToPrint += $"{item } ";
            }
            return resultToPrint;
        }
    }
}
