using System;

class CodeFile1
{
    /* טענת כניסה: הפעולה מקבלת מיקום של שתי נקודות על הצירים */
    /* טענת יציאה: הדפסת הודעת מתאימה אחת, מתוך הודעות הבאות */
    // שתי הנקודות נמצאות בדיוק באותו מקום
    // (שווה y שתי הנקודות נמצאות בדיוק באותה שורה (ציר
    // (שווה x שתי הנקודות נמצאות בדיוק באותה עמודה (ציר
    // לשתי הנקודות אין מיקום משותף
    static void Points(double x1, double y1, double x2, double y2)
    {
        if (x1 == x2 && y1 == y2)
            Console.WriteLine("\nTwo points ({0},{1}) and ({2},{3}) are exactly the same place on the system", x1, y1, x2, y2);
        else
        {
            if (x1 != x2 && y1 == y2)
                Console.WriteLine("\nTwo points ({0},{1}) and ({2},{3}) are on the same row", x1, y1, x2, y2);
            else
            {
                if (x1 == x2 && y1 != y2)
                    Console.WriteLine("\nTwo points ({0},{1}) and ({2},{3}) are on the same column", x1, y1, x2, y2);
                else
                    Console.WriteLine("\nTwo points ({0},{1}) and ({2},{3}) there is no common position", x1, y1, x2, y2);
            }
        }
    }


    /* (x2,y2)-ו (x1,y1) קלט: האלגוריתם מקבל כקלט שתי נקודות של הצירים */
    /* Points פלט: האלגוריתם מציג כפלט את "טענת היציאה" של פעולה */
    public static void Main(string[] args)
    {
        double a, b, c, d;

        Console.WriteLine("Enter two oerdered pair\n");

        Console.WriteLine("\nEnter the x1 and y1 of ordered pair: (x1,y1)  ");
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());

        Console.WriteLine("\nEnter the x2 and y2 of ordered pair: (x2,y2)  ");
        c = double.Parse(Console.ReadLine());
        d = double.Parse(Console.ReadLine());

        Points(a, b, c, d);

        Console.ReadKey();
    }
}