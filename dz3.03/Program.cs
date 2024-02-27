using System;

class Program
{
    static void Main()
    { 
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
        int count = 0;
        Console.WriteLine("Array: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < number)
            {
                count++;
            }
        }
        Console.WriteLine("Count: " + count);

    }
}