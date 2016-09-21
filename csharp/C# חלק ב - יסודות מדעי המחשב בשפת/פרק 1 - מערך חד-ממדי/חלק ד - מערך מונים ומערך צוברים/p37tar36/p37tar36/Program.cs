using System;

class Program
{
    // מייצג את מספרה של ההצגה N המספר הקבוע
    const int N = 15;

    static void Main()
    {
        int cards = 0;
        int j = 1;
        int[] show = new int[N];   // הצגה
        
        Console.WriteLine("The number of shows: between [1-15]");
        Console.WriteLine("For stop the programm <enter 0 for number of show>");

        do
        {
            show[j - 1] += cards;

            Console.Write("enter an amount of cards: ");
            cards = int.Parse(Console.ReadLine());      // כמה כרטיסים התלמיד רוצה לקנות

            Console.Write("enter a number of show: ");
            j = int.Parse(Console.ReadLine());          // לאיזה מספר של הצגה

        } while (j != 0);

        Console.WriteLine();

        // האלגוריתם מציג את מספר הכרטיסים שנדרשים לכל הצגה
        // מספר ההצגות הנמכרות ביותר
        for (int i = 0; i < N; i++)
            Console.WriteLine("For show " + (i + 1) + " we have " + show[i] + " cards");



        Console.ReadKey();
    }
}