using System;

class Program
{
    static string ABC(string abc)
    {
        for (int i = 0; i < 26; i++)
            abc = abc + (char)(97 + i);

        return abc;
    }

    static void Main()
    {
        string str = "";

        Console.WriteLine("Before running \"ABC(string)\" : str = {0}", str);
        str = ABC(str);
        Console.WriteLine("After running \"ABC(string)\" : str = {0}", str);

        Console.ReadKey();
    }
}