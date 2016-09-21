using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page36Ex01
{
    class Program
    {
        /* קלט: שני מספרים שלם וממשי */
        /* פלט: סכום המספרים ומכפלת המספרים */
        static void Main(string[] args)
        {
            int num1;
            double num2;

            Console.Write("Enter an integer number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter a double number: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 * num2);
        }
    }
}
