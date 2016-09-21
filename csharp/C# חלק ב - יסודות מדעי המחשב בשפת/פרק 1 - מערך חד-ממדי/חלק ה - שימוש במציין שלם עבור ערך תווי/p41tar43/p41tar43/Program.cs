using System;

class Program
{
    public static int MaxLength(char[] chArr)
    {
        int len = 0;


        return len;
    }
    public static char[] GetLetter(char[] chArr)
    {
        char[] letter = new char[7];
        int[] count = new int[7];
        int i = 0;
        int counter = 0;

        Console.WriteLine("Enter letters for char array");
        letter[0] = char.Parse(Console.ReadLine());
        while (letter[i] != '*')
        {
            i++;

            letter[i] = char.Parse(Console.ReadLine());

            if (letter[i - 1] == letter[i])
            {
                count[letter[i] - 'a']++;
            }
            else
            {
                count[letter[i - 1] - 'a']++;
            }

            //i++;
        }

        return letter;
    }

    public static char[] GetCharArray()
    {
        char[] letter = new char[1];
        int[] count;
        int i = 0;

        Console.WriteLine("Enter letters for char array");
        letter[0] = char.Parse(Console.ReadLine());
        while (letter[i] != '*')
        {
            i++;
            letter = new char[i + 1];
            count = new int[i + 1];

            letter[i] = char.Parse(Console.ReadLine());
            if (letter[i - 1] == letter[i])
                count[letter[i] - 'a']++;
            else
                count[letter[i - 1] - 'a']++;
        }

        return letter;
    }

    public static void PrintLetters(char[] chArr)
    {
        for (int i = 0; i < chArr.Length; i++)
        {
            Console.Write("({0}, {1}) ", chArr[i], (int)char[chArr]);
        }
    }

    static void Main()
    {
        char[] letters = new char[7];
        //letters[0] = 'd';
        //letters[1] = 'a';
        //letters[2] = 'e';
        //letters[3] = 'e';
        //letters[4] = 'e';
        //letters[5] = 'g';
        //letters[6] = 'g';

        //for (int i = 0; i < letters.Length; i++)
        //{
        //    Console.Write("{0} ", letters[i]);
        //}

        char[] answer = new char[7];
        answer = GetLetter(letters);

        // -----------------------------------------
        char[] let = GetCharArray();

        PrintLetters(let);

        Console.ReadKey();
    }
}