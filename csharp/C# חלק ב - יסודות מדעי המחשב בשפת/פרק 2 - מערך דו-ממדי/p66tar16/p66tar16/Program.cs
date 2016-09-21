using System;

class Program
{
    const int R = 7;    // מציין על מספר השורות של טבלת הלוטו
    const int C = 7;    // מציין על מספר העמודות של טבלת הלוטו

    const int CHANCE_COLUMN = 6;
    const int CHANCE_ROWS = 5;

    /* טענת כניסה: הפעולה בונה טבלת הלוטו של המספרים בין 1 ל-49 */
    static void CreateGameTable(int[,] table)
    {
        int elements = 1;

        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                table[i, j] = elements;
                elements++;
            }
        }
    }

    /* טענת כניסה: הפעולה מקבלת מערך דו ממדי כפרמטר ומעדכנת אותו מספרים שהוגרלו */
    /* טענת יציאה: הפעולה מחזירה חמש ניחושים האחרונים שהוגרלו כמערך דו ממדי */
    static int[,] SetFiveLastNumbers(int[,] lotoNumbers)
    {
        for (int i = 0; i < lotoNumbers.GetLength(0); i++)
        {
            Console.WriteLine("Enter numbers of {0} of loto chances", i + 1);
            for (int j = 0; j < lotoNumbers.GetLength(1); j++)
            {
                lotoNumbers[i, j] = int.Parse(Console.ReadLine());
            }
        }

        return lotoNumbers;
    }

    /* טענת כניסה: הפעולה מקבלת מערך דו ממדי של הניחושים האחרונים ומספר */
    /* טענת היציאה: הפעולה בודקת אם המספר נמצאה באחת האגרלות האחרונות, אם המספר נמצאה תחזיר אמת, אחרת שקר */
    static bool IsFind(int[,] lastChances, ref int num)
    {
        for (int i = 0; i < lastChances.GetLength(0); i++)
        {
            for (int j = 0; j < lastChances.GetLength(1); j++)
            {
                if (lastChances[i, j] == num)
                {
                    //num = lastChances[i, j];
                    return true;
                }
            }
        }

        return false;
    }

    /* טענת כניסה: הפעולה מקבלת שני מערכים דו ממדיים - מעכך ראשון כטבלת המספרים האפשריים והשני של הניחושים האחרונים */
    /* טענת יציאה: הפעולה יוצרת מערך חדש של 6 מספרים הראשונים שלא הוגרלו עד כה */
    static int[] CreatingNewNumbers(int[,] table, int[,] lastChances)
    {
        int[] rowNew = new int[CHANCE_COLUMN];
        int count = 0;

        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                if (!IsFind(lastChances, ref table[i, j]))
                {
                    rowNew[count] = table[i, j];
                    count++;
                }
                if (count == 6)
                    return rowNew;
            }
        }

        return rowNew;
    }

    static void Main()
    {
        int[,] table = new int[R, C];   // מייצג את האיברים של משחק-מזל
        CreateGameTable(table);

        // תוצאות אחרונות של הלוטו שיצאו
        int[,] lastChances = new int[CHANCE_ROWS, CHANCE_COLUMN];
        lastChances = SetFiveLastNumbers(lastChances);

        // מערך חד ממדי של מספרים שלא הוגרלו מהתוצאות האחרונות שיצאו בלוטו
        int[] arr = new int[CHANCE_COLUMN];
        arr = CreatingNewNumbers(table, lastChances);

        Console.WriteLine();
        Console.WriteLine("The chances of numbers is:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(" {0,4}", arr[i]);
        }

        Console.ReadKey();
    }
}