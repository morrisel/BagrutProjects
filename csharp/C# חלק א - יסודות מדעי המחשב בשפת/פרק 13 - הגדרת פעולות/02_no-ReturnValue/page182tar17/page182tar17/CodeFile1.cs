using System;

class CodeFile1
{
    /* טענת כניסה: האלגוריתם מקבל שני מספרים */
    /* :טענת יציאה: האלגוריתם מדפיס */
    // א. שטח המלבן, היקף המלבן, אורך האלכסון
    // ב. ציור שטח המלבן
    // ג. שטח, היקף ואורך האלכסון עבור מלבן הגדול באורכו פי 2 מהקלט וקטו ברוחבו ב-3
    static void Rectangle(double len, double wid)
    {
        double diagonal, area, perimeter;

        area = len * wid;
        perimeter = 2 * len + 2 * wid;
        diagonal = Math.Sqrt(len * len + wid * wid);

        Console.Write("The area of rectangle is:          {0}\n", area);
        Console.Write("The perimeter of rectangle is:     {0}\n", perimeter);
        Console.Write("The diagonal line of rctangle is:  {0}\n\n", diagonal);

        for (int i = 1; i <= wid; i++)
        {
            for (int j = 1; j <= len; j++)
                Console.Write("*");
            Console.WriteLine();
        }

        diagonal = diagonal * 2;
        wid = Math.Abs(wid - 3);

        area = len * wid;
        perimeter = 2 * len + 2 * wid;
        diagonal = Math.Sqrt(len * len + wid * wid);

        Console.WriteLine("\n.....................................................\n");
        Console.Write("The diagonal line of rctangle was changed much more 2\n");
        Console.Write("The width of rectangle was changed less more 3\n\n");
        Console.Write("The area of rectangle is:          {0}\n", area);
        Console.Write("The perimeter of rectangle is:     {0}\n", perimeter);
        Console.Write("The diagonal line of rctangle is:  {0}\n\n", diagonal);
    }


    /* קלט: האלגוריתם מקבל כקלט אורך ורוחב של מלבן */
    /* פלט: אין */
    public static void Main(string[] args)
    {
        double lenght, width;

        Console.Write("Enter a lenght size of rectangle:  ");
        lenght = double.Parse(Console.ReadLine());

        Console.Write("\nEnter a width size of rectangle:  ");
        width = double.Parse(Console.ReadLine());
        Console.WriteLine("\n.....................................................\n");
        Rectangle(lenght, width);

        Console.ReadKey();
    }
}