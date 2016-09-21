using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page57tar04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int num1DivNum2, num1ModNum2;

            Console.WriteLine("Enter two integer numbers ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("num1 = {0}", num1);
            Console.WriteLine("num2 = {0}", num2);

            num1DivNum2 = num1 / num2;
            num1ModNum2 = num1 % num2;
            Console.WriteLine("div = {0}", num1DivNum2);
            Console.WriteLine("mod = {0}", num1ModNum2);
            
            Console.ReadKey();

        }
    }
}
