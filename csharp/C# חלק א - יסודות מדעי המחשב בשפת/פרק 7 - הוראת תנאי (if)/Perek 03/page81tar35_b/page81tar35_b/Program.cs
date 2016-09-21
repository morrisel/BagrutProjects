using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page81tar35_b
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Enter three numbers");

            Console.Write("X = ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Y = ");
            y = int.Parse(Console.ReadLine());

            Console.Write("Z = ");
            z = int.Parse(Console.ReadLine());

            if (y > x && y < z)
            {
                float avg;
                float diff;

                avg = (float)(z - x) / 2;
                diff = (float)y - avg;
                Console.WriteLine("The difference is: {0}", diff);
            }
            else
            {
                if (x != y && x != z && y != z)
                    Console.WriteLine("Different");
                else
                {
                    if (x == y && x > z)
                        Console.WriteLine("Z smallest of them");
                    else
                    {
                        if (x == z && x > y)
                            Console.WriteLine("Y smallest of them");
                        else
                            Console.WriteLine("X smallest of them");
                    }
                }
            }


            Console.ReadKey();
        }
    }
}
