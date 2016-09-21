using System;

class Program
{
    static void Main()
    {
        string s1, s2, b, st;
        int n;

        //// 1.
        //s1 = "lmnop";
        //s2 = s1.Remove(1, 3);

        //// 2.
        //s1 = "abcdefgh";
        //s2 = "xyxy";
        //b = s1.Insert(5, s2);

        //// 3.
        //s1 = "abxyz#xycgxy8*r";
        //s2 = "xy";
        //s1 = s1.Replace(s2, "$$");

        //// 4.
        //s1 = "abxyz#xycgxy8*r";
        //s2 = "xy";
        //n = s1.LastIndexOf(s2);

        //// 5.
        //s1 = "abxyz#xycgxy8*r";
        //s2 = "xy";
        //n = s1.IndexOf(s2, 4);

        // 6.
        st = "12a34b56c";
        s1 = st.Substring(3, 5);


        Console.ReadKey();
    }
}