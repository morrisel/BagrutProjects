using System;

class Program
{
    static int GetStrings(string[] str, string s)
    {
        int count = 0;

        for (int i = 0; i < str.Length; i++)
            if (str[i].IndexOf(s) >= 0)
                count++;

        return count;
    }

    static void Main()
    {
        string[] str = new string[5];
        string s = "ab";

        Console.WriteLine("Find how many strings include the: \"{0}\" string", s);

        for (int i = 0; i < str.Length; i++)
        {
            Console.Write("Enter some string text: ");
            str[i] = Console.ReadLine();
        }

        
        //GetStrings(str, s);
        Console.WriteLine("In the next putted strings finded {0} included strings", GetStrings(str, s));
        

        Console.ReadKey();
    }
}