using System;

class Ch2Solve4Matara
{
    const int N = 5;

    /* m טענת כניסה: הפעולה מקבלת מטריצה */
    /* אחרת false אם איברי האלכסון הראשי יכולים להוות לוח קליעה תקין, או true טענת יציאה: הפעולה מחזירה */
    static bool CheckProportion(int[,] m)
    {
        int i = 0;

        while (i < N / 2)                       // כדי שהמסגרות תהיינה מסודרות ביחס עולה, אברי האלכסון
        {                                       // הראשי צריכים להיות ממויניים בסדר עולה עד למרכז האלכסון
            if (m[i, i] >= m[i + 1, i + 1])     // אם כל אברי המסגרת שווים, יוצא שבהכרח אברי האלכסון
                return false;                   // ממרכז ועד הסוף יהיו ממוינים בסדר יורד
            i++;
        }
        return true;
    }

    /* value וערך הנמצא במסגרת ,row מספר שורה ,col מספר עמודה ,m מקבלת מטריצה CheckRow טענת כניסה: הפעולה */
    /* כל האיברים שווים לאותו ערך, או שקר אחרת col-(N-col-1) טענת יציאה: הפעולה מחזירה אמת אם בשורה זו בעמודות */
    static bool CheckRow(int[,] m, int col, int row, int value)
    {
        int j = col;

        while (j < (N - j - 1))
        {
            if (m[row, j] != value)
                return false;

            j++;
        }

        return true;
    }

    /* value וערך הנמצא במסגרת ,row מספר שורה ,col מספר עמודה ,m מקבלת מטריצה CheckRow טענת כניסה: הפעולה */
    /* טענת יציאה: הפעולה מחזירה אמת אם בעמודה זו החל מהשורה כל האיברים שווים לאותו ערך, או שקר אחרת */
    static bool CheckCol(int[,] m, int col, int row, int value)
    {
        int i = row;

        while (i < N - i - 1)
        {
            if (m[i, col] != value)
                return false;

            i++;
        }

        return true;
    }

    /* num ומספר מסגרת m מקבלת מטריצה CheckFrame טענת כניסה: הפעולה */
    /* טענת יציאה: הפעולה מחזירה אמת אם כל איברי המסגרת שווים, או שקר אחרת */
    static bool CheckFrame(int[,] m, int num)
    {
        int value;
        bool ok;

        value = m[num, num];                        // אתחול באחד מאיברי המסגרת

        ok = CheckRow(m, num, num, value);          // בדיקת השורה העליונה של המסגרת
        if (!ok) return false;

        ok = CheckRow(m, num, N - num - 1, value);  // בדיקת השורה התחתונה של המסגרת
        if (!ok) return false;

        ok = CheckCol(m, num, num, value);          // בדיקת העמודה השמאלית של המסגרת
        if (!ok) return false;

        ok = CheckCol(m, num, N - num - 1, value);  // בדיקת העמודה הימנית של המסגרת
        if (!ok) return false;

        return ok;
    }

    

    static void Main()
    {
        int[,] m = new int[N, N]
        {
            { 30, 30, 30, 30, 30 },
            { 30, 60, 60, 60, 30 },
            { 30, 60, 100, 60, 30 },
            { 30, 60, 60, 60, 30 },
            { 30, 30, 30, 30, 30 }
        };

        //int[,] m = new int[N, N]
        //{
        //    { 30, 30, 30, 35, 30 },
        //    { 30, 20, 20, 20, 30 },
        //    { 30, 20, 100, 20, 30 },
        //    { 30, 20, 20, 20, 30 },
        //    { 30, 30, 30, 30, 30 }
        //};


        //int[,] m = new int[N, N];

        //for (int i = 0; i < N; i++)
        //{
        //    for (int j = 0; j < N; j++)
        //    {
        //        Console.Write("Insert number in row " + i + " colum " + j);
        //        m[i, j] = int.Parse(Console.ReadLine());
        //    }
        //}

        bool valid = CheckProportion(m);        // בדיקת קיום היחס הנדרש בין המסגרת

        int k = 0;
        while (k < N / 2 && valid)
        {
            valid = CheckFrame(m, k);           // בדיקת שכל איברי כל מסגרת שווים זה בזה
            k++;
        }

        if (valid)
            Console.WriteLine("קליעה למטרה");
        else
            Console.WriteLine("לא קליעה למטרה");


        Console.ReadKey();
    }
}