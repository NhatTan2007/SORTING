using System;

namespace DISPLAY_INSERTION_SORT
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 12, 11, 13, 5, 6 };
            InsertionSort(arr);
        }
        static void InsertionSort(int[] arrInput)
        {
            for (int i = 1; i < arrInput.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (arrInput[j - 1] > arrInput[j])
                    {
                        int temp = arrInput[j - 1];
                        arrInput[j - 1] = arrInput[j];
                        arrInput[j] = temp;
                    }
                    else break;
                }
                Console.WriteLine($"Pass {i}: \t{DisplayArray(arrInput)}");
            }
        }

        static string DisplayArray(int[] arr)
        {
            string result = "";
            foreach (int item in arr)
            {
                result += $"{item} ";
            }
            return result;
        }
    }

    
}
