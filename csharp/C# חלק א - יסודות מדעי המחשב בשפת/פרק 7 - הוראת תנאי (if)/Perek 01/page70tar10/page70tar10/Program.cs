using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page70tar10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, solve;
            char plus = '+';
            char minus = '-';

            Console.Write("Enter a first integer number ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter a second integer number ");
            num2 = int.Parse(Console.ReadLine());


            Console.Write("\nEnter an operator \"+\" or \"-\": \n");

            plus = char.Parse(Console.ReadLine());
            
            if (plus == '+')
            {
                Console.Write("\n{0}   {1}   {2}\n", num1, num2, plus);
                Console.Write("{0} {1} {2} = {3}", num1, plus, num2, num1 + num2);
            }
            else
            {

                //minus = char.Parse(Console.ReadLine());
                Console.Write("\n{0}   {1}   {2}\n", num1, num2, minus);
                Console.Write("{0} {1} {2} = {3}", num1, minus, num2, num1 - num2);
            }

            Console.ReadKey();
        }
    }
}
