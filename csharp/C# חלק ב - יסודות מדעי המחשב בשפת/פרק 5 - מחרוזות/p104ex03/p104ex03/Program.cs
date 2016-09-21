using System;

class ChSolve3Palindrome
{
    public static bool Palindrome(string st)
    {
        int n = st.Length / 2;

        for (int i = 0; i < n; i++)
            if (st[i] != st[st.Length - 1 - i])
                return false;

        return true;
    }


    static void Main()
    {
        string str = Console.ReadLine();

        while (str != "")
        {
            Console.WriteLine(str + " is palindrome? - " + Palindrome(str));
            str = Console.ReadLine();
        }

        Console.ReadKey();
    }
}