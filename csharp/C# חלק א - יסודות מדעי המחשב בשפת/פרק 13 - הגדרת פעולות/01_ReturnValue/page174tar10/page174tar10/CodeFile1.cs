using System;

// יהלומים
class CodeFile1
{
    /* (טענת כניסה: הפעולה מקבלת אורך צלע של תליון (ס"מ */
    /* טענת יציאה: מחזירה את מספר היהלומים הדרושים כדי לשבץ בתליון */
    static int Brilliants(int len_cm)
    {
        int brl = 5, spacious = 2;
        int dis, sum, len_mm, count = 0, sq;

        dis = brl + spacious;
        len_mm = len_cm * 10;
        sum = dis;

        while (sum <= len_mm)
        {
            sum = sum + dis;
            count = count + 1;
        }
        sq = count * count;

        return sq;
    }


    /* קלט: 1. מחיר של תליון, 2. מחיר של יהלום */
    /* פלט: מחיר הכולל של התליון */
    public static void Main(string[] args)
    {
        int lenTal, numBrl;
        double costPndt, costBrl, totalCost;

        lenTal = Brilliants(3);

        Console.Write("\nEnter a cost of pendant: ");
        costPndt = double.Parse(Console.ReadLine());
        Console.Write("\nEnter a cost of brilliant: ");
        costBrl = double.Parse(Console.ReadLine());

        numBrl = lenTal;

        totalCost = (double)numBrl * costBrl + costPndt;

        Console.WriteLine("The cost of jewel is {0}", totalCost);

        Console.ReadKey();
    }
}