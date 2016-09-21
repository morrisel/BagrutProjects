using System;

// מסיבת בר מצווה
class CodeFile1
{
    /* טענת כניסה: הפעולה מקבלת שני ערכים תפוסת מקום וכמות האנשים המוזמנים */
    /* טענת יציאה: הפעולה תחזיר את מספר האוטובוסים, השולחנות ואת הסירות הדרושים */
    static int BusTableBoat(int n, int pNum)
    {
        int count = 0;

        for (int i = 0; i <= pNum; i++)
        {
            if (i % n == 0)
                count++;
        }
        return count;
    }


    /* קלט: 1. מספר המוזמנים, 2. תפוסת אוטובוס, 3. תפוסת שולחן, 4. תפוסת סירה */
    /* פלט: מציג את: 1. מספר האוטובוס הדרוש, 2. מספר השולחנות הדרושים, 3. מספר הסירות הדרושות */
    public static void Main(string[] args)
    {
        int person, bus, table, boat, num;

        Console.Write("Enter a number of invited person: ");
        person = int.Parse(Console.ReadLine());

        // מספר אנשים שימלאו את המקומות באוטובוס
        Console.Write("Enter a number for take up space of bus: ");
        num = int.Parse(Console.ReadLine());
        // מספר האוטובוסים הנדרש
        bus = BusTableBoat(num, person);

        // מספר אנשים שימלאו את המקומות בשולחן
        Console.Write("Enter a number for take up space of table: ");
        num = int.Parse(Console.ReadLine());
        // מספר השולחנות הנדרש
        table = BusTableBoat(num, person);

        // מספר אנשים שימלאו את המקומות בסירה
        Console.Write("Enter a number for take up space of boat: ");
        num = int.Parse(Console.ReadLine());
        // מספר הסירות הנדרש
        boat = BusTableBoat(num, person);
        Console.WriteLine("...........................................");
        Console.WriteLine("The number of buses what require is: {0} ", bus);
        Console.WriteLine("The number of tables what require is: {0} ", table);
        Console.WriteLine("The number of boats what require is: {0} ", boat);

        Console.ReadKey();
    }
}