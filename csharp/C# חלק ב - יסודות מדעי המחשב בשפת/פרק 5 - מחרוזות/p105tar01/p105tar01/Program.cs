using System;

class Program
{
    static void Main()
    {
        string st = "ab1cd2";
        int n;
        char ch1 = 'a', ch2 = 'f';
        int solve;

        solve = ch1 - ch2;
        n = "a".CompareTo("d");


        n = st.Length;

        string s1 = "abhfakl";
        string s2 = "abcaz";
        n = s1.CompareTo(s2);

        st = "a1s2d3f4g";
        s1 = st[0] + st[st.Length - 1].ToString();

        Console.ReadKey();
    }
}