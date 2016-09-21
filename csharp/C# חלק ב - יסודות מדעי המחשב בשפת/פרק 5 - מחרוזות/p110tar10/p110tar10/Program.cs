using System;

class Program
{
    // 1. IndexOf(string, int)
    static int FindWord(string sentence, string word)
    {
        int count = 0;

        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence.IndexOf(word, i) >= 0)
            {
                count++;
                i = sentence.IndexOf(word, i);
            }
        }

        return count;
    }

    // 2. IndexOf(string)
    static int FindWordOtherWay(string sentence, string word)
    {
        int lenWord = word.Length;
        int count = 0;
        string subSentence = sentence;

        int start = 0; // the start index from new cutted string

        for (int i = 0; i < sentence.Length; i++)
        {
            if (subSentence.IndexOf(word) >= 0)
            {
                count++;
                start = subSentence.IndexOf(word);

            }

            subSentence = "";
            for (int j = 1; j < sentence.Length - start; j++)
                subSentence = subSentence + sentence[start + j];

            sentence = subSentence;
        }

        return count;
    }

    static void Main()
    {
        string word = "you";
        string sentence = "Everyone knows that debugging is twice as hard as writing a program in the first place."+
            " So if you're as clever as you can be when you write it, how will you ever debug it?";

        //Console.WriteLine("The following sentence is: ");
        //Console.WriteLine(sentence);

        //Console.WriteLine("\nThe word is: ");
        //Console.WriteLine(word);

        //Console.WriteLine("------------------------------------------------------------");

        //Console.WriteLine("The word \"" + word + "\" finded in the sentence " + FindWord(sentence, word) + " times.");

        Console.WriteLine("------------------------Other way-------------------");
        Console.WriteLine("The following sentence is: ");
        Console.WriteLine(sentence);

        Console.WriteLine("\nThe word is: ");
        Console.WriteLine(word);

        Console.WriteLine("------------------------------------------------------------");

        Console.WriteLine("The word \"" + word + "\" finded in the sentence " + FindWordOtherWay(sentence, word) + " times.");

        Console.ReadKey();
    }
}