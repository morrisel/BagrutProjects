using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int numStudents = 0, i;
        double avg = 87.5, gradeStudent;
        for (i = 1; i <= 30; i++)
        {
            gradeStudent = double.Parse(Console.ReadLine());
            if (gradeStudent > avg)
                numStudents++;
        }
        Console.WriteLine("\n{0}", numStudents);
        Console.ReadKey();
    }
}