using System;

class Program
{
    static void Main()
    {
        Random randNum = new Random();
        int i = 0;
        int[] a = { 6, 5, 3, 3, 2, 1 };
        //int[] a = { 5, 4, 3, 1, -2, 5 };
        //int[] a = { 4, 2, 8, 5, 6, 5 };

        int[] tempArr = new int[6];

        Console.Write("\na: #");
        // סורקת את איברי המערך הנוכחי while לולאת
        while (i < 6)
        {
            int num = randNum.Next(6);

            if (a[i] == (num + 1 - i))
            {
                tempArr[i] = a[i];
                Console.Write(" {0}", tempArr[i]);
                i++;
                
            }
        }

        Console.ReadKey();
    }
}