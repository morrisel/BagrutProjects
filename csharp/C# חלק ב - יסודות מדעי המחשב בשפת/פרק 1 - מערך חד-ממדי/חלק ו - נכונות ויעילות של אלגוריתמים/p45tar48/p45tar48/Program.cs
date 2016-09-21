using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 0, 4, 1, 2, 3 };
        char[] letters = { 'h', 'l', 'o', 'm', 'a', 's' };
        char[] word = new char[6];
        int j = 0;

        for (int i = 0; i < numbers.Length * letters.Length; i++)
        {
            if (numbers[j] == i)
            {
                word[j] = letters[i];
                j++;
            }

            if (i == letters.Length - 1)
                i = -1;

            if (j == word.Length)
                break;
        }

        // printing new array
        for (int i = 0; i < word.Length; i++)
            Console.WriteLine(word[i]);



        Console.ReadKey();
    }
}