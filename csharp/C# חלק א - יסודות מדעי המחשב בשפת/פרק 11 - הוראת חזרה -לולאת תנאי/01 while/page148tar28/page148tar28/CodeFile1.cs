using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int n = 10;
        int i = 0, j = 0;

        // 'תשובה ל-ב
        // :כדי שהלולאה לא תתבצע כלל, הם j-ו i השינויים שעלינו לעשות עבור
        // i=1, j=9 ז"א ,n-צריך להיות גדול או שווה ל i+j :למשל

        // 'תשובה ל-ג
        // i=5, j=4 ;למשל

        while (i + j < n)
        {
            i = i + 1;
            j = j + 2;
        }
    }
}