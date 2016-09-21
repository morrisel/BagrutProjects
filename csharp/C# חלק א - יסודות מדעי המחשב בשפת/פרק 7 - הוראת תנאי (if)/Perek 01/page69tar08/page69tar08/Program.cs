using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page69tar08
{
    class Program
    {
        static void Main(string[] args)
        {
            int height1, height2;
            //int liftOff, comeDown;

            Console.Write("Enter the staying of ping-pong ball, \n put two numbers for calculate the height: ");
            height1 = int.Parse(Console.ReadLine());
            height2 = int.Parse(Console.ReadLine());

            if (height2 > height1)
                Console.WriteLine("The ping-pong ball is lift-off");
            else
                Console.WriteLine("The ping-pong ball is come-down");

            Console.ReadKey();
        }
    }
}
