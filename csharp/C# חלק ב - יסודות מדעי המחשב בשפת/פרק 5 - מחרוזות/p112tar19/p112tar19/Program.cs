using System;

class Program
{
    static void AddStar(string st)
    {
        for (int i = 3; i < st.Length; i += 4)
        {
            st = st.Insert(i, "*");
        }
    }

    static void Main()
    {
        string name = "adigetcat";

        AddStar(name);

        Console.ReadKey();
    }
}