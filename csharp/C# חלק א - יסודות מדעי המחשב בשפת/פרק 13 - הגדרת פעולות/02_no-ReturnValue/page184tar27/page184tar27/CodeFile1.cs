using System;

class CodeFile1
{
    /* טענת כניסה: הפעולה מקבלת שני מספרים - מספר ראשון ומספר אחרון של סיסמה ישנה */
    /* (טענת יציאה: הפעולה מחזירה מספר חדש (שיתווסף עבור סיסמה חדשה */
    static int GeneratePassword(int firstNum, int lastNum)
    {
        int num;

        num = (firstNum + lastNum) % 10;

        return num;
    }

    /* (טענת כניסה: הפעולה מקבלת מספר שלם (סיסמה ישנה של משתמש */
    /* (טענת יציאה: הפעולה מחזירה מספר שלם (סיסמה מדשה של משתמש */
    static int CreateNewPassword(int pass)
    {
        int newPass, temp, last, first = 0;

        temp = pass;
        last = pass % 10;

        while (temp > 10)
        {
            temp = temp / 10;
            first = temp;
        }

        // The GeneratePassword it is create new number for newPass
        newPass = GeneratePassword(first, last);

        newPass = pass * 10 + newPass;

        return newPass;
    }


    /* (קלט: מספר שלם (סיסמ של משתמש */
    /* (פלט: מספר שלם (סיסמה חדשה של משתמש */
    public static void Main(string[] args)
    {
        int code, newCode;

        for (int i = 1; i <= 100; i++)
        {
            Console.Write("\nEnter a password of worker {0}: ", i);
            code = int.Parse(Console.ReadLine());

            newCode = CreateNewPassword(code);
            newCode = CreateNewPassword(newCode);
            Console.Write("The new password of worker {0} it was created...   {1}", i, newCode);
            Console.WriteLine("\n\n . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
        }

        Console.ReadKey();
    }
}