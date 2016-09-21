using System;

class Program
{
    // 
    static bool FindEqualsSymbols(string word, int start, int end)
    {
        int ca = 0, cb = 0;
        //string strTemp = "";

        word = word.Substring(start, end);

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == 'a')
                ca++;

            if (word[i] == 'b')
                cb++;
        }

        return ca == cb && ca != 0 ? true : false;
    }

    static void AllSubStrings(string myStr)
    {
        string subStr = "";
        //bool flag;
        int num = 2;
        int count = 0;

        while (num <= 6)
        {
            for (int i = 0; i < myStr.Length && i < myStr.Length + 1 - num; i++)
            {
                subStr = myStr.Substring(i, num);

                if (FindEqualsSymbols(subStr, 0, num))
                {
                    Console.WriteLine("{0} right substring is: {1}", ++count, subStr);
                }
            }

            num++;
        }



    }

    static void Main() 
    {
        string word = "adsfbbsafawwbbbasdfasbbbbbavcazz";
        bool flag;

        // א
        //flag = FindEqualsSymbols(word, 3, 7);

        // ב
        string myStr = "abcbbaadaaabbb";
        AllSubStrings(myStr);
        Console.WriteLine();

        Console.ReadKey();
    }
}