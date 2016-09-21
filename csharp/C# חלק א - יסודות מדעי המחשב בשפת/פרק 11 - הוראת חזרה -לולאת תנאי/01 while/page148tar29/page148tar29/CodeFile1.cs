using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int c;
        char ch;
        Console.WriteLine("Insert a letter between a-z");
        ch = char.Parse(Console.ReadLine());
        c = 'a';
        // ועד לאות שתוכנס a-במקומות האי-זוגיים מ ACII-מטרת הקטע היא להציג את הקוד ה
        while (c <= ch)
        {
            Console.WriteLine(c);
            c += 2;
        }

        Console.ReadKey();
    }
}