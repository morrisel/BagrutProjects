using System;

// המרצה הכי טוב
class CodeFile1
{
    /* טענת כניסה: הפעולה מקבלת את המשכורת הכוללת */
    /* טענת יציאה: הפעולה מחזירה את הממוצע של המשכורת הכוללת */
    static double AVG(int salTotal)
    {
        double avgSalary;

        avgSalary = (double)salTotal / 20;
        
        return avgSalary;
    }


    /* קלט: מספר הסטודנטים שנרשמו  */
    /* פלט: ממוצע של מרצה להרצאה */
    public static void Main(string[] args)
    {
        int stud, sum = 0;
        double salAvg = 0.0;

        for (int lect = 1; lect <= 20; lect++)
        {
            Console.Write("\nEnter a number of students on lecture {0}: ", lect);
            stud = int.Parse(Console.ReadLine());

            for (int j = 1; j <= stud; j++)
            {
                if (j > 10)
                    sum = sum + 180 + 5;
                else
                    sum = sum + 180;
            }
        }
        salAvg = AVG(sum);
        Console.Write("\n\nThe average salary of lector for lecture is: {0} NIS\n", salAvg);

        Console.ReadKey();
    }
}