using System;

class Program
{
    static string Update(string st, int n)
    {
        int len;

        for (int i = 0; i < n; i++)
        {
            len = st.Length;

            if (n > 1 && n < len)
                st = st.Remove(n, 2);
            else
                st = st.Insert(1, st);
            
        }

        return st;
    }



    static void Main()
    {
        string st = "";

        st = "good bye";

        st = Update(st, 8);

        st = "abcaxxyzxyzxysz";
        
        // if-אין מחרוזת שהאורך שלה תהיה קטנה מערך הנתון ויחד עם זאת יתבצעו אך ורק פעולות של התנאי ה
        // ואז תוכפל האות הראשונה לפחות פעם אחת Insert אז תופעל פונקציה ,else-אם לפחות פעם אחת תתבצעה פעולת ה
        // וזה יסתור את הדרישה, לכן לא ניתן למצוא ערך מספרי כזה שהוא לא שיהיה שווה לאוך המחרוזת ויבצע את הדרוש
        st = Update(st, 5);



        Console.ReadKey();
    }
}