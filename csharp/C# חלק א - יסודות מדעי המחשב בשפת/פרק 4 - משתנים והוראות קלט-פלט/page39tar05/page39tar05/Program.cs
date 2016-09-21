using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page39tar05
{
    class Program
    {
        static void Main(string[] args)
        {
            string boyName;
            int boyAge;
            int brotherAge;
            int difference;


            Console.Write("Write the name of a boy: ");
            boyName = Console.ReadLine();

            Console.Write("Write the age of {0}: ", boyName);
            boyAge = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} has a brother, his age is smaller than {1}", boyName, boyName);
            Console.WriteLine("Write the age's brother of {0}", boyName);
            brotherAge = int.Parse(Console.ReadLine());

            difference = boyAge - brotherAge;
            Console.WriteLine("The age's difference of the children is: {0}", difference);


        }
    }
}
