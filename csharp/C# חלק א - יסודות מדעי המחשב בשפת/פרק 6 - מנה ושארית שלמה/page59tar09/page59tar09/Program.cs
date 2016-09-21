using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page59tar09
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int ab, ba;
            int abDiv, baDiv, abMod, baMod;

            Console.WriteLine("Enter an any two digit possible numbers  a and b  and  you can get a two-digit possible numbers  ab and ba");
            Console.Write("Enter first an  a  number:  ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the secod number  b:  ");
            b = int.Parse(Console.ReadLine());

            ab = a * 10 + b;
            ba = b * 10 + a;

            Console.WriteLine("The two digit numbers   ab = {0}", ab);
            Console.WriteLine("The two digit numbers   ba = {0}", ba);

            abDiv = ab / a;
            baDiv = ba / b;

            Console.WriteLine("The division number that recived, is an integer from  ab = {0} is: abDiv = {1}", ab, abDiv);
            Console.WriteLine("The division number that recived, is an integer from  ab = {0} is: baDiv = {1}", ba, baDiv);

            abMod = ab % a;
            baMod = ba % b;
            Console.WriteLine("The remainder number that recived, is an integer from  ab = {0} is: abMod = {1}", ab, abMod);
            Console.WriteLine("The remainder number that recived, is an integer from  ab = {0} is: abMod = {1}", ab, baMod);

            Console.ReadKey();
        }
    }
}
