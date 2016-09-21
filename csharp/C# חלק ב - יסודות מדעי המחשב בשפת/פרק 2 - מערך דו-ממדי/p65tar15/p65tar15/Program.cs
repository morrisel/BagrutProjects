using System;

class Program
{
    const int S = 6;    // מחלקות
    const int T = 5;    // קופיות

    /* טענת כניסה: הפעולה מקבלת מערך דו ממדי עם סכומי הרכישות */
    /* טענת יציאה: הפעולה מחזירה מערך חד ממדי עם סה"כ של סכומים של המחלקות */
    static int[] SumsOfSections(int[,] purchasing)
    {
        int[] section = new int[S];      // מערך של פדיונות

        for (int i = 0; i < purchasing.GetLength(0); i++)
            for (int j = 0; j < purchasing.GetLength(1); j++)
                section[i] += purchasing[i, j];

        return section;
    }

    /* טענת כניסה: הפעולה מקבלת מערך דו ממדי ומעדכנת את הרכישות */
    /* המודות מייצגות את הקופיות והשורות את המחלקות */
    static void SetKolBo(int[,] purchasing)
    {
        int money, section, teller;


        Console.Write("Choose the section number between (1 - 6) for Kol-Bo: ");
        section = int.Parse(Console.ReadLine());

        Console.Write("Choose the teller number between (1 - 5) for Kol-Bo: ");
        teller = int.Parse(Console.ReadLine());

        Console.Write("Enter the purchase amount: ");
        money = int.Parse(Console.ReadLine());

        purchasing[section - 1, teller - 1] = money;

        while (money != -1)
        {
            while (money != -1)
            {
                Console.Write("Choose the section number (1 - 6) for Kol-Bo: ");
                section = int.Parse(Console.ReadLine());
                
                Console.Write("Choose the teller number (1 - 5) for Kol-Bo: ");
                teller = int.Parse(Console.ReadLine());

                Console.Write("Enter the purchase amount: ");
                money = int.Parse(Console.ReadLine());

                if (section == -1 || teller == -1 || money == -1)
                {
                    money = -1;
                    break;
                }

                purchasing[section - 1, teller - 1] += money;
            }
        }
    }

    /* טענת כניסה: הפעולה מקבלת מערך כפרמטר */
    /* טענת יציאה: הפעולה מחזירה את האיבר המינימלי במערך */
    static int FindMinInArray(int[] arr)
    {
        int min = 0;

        for (int i = 1; i < arr.Length; i++)
            min = (arr[i - 1] < arr[i] && arr[i - 1] != 0) ? arr[i - 1] : arr[i];

        return min;
    }

    /* טענת כניסה: הפעולה מקבלת מערך דו ממדי כפרמטר עם סכומי הרכישות */
    /* טענת יציאה: הפעולה מחזירה את הרכישה הגבוהה ביותר */
    static int FindMaxInMatrix(int[,] purchasing)
    {
        int max = 0;

        for (int i = 0; i < purchasing.GetLength(0); i++)
            for (int j = 0; j < purchasing.GetLength(1); j++)
                if (purchasing[i, j] > max)
                    max = purchasing[i, j];

        return max;
    }

    /* טענת כניסה: הפעולה מקבלת פרמטר אחד כמערך דו ממדי של סה"כ הרחישות וכפרמטר השני את הרכישה הגבוהה ביותר */
    /* הפעולה מדפיסה: אצל איזו קופאים מאיזו מחלקה הייתה הרכישה הגבוהה ביותר */
    static void PrintSectionAndSellerOfMaxPurchase(int[,] purchase, int maxPurchase)
    {
        for (int i = 0; i < purchase.GetLength(0); i++)
            for (int j = 0; j < purchase.GetLength(1); j++)
                if (maxPurchase == purchase[i, j])
                    Console.WriteLine("section: {0,4}, \tteller: {1,4}, \tthe sum: {2,4}", i, j, maxPurchase);
    }

    static void PrintMinSumOfSection(int[] sections, int minSum)
    {
        for (int i = 0; i < sections.Length; i++)
            if (sections[i] == minSum)
                Console.WriteLine("The minimu sale in the section is: {0}", i);
    }

    static void PrintAllSale(int[,] purchase)
    {
        int sum = 0;

        for (int i = 0; i < purchase.GetLength(0); i++)
            for (int j = 0; j < purchase.GetLength(1); j++)
                sum += purchase[i, j];

        Console.WriteLine("The all sale of Kol-Bo is: {0}", sum);
    }

    static void Main()
    {
        int[,] purchasing = new int[S, T];   // מערך דו ממדי של מחלקות וקופיות
        int[] sections = new int[S];  // מערך חד ממדי לעדכון מחלקה של סה"כ הרכישות
        int minSale;    // הפדיון הנמוך ביותר
        int maxPurchase;    // הרכישה הגבוהה ביותר


        SetKolBo(purchasing);   // עדכון הרכישות

        sections = SumsOfSections(purchasing);   // מערך של מחלקות עם סה"כ סכומים

        minSale = FindMinInArray(sections);      // הפדיון הנמחוך ביותר

        maxPurchase = FindMaxInMatrix(purchasing);  // הרכישה הגבוהה ביותר

        Console.WriteLine("----Printing answer----");
        PrintSectionAndSellerOfMaxPurchase(purchasing, maxPurchase);
        PrintMinSumOfSection(sections, minSale);
        PrintAllSale(purchasing);

        Console.ReadKey();
    }
}