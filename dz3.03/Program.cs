using System;

class Program
{
    static void Main()
    {
        int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] arr2 = { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        int[] arr3 = new int[arr1.Length + arr2.Length];
        int k = 0;
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr2.Length; j++)
            {
                if (arr1[i] == arr2[j])
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }
        }
        for (int i = 0; i < k; i++)
        {
            Console.Write(arr3[i] + " ");
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}
