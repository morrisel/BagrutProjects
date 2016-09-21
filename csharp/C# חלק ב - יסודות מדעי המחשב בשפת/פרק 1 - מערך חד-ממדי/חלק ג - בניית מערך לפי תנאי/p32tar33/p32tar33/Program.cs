using System;

class Program
{
    static void Main()
    {
        int m = 0, n = 0;

        // פרחים של כל המשתלה
        int[] flower1 = new int[] { 240, 120, 250, 117, 130, 225, 230, 231 };

        // פחרים שנבלו ממשפחה 1
        int[] flower2 = new int[8];

        // פרחים שלא נבלו ממשפחה 2 
        int[] flower3 = new int[8];


        for (int i = 0; i < flower1.Length; i++)
        {
            if (flower1[i] / 100 == 1)
            {
                flower2[m] = flower1[i];
                m++;
            }
            else
            {
                flower3[n] = flower1[i];
                n++;
            }
        }

        Console.Write("# flower1:");
        for (int i = 0; i < flower1.Length; i++)
            Console.Write("{0,5}", flower1[i]);

        Console.Write("\n\n# flower2:");
        for (int i = 0; i < flower2.Length; i++)
            Console.Write("{0,5}", flower2[i]);

        Console.Write("\n\n# flower3:");
        for (int i = 0; i < flower1.Length; i++)
            Console.Write("{0,5}", flower3[i]);

        Console.ReadKey();
    }
}