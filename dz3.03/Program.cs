using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3 };
        int even = 0, odd = 0, unique = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
                even++;
            else
                odd++;
            bool isUnique = true;
            for (int j = 0; j < i; j++)
            {
                if (arr[i] == arr[j])
                {
                    isUnique = false;
                    break;
                }
            }
            if (isUnique)
                unique++;
        }
        Console.WriteLine("Even: {0}, Odd: {1}, Unique: {2}", even, odd, unique);
    }
}
