using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int g = 0, max, min;

        Console.WriteLine("The program presents an excellents of fails student");
        Console.WriteLine("For stop the program please press a negative number\n");

        Console.Write("Enter a grade of student: ");
        g = int.Parse(Console.ReadLine());
        max = g;
        min = g;

        while (g > 0)
        {
            Console.Write("Enter a grade of student: ");
            g = int.Parse(Console.ReadLine());

            if (g >= max && g <= 100)           // Find the max of grade
                max = g;

            if (g <= min && g > 0)           // Find the min of grade
                min = g;
        }

        if (max > max - 1)
        {
            if (max >= 95)
                Console.WriteLine("\n The hightest grade is: {0} and the student was passed with an Excellent!", max);
            else
                Console.WriteLine("\n The hightest grade is: {0} ", max);
        }
        if (min < min + 1)
        {
            if (min < 55)
                Console.WriteLine("\n The lowest grade is: {0} and the student was Failed!", min);
            else
                Console.WriteLine("\n The lowest grade is: {0} ", min);
        }


        Console.ReadKey();
    }
}