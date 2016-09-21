using System;

class Ch1Solve7Maam
{
    const int N = 3;
    const double CMAAM = 15.5, LMAAM = 17;

    /* טענת כניסה: הפעולה לא מקבלת פרמטרים */
    /* טענת יציאה: הפעולה מחזירה מערך מחירים לפני ההוזלה */
    /// <summary>
    /// ומחזירה אותו p קולטת איברים למערך ReadPrices הפעולה
    /// </summary>
    /// <returns></returns>
    static double[] ReadPrices()
    {
        double[] p = new double[N];

        for (int i = 0; i < N; i++)
            p[i] = double.Parse(Console.ReadLine());

        return p;
    }


    /* טענת כניסה: הפעולה מקבלת מערך מחירים */
    /* טענת יציאה: הפעולה מחזירה את המערך מעודכן לאחר הוזלת המע"מ */
    /// <summary>
    /// מעדכנת את המחירים לפי המע"מ החדש Update הפעולה
    /// </summary>
    /// <param name="p"></param>
    static void Update(double[] p)
    {
        for (int i = 0; i < N; i++)
            p[i] = p[i] / LMAAM * CMAAM;
    }


    static void Main()
    {
        double[] price;

        Console.WriteLine("Type prices");
        price = ReadPrices();

        Update(price);

        for (int i = 0; i < N; i++)
            Console.WriteLine(price[i]);


        Console.ReadKey();
    }
}