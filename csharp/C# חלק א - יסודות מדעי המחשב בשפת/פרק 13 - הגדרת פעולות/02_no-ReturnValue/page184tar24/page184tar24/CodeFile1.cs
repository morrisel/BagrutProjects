using System;

class CodeFile1
{
    /* טענת כניסה: הפעולה מקבלת מספר יחידות ואת הציון */
    /* טענת היציאה: הפעולה מחזירה את הציון המשוקלל */
    static int AvgGrade(int points, int grade)
    {
        int gradeAvg = grade;

        if (points == 5)
            gradeAvg = grade + 20;
        if (points == 4)
            gradeAvg = grade + 10;

        return gradeAvg;
    }

    /* טענת כניסה: הפעולה מקבלת 3 פרמטרים */
    // ציונים
    // מספר התחילתי של המקצוע
    // מספר הסופי של המקצוע
    /* טענת יציאה: הפעולה מציגה את הציון המשוקלל של תעודת הבגרות */
    static void BagrutAvg(double grades, int count)
    {
        double avg;

        avg = grades / count;
        Console.WriteLine("\nThe weighted average of Bagrut is: {0}", avg);
    }


    /* קלט: ציוני בחינות הבגרות ומספר היחידות */
    /* פלט: הממוצע המשוקלל של תעודת הבגרות */
    public static void Main(string[] args)
    {
        int gd, pt, numExam, weightAvg;
        double sumGrade = 0.0;

        Console.Write("Enter a number of examine: ");
        numExam = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numExam; i++)
        {
            Console.Write("\nEnter the number of points: ");
            pt = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the grade: ");
            gd = int.Parse(Console.ReadLine());

            weightAvg = AvgGrade(pt, gd);
            Console.WriteLine("The wighted average of {0} examine is: {1}", i, weightAvg);

            // סכום הכולל של הציונים
            sumGrade = sumGrade + weightAvg;

            if (i == numExam)
                BagrutAvg(sumGrade, i);
        }

        Console.ReadKey();
    }
}