using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int h = 0, m = 0, s = 0;

        for (h = 1; h <= 23; h++)
        {
            for (m = 1; m <= 59; m++)
            {
                for (s = 1; s <= 59; s++) { }
              //  Console.WriteLine(m*s);
                //Console.Write("\n", h * m * s);
            }
            //Console.WriteLine(s * s);
        }
        Console.WriteLine("1min = {0}sec", s);
        Console.WriteLine("1hour = {0}min", m);
        Console.WriteLine();
        Console.Write("{0} ", m * s);
        Console.Write("\n{0}", h * m * s);
        Console.ReadKey();
    }
}