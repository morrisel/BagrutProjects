using System;

class Program
{
    static void PrintEvenLength(string[] str)
    {
        for (int i = 0; i < str.Length; i++)
            if (str[i].Length % 2 == 0)
                Console.WriteLine("The string is: " + str[i] + " and length = " + str[i].Length);
    }

    static void GetStrings()
    {
        string[] st = new string[40];

        Console.WriteLine("Enter 40 strings");
        for (int i = 0; i < 40; i++)
            st[i] = Console.ReadLine();

        PrintEvenLength(st);
    }



    static void Main()
    {

        GetStrings();

        Console.ReadKey();
    }
}