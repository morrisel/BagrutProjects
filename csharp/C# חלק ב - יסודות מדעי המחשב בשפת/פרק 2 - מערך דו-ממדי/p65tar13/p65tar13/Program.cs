using System;

class Program
{
    // קלט: הפעולה מקבלת איבר ומטריצה 
    // פלט: הפעולה מחזירה מספר כמה פעמים הופיע האיבר במטריצה
    static int CalcCount(int[,] matrix, int v)
    {
        int count = 0;

        // עורים על כל האיברים במטריצה
        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (matrix[i, j] == v)      // האם האיבר הנתון שווה לאיבר במטריצה
                    count++;    // מגדילים את המונה

        return count;
    }

    static int SetElementsInArray(int[,] matrix, int[] res)
    {
        int index = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                // מתקבל איבר ממטריצה
                int v = matrix[i, j];

                // ישנם במטריצה ,v-סופרים כמה איברים שהתקבלו ב
                int count = CalcCount(matrix, v);

                if (count == 1)
                {
                    res[index] = v;
                    index++;
                }
            }
        }

        return index;
    }

    static int[] ChangeArraySize(int[] arr, int size)
    {
        int[] res = new int[size];

        for (int i = 0; i < size; i++)
            res[i] = arr[i];

        return res;
    }

    static void Main()
    {
        int[,] matrix = new int[,]
                                {
                                    { 7, 5, 1 }, 
                                    { 2, 3, 7 }, 
                                    { 4, 2, 3 }
                                };

        // יצירת מעכך איברים שאינם חוזרים על עצמם
        int[] res = new int[9];

        int size;   // גודל מערך עם עבור האיברים העדכניים

        size = SetElementsInArray(matrix, res);

        res = ChangeArraySize(res, size);

        // הצגת נתונים
        Console.WriteLine(string.Join(", ", res));
        Console.ReadLine();
    }
}