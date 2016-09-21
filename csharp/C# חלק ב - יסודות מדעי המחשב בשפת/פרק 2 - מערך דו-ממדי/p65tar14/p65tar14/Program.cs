using System;

class Program
{
    const int N = 5;    // מספר בני הנוער
    const int M = 30;    // מספר התקליטורים

    /* טענת כניסה: הפעולה מקבלת מערך דו ממדי ומעדכנת אותו */
    static void Answers(int[,] m)
    {
        Console.WriteLine("Enter 0 or 1 - for {0} children that have the records\n", N);
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write("records {0} for child {1}: ", j + 1, i + 1);
                m[i, j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("-------------------------");
        }
    }


    /* טענת כניסה: הפעולה מקבלת מעכך דו ממדי */
    /* טענת יציאה: הפעולה מחזירה סכומי השורות כמערך חד ממדי */
    static int[] SumsOfRows(int[,] m)
    {
        int[] rowSum = new int[N];

        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                rowSum[i] += m[i, j];
            }
        }

        return rowSum;
    }


    /* טענת כניסה: הפעולה מקבלת מעכך דו ממדי */
    /* טענת יציא: הפעולה מחזירה סכומי העמודות כמערך חד ממדי */
    static int[] SumsOfColumn(int[,] m)
    {
        int[] columnSum = new int[M];

        for (int i = 0; i < m.GetLength(1); i++)
        {
            for (int j = 0; j < m.GetLength(0); j++)
            {
                columnSum[i] += m[j, i];
            }
        }

        return columnSum;
    }


    /* טענת הכניסה: הפעולה מקבלת מערך חד ממדי של סכומי העמודות ומדפיסה את כל הבני נוער שיש להם 30 תקליטורים */
    static void PrintMaxSums(int[] rows)
    {
        for (int i = 0; i < rows.Length; i++)
            if (rows[i] == M)
                Console.WriteLine("child {0} have {1} records", i + 1, M);

        Console.WriteLine("-------------------------\n");
    }


    /* טענת הכניסה: הפעולה מקבלת מערך דו ממדי ומדפיסה את הממוצע לכל נער */
    static void PrintAverage(int[] row)
    {
        for (int i = 0; i < row.Length; i++)
            Console.WriteLine("the average is: {0} for child {1}", (double)M / row[i], (i + 1));

        Console.WriteLine("-------------------------\n");
    }


    static void Main()
    {
        int[,] records = new int[N, M];
        int[] rowSum, columnSum;

        // קליטת התקליטורים
        Answers(records);

        // columnSum-ו rowSum חישוב סכומי השורות והעמודת והשמתם לתוך המעכים
        rowSum = SumsOfRows(records);
        columnSum = SumsOfColumn(records);

        //PrintMaxSums(columnSum);
        //PrintAverage(columnSum);

        PrintMaxSums(rowSum);
        PrintAverage(rowSum);

        Console.ReadKey();
    }
}