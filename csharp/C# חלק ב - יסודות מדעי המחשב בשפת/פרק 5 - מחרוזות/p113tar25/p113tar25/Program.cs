using System;

class Program
{
    static string RemoveNextDuplicateWord(string sentence)
    {
        string w1 = "", w2 = "", tempSentence = "";
        int location;

        while (sentence.IndexOf(' ') != -1)
        {
            location = sentence.IndexOf(' ');   // location - w1
            w1 = sentence.Remove(location);
            sentence = sentence.Substring(location + 1, sentence.Length - location - 1);

            location = sentence.IndexOf(' ');  // location - w2

            if (sentence.IndexOf(' ') != -1)
                w2 = sentence.Substring(0, sentence.IndexOf(' '));

            if (w1 != w2)
                tempSentence = tempSentence + w1 + " ";
        }

        tempSentence = tempSentence + w1 + " " + sentence;

        return tempSentence;
    }

    static void Main()
    {
        string sentence = "Hello, I am go go to far far far a a a far way!";

        Console.WriteLine("the sentence before removing duplicates word is: ");
        Console.WriteLine(sentence);

        sentence = RemoveNextDuplicateWord(sentence);
        Console.WriteLine("\nthe sentence after removing duplicates word is: ");
        Console.WriteLine(sentence);

        Console.ReadKey();
    }
}