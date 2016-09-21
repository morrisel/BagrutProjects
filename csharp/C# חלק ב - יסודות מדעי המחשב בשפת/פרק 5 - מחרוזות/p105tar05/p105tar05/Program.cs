using System;

class Program
{
    static string ReverseString(string str)
    {
        string strReverse = "";
        
        for (int i = 0; i < str.Length; i++)
            strReverse = strReverse + str[str.Length-i-1];

        return strReverse;
    }

    static void Main()
    {
        string originalStr;
        string tempStr;

        Console.Write("Please enter a some string: ");
        originalStr = Console.ReadLine();
        tempStr = originalStr;

        Console.WriteLine("\nBefore reversing the string is: " + originalStr);
        originalStr = ReverseString(originalStr);

        Console.WriteLine("\nAfter reversing the string is: " + originalStr);

        Console.WriteLine("-----------------------------");

        if (originalStr == tempStr)
            Console.WriteLine("The string is a palindrome");
        else
            Console.WriteLine("The string isn't a palindrome");

        

        Console.ReadKey();
    }
}