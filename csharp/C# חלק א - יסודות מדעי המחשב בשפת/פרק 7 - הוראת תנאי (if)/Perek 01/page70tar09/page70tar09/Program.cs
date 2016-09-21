using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page70tar09
{
    class Program
    {
        static void Main(string[] args)
        {
            int stsClass1, stsClass2, stsClass3;
            int allStudents;
            int bus;
            Console.Write("Enter an amount of students from Class1: ");
            stsClass1 = int.Parse(Console.ReadLine());
            Console.Write("Enter an amount of students from Class2: ");
            stsClass2 = int.Parse(Console.ReadLine());
            Console.Write("Enter an amount of students from Class3: ");
            stsClass3 = int.Parse(Console.ReadLine());

            allStudents = stsClass1 + stsClass2 + stsClass3;

            if (allStudents % 40 == 0)
            {
                bus = allStudents / 40;
                bus = bus++;
            }
            else
            {
                bus = allStudents / 40;
                bus = bus+1;
            }
            Console.WriteLine("We need {0} Bus", bus);

            Console.ReadKey();
        }
    }
}
