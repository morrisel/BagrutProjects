using System;

/* שלב 1: נמיין את המערך */
/* שלב 2: נצור מעך חדש שבו יכנסו הערכים החסרים מהמערך הממוין */

class Program
{
    static void Main()
    {
        char chTemp;
        int index = 0, count = 0;

        char[] chLower = new char[26];
        char[] chUpper = new char[26];

        char[] allLetters;
        char[] let = { 'a', 't', 'B', 'e', 'X', 'm' };

        Console.WriteLine("printing array 'let' before sorting #");
        for (int i = 0; i < let.Length; i++)
            Console.Write("{0,2}", let[i]);

        // ------------------------------------------- שלב 1
        // ABC-תחילה נמיין את המערך לפי ה
        for (int i = 0; i < let.Length - 1; i++)
        {
            for (int j = 1; j < let.Length; j++)
            {
                if (let[j - 1] > let[j])
                {
                    chTemp = let[j];
                    let[j] = let[j - 1];
                    let[j - 1] = chTemp;
                }
            }
        }

        // let[] = B, X, a, e, m, t
        Console.WriteLine("\n\nprinting array 'let' after sorting #");
        for (int i = 0; i < let.Length; i++)
            Console.Write("{0,2}", let[i]);

        // ------------------------------------------- שלב 2
        // 65-90: A-Z
        // 97-123: a-z
        allLetters = new char[(26 + 26) - let.Length];
        for (char ch = 'A'; ch < 'z'; ch++)
        {
            if ((ch != let[index] && (int)ch <= 90) ||
                (ch != let[index] && (int)ch >= 97))
            {
                allLetters[count] = ch;
                count++;
            }

            if (ch == let[index])
            {
                if (index == 5)
                    index = 4;

                index++;
            }
        }

        Console.WriteLine("\n\nprinting a new array 'allLetters' after sorting, and" + 
            "\nall the letters that doesn't included in 'let' array #");
        for (int i = 0; i < allLetters.Length; i++)
            Console.Write("{0,2}", allLetters[i]);

        Console.ReadKey();
    }
}