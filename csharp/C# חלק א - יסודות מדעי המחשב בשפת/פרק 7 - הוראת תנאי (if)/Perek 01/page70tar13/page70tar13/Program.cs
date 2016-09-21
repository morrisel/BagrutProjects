using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page70tar13
{
    class Program
    {
        static void Main(string[] args)
        {
            int answers, points;
            Console.Write("Enter amount of an ansvers: ");
            answers = int.Parse(Console.ReadLine());

            if (answers >= 8)
            {
                int temp1;

                temp1 = (answers % 8);                          // temp1 - כל תשובות שיעברו את הסף של מספר 8 הם יהיו ב
                answers = answers - temp1;                      // הם יהיו ה-8 הראשונים answers-כאן מובטח לנו שכל ה
                temp1 = temp1 * 5;
                answers = answers * 8;

                points = answers + temp1;
                Console.WriteLine("You have {0} points", points);
            }
            else
            {
                points = answers * 8;
                Console.WriteLine("You have {0} points", points);
            }

            Console.ReadKey();
        }
    }
}
