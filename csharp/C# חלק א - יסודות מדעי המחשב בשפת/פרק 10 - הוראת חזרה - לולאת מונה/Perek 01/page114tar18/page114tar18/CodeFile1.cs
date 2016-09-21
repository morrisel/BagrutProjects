using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exellent student\n");

        for (int i = 1; i <= 58; i++)
        {
            int mathGrade, physicGrade, compGrade;
            float avg;
            
            Console.Write("Enter the grade of Math science:\t");
            mathGrade = int.Parse(Console.ReadLine());
            Console.Write("Enter the grade of Physic science:\t");
            physicGrade = int.Parse(Console.ReadLine());
            Console.Write("Enter the grade of Computer science:\t");
            compGrade = int.Parse(Console.ReadLine());

            avg = (float)(mathGrade + physicGrade + compGrade) / 3;

            if ((avg > 92) && (mathGrade >= 90 || physicGrade >= 90 || compGrade >= 90))
            {
                Console.WriteLine("\nThere is an exellent student between 1-58 is: {0}", i);
                Console.WriteLine("The average of student {0} is: {1}\n", i, avg);
                Console.WriteLine("--------------------------------------------");
            }
            else
            {
                Console.WriteLine("\nThere isn't an exellent student");
                Console.WriteLine("The average of student {0} is: {1}\n", i, avg);
                Console.WriteLine("--------------------------------------------");
            }
        }


        Console.ReadKey();
    }
}