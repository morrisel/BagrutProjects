using System;

class Ch1Solve12Letters
{
    const int N = 26;

    static void Main()
    {
        int[] letters = new int[N];
        int maxIndex;
        char ch, maxIndexLet;

        for (int i = 0; i < N; i++)
            letters[i] = 0;

        for (int i = 0; i < 100; i++)
        {
            Console.Write("Enter a letter:  ");
            ch = char.Parse(Console.ReadLine());
            letters[ch - 'a']++;
        }

        maxIndex = 0;
        for (int i = 1; i < letters.Length; i++)
        {
            if (letters[i] > letters[maxIndex])
                maxIndex = i;
        }

        maxIndexLet = (char)(maxIndex + 'a');
        Console.WriteLine("The most frequent letter is " + maxIndexLet);
        Console.WriteLine("The letters that did not appear are:");

        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i] == 0)
                Console.WriteLine((char)(i + 'a'));
        }


        Console.ReadKey();
    }
}