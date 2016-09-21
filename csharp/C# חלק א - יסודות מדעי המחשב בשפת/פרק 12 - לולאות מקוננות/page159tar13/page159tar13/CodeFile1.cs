using System;

// Students and grades
class CodeFile1
{
    static void Main(string[] args)
    {
        int id, grade = 0, excellentGrade = 0, gradeSum = 0, numStud = 0, countGrade = 0;
        double avg = 0.0;

        Console.WriteLine("\nFor stop input students press '0'");
        Console.WriteLine("For stop input grades press '-999'\n");

        Console.Write("Enter the ID of student: ");
        id = int.Parse(Console.ReadLine());

        for (int i = 1; i <= id; i++)
        {
            numStud++;
            countGrade = 0;
            gradeSum = 0;
            grade = 0;

            for (int j = 0; j != -999; j++)
            {
                countGrade++;
                gradeSum = gradeSum + grade;

                Console.Write("Enter the grade of student{0}: ", i);
                grade = int.Parse(Console.ReadLine());

                if (j == 1 && grade >= 90)
                    excellentGrade++;

                if (grade == -999)
                {
                    j = grade - 1;
                    countGrade = countGrade - 1;
                }
            }
            avg = (double)gradeSum / countGrade;
            Console.WriteLine("The ID of student{0} is: {1}", i, id);
            Console.WriteLine("The average of student{0} is: {1}", i, avg);
            Console.WriteLine("...............................................\n");

            Console.Write("Enter the ID of student: ");
            id = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n***********************************************\n");
        Console.WriteLine("The number of student is: {0} ", numStud);
        Console.WriteLine(" {0} student was getted above 90 for examine", excellentGrade);

        Console.ReadKey();
    }
}