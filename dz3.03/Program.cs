using System;

class Program
{
    //Користувач вводить речення з клавіатури. Вам необхідно підрахувати кількість слів у ньому.
    static void Main()
    {
        //Дозволити українську мову в консолі
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        
        Console.Write("Введіть речення: ");
        string sentence = Console.ReadLine();
        int count = 0;
        bool isWord = false;
        for (int i = 0; i < sentence.Length; i++)
        {
            if (char.IsLetter(sentence[i]))
            {
                if (!isWord)
                {
                    count++;
                    isWord = true;
                }
            }
            else
            {
                isWord = false;
            }
        }
        Console.WriteLine("Кількість слів: " + count);
    }
}
