using System;

class Program
{
    //public static string CutTheWord(string sentence, string word)
    //{
    //    int len = sentence.Length;

    //    sentence = sentence.Replace(word, "---------");

    //    len = sentence.Length;

    //    return sentence;
    //}

    static string What1(string st, int from, int to)
    {
        string st1, st2;

        st1 = st.Substring(0, from);

        st2 = st.Substring(to);

        string str = st.Substring(0, from) + st.Substring(to);

        return str;
    }

    static string What2(string st, int from, int to)
    {
        string st1 = st.Substring(from, to);

        st1 = st.Replace(st1, "--");

        string str = st.Replace(st.Substring(from, to), "");

        return str;

    }

    static string What3(string st, string sub, int place)
    {
        string strTest = st.Substring(place);

        string str = st.Substring(0, place) + sub + st.Substring(place);

        return str;
    }

    static void Main()
    {
        int from = 5, to = 10, place = 4;

        string st = "People and animals see with their eyes";

        string sub = "COMPUTER";

        //int len1St, len2Sub;

        //len1St = st.Length;
        //len2Sub = sub.Length;

        string str;

        Console.WriteLine("The original \"st\" sentence it printed below:");
        Console.WriteLine(st);

        Console.WriteLine("\nThe original \"sub\" sentence it printed below:");
        Console.WriteLine(sub);


        Console.WriteLine("\n------------------------------------------------------------------------------\n");
 
        str = What1(st, from, to);

        Console.WriteLine(str);

        str = "";

        str = What2(st, from, to);
        Console.WriteLine("\n" + str);


        str = "";

        str = What3(st, sub, 4);
        Console.WriteLine("\n" + str);

        Console.ReadKey();
    }
}