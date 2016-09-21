using System;

class StringOp
{
    // 1 - Finding if character in the string
    public static bool IsCharFinded(string str, char ch)
    {
        for (int i = 0; i < str.Length; i++)
            if (ch == str[i])
                return true;

        return false;
    }

    // 2 - Return number characters in the string
    public static int CharAmountInString(string str, char ch)
    {
        int count = 0;

        for (int i = 0; i < str.Length; i++)
            if (ch == str[i])
                count++;

        return count;
    }

    // 3 - Remove all characters that include in a string
    public static string RemoveCharacter(string str, char ch)
    {
        string temp = str;

        for (int i = 0; i < temp.Length; i++)
        {
            if (ch == temp[i])
            {
                temp = temp.Remove(i, 1);
                i--;
            }
        }

        return temp;
    }

    // 4 - 
    public static bool FindSubString(string sentence, string word)
    {
        string st = string.Empty;
        int location = sentence.IndexOf(word);

        if (sentence.Length - location == word.Length)
            st = sentence.Substring(location, word.Length);

        if (st.Equals(word)) return true;

        #region ManulSearching
        //int count = 0;
        //    // Manual search...
        //    for (int i = 0; i < sentence.Length; i++)
        //    {
        //        count = 0;
        //        while (word[count] == sentence[i + count])
        //        {
        //            count++;

        //            if (count == word.Length)
        //                return true;
        //        }
        //    }
        #endregion

        return false;
    }

    public static string RemoveDuplicateContinuousCharacter(string sentence)
    {
        for (int i = 0; i < sentence.Length - 1; i++)
            if (sentence[i] == sentence[i + 1])
                sentence = sentence.Remove(i--, 1);

        return sentence;
    }
}

class Program
{
    static void Main()
    {
        string word = "bug it?";
        string sentence = "Everyone knows that debugging is twice as hard as writing a program in the first place." +
            " So if you're as clever as you can be when you write it, how will you ever debug it?";

        string str = "Hello World!";
        char ch = 'l';
        bool flag;
        int cn = 0;
        string st1 = "";

        flag = StringOp.IsCharFinded(str, ch);
        cn = StringOp.CharAmountInString(str, ch);
        st1 = StringOp.RemoveCharacter(str, ch);

        StringOp.FindSubString(sentence, word);

        sentence = "Hello world           ssddds s s";
        sentence = StringOp.RemoveDuplicateContinuousCharacter(sentence);

        Console.ReadKey();
    }
}