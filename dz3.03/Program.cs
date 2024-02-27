using System;

class Program
{
    //Знайти мінімальний та максиманий елементи в двовимірному масиві, вивести їх на екран
    //випадковий двовимірний масив
    static void Main()
    {
        int[,] arr = new int[6, 6];
        Random rand = new Random();
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = rand.Next(10, 40);
            }
        }

        int min = arr[0, 0];
        int max = arr[0, 0];
        Console.WriteLine("Array:");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] < min)
                {
                    min = arr[i, j];
                }
                if (arr[i, j] > max)
                {
                    max = arr[i, j];
                }
            }
        }
        Console.WriteLine("Min: " + min);
        Console.WriteLine("Max: " + max);
    }
}
