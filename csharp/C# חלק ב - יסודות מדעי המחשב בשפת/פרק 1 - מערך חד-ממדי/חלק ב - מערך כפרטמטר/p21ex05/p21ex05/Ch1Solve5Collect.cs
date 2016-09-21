using System;

class Ch1Solve5Collect
{
    /* טענת כניסה: הפעולה מקבלת מערך תרומות ומספר כיתה */
    /* טענת יציאה: הפעולה מדפיסה את מספר התלמידים שהתרימו בכל קטגוריה */
    static void Donation(double[] a, int cl)
    {
        // הממוצה של התרומה
        double sum = 0.0;

        for (int i = 0; i < a.Length; i++)
            sum += a[i];

        sum = sum / a.Length;

        int suma = 0, sumb = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] <= sum)
                suma++;         // כמות התרומות עד לממוצע שהתקבלה
            else
                sumb++;         // כמות התרומות מעל הממוצע שהתקבלה4
        }

        Console.WriteLine("Class " + cl + " up to average: " + suma);
        Console.WriteLine("Class " + cl + " more than average: " + sumb);
    }


    static void Main()
    {
        //------------- 1 קלט של גודל הכיתה וסכומי התרומות של תלמידי הכיתה
        Console.WriteLine("Enter number of students in class 1");
        double[] class1 = new double[int.Parse(Console.ReadLine())];

        Console.WriteLine("Enter donation of each students");
        for (int i = 0; i < class1.Length; i++)
            class1[i] = double.Parse(Console.ReadLine());


        //------------- 2 קלט של גודל הכיתה וסכומי התרומות של תלמידי הכיתה
        Console.WriteLine("Enter number of students in class 2");
        double[] class2 = new double[int.Parse(Console.ReadLine())];

        Console.WriteLine("Enter donation of each students");
        for (int i = 0; i < class2.Length; i++)
            class2[i] = double.Parse(Console.ReadLine());

        //--------------------------- Donation זימון הפעולה
        Donation(class1, 1);
        Donation(class2, 2);



        Console.ReadKey();
    }
}