using System;

class Solve2NumOfBuses
{
    /* טענת כניסה: הפעולה מקבלת את מספר התלמידים בשכבה */
    /* טענת יציאה: הפעולה את מס האוטובוסים הנחוצים לשכבה */
    static int NumOfBus(int num)
    {
        // מספר האוטובוסים הנחוץ
        int rentBus;

        rentBus = num / 50;
        if (num % 50 > 0)
        {
            rentBus = rentBus + 1;
        }
        return rentBus;
    }


    /* קלט: מספר תלמידים בכל שכבה */
    /* פלט: מספר האוטובוסים הנחוצים לשכבה */
    static void Main(string[] args)
    {
        int studA, studB;           // מספר התלמידים בכל מחזור
        int busA, busb;             // מספר האוטובוסים בכל מחזור
        int total;                  // מספר האוטובוסים הכולל

        Console.Write("Please enter the number of sundents in class 11: ");
        studA = int.Parse(Console.ReadLine());
        Console.Write("Please enter the number of sundents in class 11: ");
        studB = int.Parse(Console.ReadLine());
        busA = NumOfBus(studA);
        busb = NumOfBus(studB);
        total = busA + busb;
        Console.WriteLine("The number of busses is: {0}", total);

        Console.ReadKey();
    }

}