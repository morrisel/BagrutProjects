using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        float zela1, zela2, zela3;
        Console.WriteLine("\nThe program is answered which triangle you can get");
        Console.WriteLine("Side of triangle will can be correct");

        Console.Write("\nEnter a first lendth side of triangle:\t");
        zela1 = float.Parse(Console.ReadLine());

        Console.Write("Enter a second lendth side of triangle:\t");
        zela2 = float.Parse(Console.ReadLine());

        Console.Write("Enter a third lendth side of triangle:\t");
        zela3 = float.Parse(Console.ReadLine());


        if (zela1 == zela2 && zela2 == zela3)
        {
            Console.WriteLine("\nThe triangle is:\t\"Equilateral Triangle\"");
        }
        else
        {
            if ((zela1 == zela2 && zela2 != zela3) || (zela1 == zela3 && zela1 != zela2) || (zela2 == zela3 && zela1 != zela2))
            {
                Console.WriteLine("\nThe triangle is:\t\"Isosceles Triangle\"");
            }
            else
            {
                Console.WriteLine("\nThe triangle is:\t\"Regular Triangle\"");
            }
        }




        Console.ReadKey();
    }
}