using System;

class Program
{
    public static string CutTheWord(string sentence, string word)
    {
        int len = sentence.Length;

        sentence = sentence.Replace(word, "---------");

        len = sentence.Length;

        return sentence;
    }


    static void Main()
    {
        string word = "animals";
        string sentence = "People and animals see with their eyes. You have two eyes. Some animals have many eyes. " +
                        "Eyes can be little or big, and they can be many colors. What animals have these eyes? " +
                        "What color are your eyes? What do animals do with their eyes? They look for food. The duck " +
                        "looks for food in water. The gecko has big eyes. It can see well at night. It looks for insects " +
                        "to eat. Eyes help to protect animals from other animals. The crab has two " +
                        "eyes on top of its body. It can see big animals, and then it can run away.";

        Console.WriteLine("The text with \"" + word + "\" the sentence it printed below:\n");
        Console.WriteLine(sentence);

        sentence = CutTheWord(sentence, word);

        Console.WriteLine("\n\n\nThe text without \"" + word + "\" the sentence it printed below:\n");
        Console.WriteLine(sentence);

        Console.ReadKey();
    }
}