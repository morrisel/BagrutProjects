using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int charNum;

        for (char tav = 'a'; tav <= 'z'; tav++)
        {
            charNum = (int)tav;
            if (charNum % 2 != 0)
                Console.Write(" " + tav);
        }
        Console.ReadKey();
    }
}