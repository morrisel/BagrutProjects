using System;

class Program
{
    const int N = 4;
    static void Main()
    {
        // ספינות שהיו לפני טיפול האחרון
        //char[] boatHandle = { 'a', 'b', 'c', 'd' };

        // ספינות שהיו בטיפול האחרון
        //char[] boatLastHandle = { 'a', 'g', 'x', 'c' };

        bool isFinded;
        char[] boatHandle = new char[N];
        char[] boatLastHandle = new char[N];

        // The ships what be before last handle
        Console.WriteLine("# The ships what be before last handle:");
        for (int i = 0; i < N; i++)
            boatHandle[i] = char.Parse(Console.ReadLine());

        Console.WriteLine(new string('-', 50));
        // The ships what be last handle
        Console.WriteLine("# The ships what be before last handle:");
        for (int i = 0; i < N; i++)
            boatLastHandle[i] = char.Parse(Console.ReadLine());

        // איחוד הספינות
        char[] unionBoats = new char[2 * N];

        // חיתוך הספינות
        char[] intersectionBoats = new char[N];

        // ההפרש הסימטרי של שני הקבוצות של הסירות
        char[] symmetricDifferenceBoats = new char[2 * N];

        // איחוד של שני מערכים
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (i == 0)
                    unionBoats[j] = boatHandle[j];
                else
                    unionBoats[j + 4] = boatLastHandle[j];
            }
        }

        int k = 0;
        // חיתוך של שני המערכים
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (boatHandle[i] == boatLastHandle[j])
                {
                    intersectionBoats[k] = boatLastHandle[j];
                    k++;
                }
            }
        }

        ////////////////////////////////////////////////////////
        // מציאת הפרש בין האיחוד של הקבוצות לבין החיתוך של הקבוצות
        k = 0;
        for (int i = 0; i < 2 * N; i++)
        {
            isFinded = false;

            for (int j = 0; j < N; j++)
                if (unionBoats[i] == intersectionBoats[j])
                    isFinded = true;

            if (!isFinded)
            {
                symmetricDifferenceBoats[k] = unionBoats[i];
                k++;
            }
        }

        for (int i = 0; i < N; i++)
        {
            Console.Write(" " + symmetricDifferenceBoats[i]);
        }

        Console.ReadKey();
    }
}