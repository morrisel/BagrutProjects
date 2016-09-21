using System;

class Program
{
    // N - (מספר התלמידים (אוכלוסיה
    const int N = 200;
    static void Main()
    {
        int grade = 0;
        int[] student = new int[N];   // הצגה
        int[] studentGrades = new int[N];

        Console.WriteLine("Enter the grade of students: 0-100");
        // inserting grades
        for (int i = 0; i < N; i++)
        {
            grade = int.Parse(Console.ReadLine());

            // חיבור ציונים זהים
            student[grade] += grade;

            // שכיחות הציונים
            studentGrades[grade]++;
        }

        // ציון השכיח - זהו המספר שנספר הכי הרבה מכל הרשימה שנקלטה
        int fMax = 0;   // השכיחות
        for (int i = 0; i < N; i++)
            if (fMax < studentGrades[i])
                fMax = studentGrades[i];

        // חישוב טווח הציונים 0-9, 10-19,..., 90-100 הגדול ביותר
        //int count = 0;
        for (int i = 101 - 1; i >= 0; i--)
        {
            if (i % 10 == 0)
            {
                Console.WriteLine("(" + i + "-" + (i - 10) + ")");
                int j = 0;
                while (j != 10)
                {
                    Console.WriteLine("grade is: " + (i-j) + ", sum of grades: " + studentGrades[i]);
                    j++;
                }
            }
        }
        Console.WriteLine("F = " + fMax);

        Console.ReadKey();
    }
}