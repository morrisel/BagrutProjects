using System;

// ד
/* קלט: מספר התלמידים, קולטת ציונים, מעדכנת על פי כלל הבונוס */
/* פלט: מעדכנת ע"י כלל הבונוס */
class Program
{
    const int NUMBEROFGRADES = 5;

    // א
    public static void TenPercentageIncrease(int[] grade)
    {
        int bonus = 10;
        int upDateGrade = 0;

        for (int i = 0; i < grade.Length; i++)
        {
            upDateGrade = grade[i] * bonus / 100;
            upDateGrade += grade[i];

            if (upDateGrade <= 100)
            {
                grade[i] = upDateGrade;
            }

            upDateGrade = 0;
        }
    }

    // ב
    /* קלט: מקבלת כקלט מספר התלמידים בכיתה */
    /* פלט: מחזירה את מערך הציונים */
    public static int[] GradesOfStudents(int numOfStudents)
    {
        int[] student = new int[numOfStudents];

        int[] grades = { 90, 83, 98, 78 };

        for (int i = 0; i < student.Length; i++)
        {
            for (int j = 0; j < grades.Length; j++)
            {
                Console.Write("Enter the grade of student " + (i + 1) + ": ");
                grades[j] = int.Parse(Console.ReadLine());
            }

            // חישוב הממוצע עם 10% בונוס
            TenPercentageIncrease(grades);

            Console.WriteLine();
            Console.Write("The grades of student " + (i + 1) + ": ");

            // פלט: מעדכנת ע"י כלל הבונוס
            PrintGrades(grades);
        }

        return grades;
    }

    // ג
    /* פלט: מדפיסה את ציוני תלמידי הכיתה */
    public static void PrintGrades(int[] grades)
    {
        Console.WriteLine("After 10% bonums");
        for (int i = 0; i < grades.Length; i++)
        {
            Console.Write(grades[i] + " ");
        }
        Console.WriteLine("\n");
    }
    
    
    
    static void Main()
    {
        int numStud = 2;
        int[] grd;

        // קלט: מספר התלמידים בכיתה
        Console.Write("Enter number of students: ");
        numStud = int.Parse(Console.ReadLine());
        Console.WriteLine();

        // קלט: קולטת ציונים
        grd = GradesOfStudents(numStud);

        Console.ReadKey();
    }
}