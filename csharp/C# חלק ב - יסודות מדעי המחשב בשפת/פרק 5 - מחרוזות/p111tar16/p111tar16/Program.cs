using System;

class Program
{
    public static string ReoderString(string str)
    {
        string temp1 = "", temp2 = "";

        for (int i = 1; i <= str.Length; i+=2)
        {
            temp1 = str.Substring(i - 1, 1) + str.Substring(i, 1);
            temp2 = str.Substring(i, 1) + str.Substring(i - 1, 1);

            str = str.Replace(temp1, temp2);
        }

        return str;
    }

    static void Main()
    {
        string str = "ABCDEFGHIJ";

        Console.WriteLine("The original string is: {0}", str);

        str = ReoderString(str);

        Console.WriteLine("The string after reorder is: {0}", str);

        Console.ReadKey();
    }
}