using System;

class Program
{
    static void Main()
    {
        /////////////////////////           IndexOf         /////////////////////////
        //------------------------------------------    int IndexOf(string str)
 
        string st = "abcdefg";
        int p1 = st.IndexOf("cd");
        int p2 = st.IndexOf("abc");
        int p3 = st.IndexOf("x");

        //------------------------------------------    int IndexOf(string str, int from)

        p1 = st.IndexOf("cd", 3);
        p2 = st.IndexOf("cd", 2);

        //------------------------------------------    int LastIndexOf(string str)
        
        st = "abcdeabfg";
        p1 = st.LastIndexOf("ab");
        p2 = st.LastIndexOf("abc");
        p3 = st.LastIndexOf("xy");

        //------------------------------------------    int LastIndexOf(string str, int from)

        p1 = st.LastIndexOf("ab", 6);
        p2 = st.LastIndexOf("ab", 4);


        /////////////////////////           Substring         /////////////////////////
        //------------------------------------------    string Substring(int begin)
        st = "abcdefg";
        string str1 = st.Substring(3);
        string str2 = st.Substring(6);

        //------------------------------------------    string Substring(int start, int count)

        str1 = st.Substring(2, 4);


        /////////////////////////           Replace         /////////////////////////
        //------------------------------------------    string Replace(char c1, char c2)
        string s1 = "abaabcas";
        string s2 = s1.Replace('a', '*');

        //------------------------------------------    string Replace(string c1, string c2)

        s1 = "abaabcas";
        s2 = s1.Replace("ab", "*");

        //------------------------------------------    string Insert(int start, string s)

        s1 = "abaabcas";
        s2 = s1.Insert(2, "***");

        //------------------------------------------    string Remove(int start, int cout)

        s1 = "abaabcas";
        s2 = s1.Remove(1, 4);

    }
}