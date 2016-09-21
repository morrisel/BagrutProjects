using System;

class Program
{
    static int FindBiggestPalindrome(string symbol, int start, int end)
    {
        int location = 0;
        int len = 0, maxLen = 0;
        char left, right;

        for (int i = 0; i < symbol.Length; i++)
        {
            len = 0;
            location = symbol.IndexOf('*');
            for (int j = 0; j < location; j++)
            {
                left = symbol[location - j - 1];
                right = symbol[location + j + 1];

                if (left == right) len++;
                else break;
            }

            if (len > maxLen)
                maxLen = len;

            symbol = symbol.Remove(0, location + 1);
        }

        return maxLen;
    }



    static void Main()
    {
        string palin1 = "asdfa*asdf8*";
        string palin2 = "cab*bacaa*aacab*fa";

        FindBiggestPalindrome(palin2, 0, palin2.Length);

        Console.WriteLine("The biggest palindrome of: {0} is: {1}", palin2, FindBiggestPalindrome(palin2, 0, palin2.Length));

        Console.ReadKey();
    }
}