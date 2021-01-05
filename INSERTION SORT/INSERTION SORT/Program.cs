using System;

namespace INSERTION_SORT
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 12, 11, 13, 5, 6 };
            InsertionSort(ref arr);
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
        }

        //Decrease, if u want to increase, change arrInput[j - 1] < arrInput[j] to arrInput[j - 1] > arrInput[j]
        static void InsertionSort(ref int[] arrInput)
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
            }
        }
    }
}
