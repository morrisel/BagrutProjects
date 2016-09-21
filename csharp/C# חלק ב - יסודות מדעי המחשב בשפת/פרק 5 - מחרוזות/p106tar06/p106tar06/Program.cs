using System;

class Program
{
    static void OrderedPair(string str)
    {
        char ch1, ch2;
        for (int i = 0; i < str.Length - 1; i++)
        {
            ch1 = str[i];
            ch2 = str[i + 1];

            if (ch1 == --ch2)
                Console.WriteLine("({0}, {1})", str[i], str[i + 1]);
        }
    }

    static void Main()
    {
        string str;

        str = "$5cd#nm$uvw";
        OrderedPair(str);

        Console.ReadKey();
    }
}