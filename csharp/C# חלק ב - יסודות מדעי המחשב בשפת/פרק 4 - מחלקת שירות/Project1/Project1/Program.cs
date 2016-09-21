using System;

class Program
{
    //Implement function check (text) which checks whether brackets within text are
    //correctly nested. You need to consider brackets of three kinds: (), [], {}.


    //Examples:

    //check("a(b)") -> true
    //check("[{}]") -> true
    //check("[(]") -> false
    //check("}{") -> false
    //check("z([{}-()]{a})") -> true
    //check("") -> true

    static bool Check(string text)
    {
        int c1 = 0, c2 = 0, c3 = 0;
        for (int i = 0; i < text.Length; i++)
        {
            switch (text[i].ToString())
            {
                case "(": c1++; break;
                case ")": c1--; if (c1 < 0) return false; break;
                case "[": c2++; break;
                case "]": c2--; if (c2 < 0) return false; break;
                case "{": c3++; break;
                case "}": c3--; if (c3 < 0) return false; break;
            }
        }

        return (c1 == 0 && c2 == 0 && c3 == 0) ?
            true :
            false ;

        if (c1 == 0 && c2 == 0 && c3 == 0)
            return true;
        else
            return false;
    }

    static void Main()
    {
        string text;
        text = Console.ReadLine();

        Console.WriteLine(Check(text));

        Console.ReadKey();
    }
        
}
/*
switch (text[i].ToString())
{
    case "(": c1++; break;
    case ")": c1--; if (c1 < 0) return false; break;
    case "[": c2++; break;
    case "]": c2--; if (c2 < 0) return false; break;
    case "{": c3++; break;
    case "}": c3--; if (c3 < 0) return false; break;
}
*/
// int location1=text.IndexOf(“[");
//int location2=text.IndexOf(“(");
//int location2=text.IndexOf(“{");
// p1 = “[“, p2 = “]”, p3 = “(“, p4 = “)”, p5 = “{“, p6 = “}”;

// while(
//}
