using System;

class Example
{
    /* טענת כניסה: הפעולה מקבלת שלושה מספרים טבעיים */
    /* טענת יציאה: הפעולה מחזירה את הממוצע */
    static double Avg(int a, int b, int c)
    {
        return (double)(a + b + c) / 3;
    }


    /* קלט: שם תלמיד ושלושה ציונים */
    /* פלט: של התלמיד וההודעה "תלמיד טוב מאוד" אם ממוצע ציוניו גבוהה מ-90 */
    static void Main(string[] args)
    {
        int grd1, grd2, grd3;
        String name;
        double avg;

        Console.Write("Insert a student name: ");
        name = Console.ReadLine();
        Console.WriteLine("Insert 3 grades: ");
        grd1 = int.Parse(Console.ReadLine());
        grd2 = int.Parse(Console.ReadLine());
        grd3 = int.Parse(Console.ReadLine());

        avg = Avg(grd1, grd2, grd3);
        if (avg > 90)
            Console.WriteLine("{0} is a very good people", name);



        Console.ReadKey();
    }
}