using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[6];

        // איפוס אברי המערך
        // קליטת נתונים למערך
        // (הדפסת כל איברי המערך בהתאם לסדר קליטתם (בהנחה שהקליטה לפי סדר המציינים
        // (הדפסת כל איברי המערך בסדר ההפוך לקליטתם (בהנחה שהקליטה לפי סדר המציינים
        // הדפסת כל האיברים הנמצאים במקומות הזוגיים
        // הדפסת כל האיברים הנמצאים במקומות האי-זוגיים
        // הדפסת המציינים של איברי המערך שערכם אי-זוגי

        // איפוס אברי המערך
        Console.WriteLine("The numbers in array is:");
        for (int i = 0; i < 6; i++)
            numbers[i] = 0;

        for (int i = 0; i < 6; i++)
        {
            Console.Write(" {0,3}", numbers[i]);
        }

        // קליטת נתונים למערך
        Console.WriteLine("\n\nEnter six numbers for filling the array");
        for (int i = 0; i < 6; i++)
            numbers[i] = int.Parse(Console.ReadLine());

        // (הדפסת כל איברי המערך בהתאם לסדר קליטתם (בהנחה שהקליטה לפי סדר המציינים
        Console.WriteLine("\nPrinting array:");
        for (int i = 0; i < 6; i++)
            Console.Write(" {0,3}", numbers[i]);

        // (הדפסת כל איברי המערך בסדר ההפוך לקליטתם (בהנחה שהקליטה לפי סדר המציינים
        Console.WriteLine("\n\nPrinting reverse array:");
        for (int i = 5; i >= 0; i--)
            Console.Write(" {0,3}", numbers[i]);

        // הדפסת כל האיברים הנמצאים במקומות הזוגיים
        Console.WriteLine("\n\nPrinting array numbers of even position:");
        for (int i = 0; i < 6; i += 2)
            Console.Write(" {0,3}", numbers[i]);

        // הדפסת כל האיברים הנמצאים במקומות האי-זוגיים
        Console.WriteLine("\n\nPrinting array numbers of odd position:");
        for (int i = 1; i < 6; i += 2)
            Console.Write(" {0,3}", numbers[i]);

        // הדפסת המציינים של איברי המערך שערכם אי-זוגי
        Console.WriteLine("\n\nPrinting indexers of array:");
        for (int i = 1; i < 6; i += 2)
            Console.Write(" {0,3}", i);


        /********************* FIRST WAY **********************/
        /*
        // איפוס אברי המערך
        numbers[0] = 0;
        numbers[1] = 0;
        numbers[2] = 0;
        numbers[3] = 0;
        numbers[4] = 0;
        numbers[5] = 0;

        // קליטת נתונים למערך
        numbers[0] = int.Parse(Console.ReadLine());
        numbers[1] = int.Parse(Console.ReadLine());
        numbers[2] = int.Parse(Console.ReadLine());
        numbers[3] = int.Parse(Console.ReadLine());
        numbers[4] = int.Parse(Console.ReadLine());
        numbers[5] = int.Parse(Console.ReadLine());

        // (הדפסת כל איברי המערך לסדר קליטתם (בהנחה שהקליטה לפי סדר המציינים
        Console.Write("\n{0}  {1}  {2}  {3}  {4}  {5}", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5]);

        // (הדפסת כל איברי המערך בסדר ההפוך לקליטתם (בהנחה שהקליטה לפי סדר המציינים
        Console.Write("\n{0}  {1}  {2}  {3}  {4}  {5}", numbers[5], numbers[4], numbers[3], numbers[2], numbers[1], numbers[0]);

        // הדפסת כל האיברים הנמצאים במקומות הזוגיים
        Console.Write("\n{0}  {1}  {2}", numbers[0], numbers[2], numbers[4]);

        // הדפסת כל האיברים הנמצאים במקומות האי-זוגיים
        Console.Write("\n{0}  {1}  {2}  {3}  {4}  {5}", numbers[1], numbers[3], numbers[5]);

        // הדפסת המציינים של איברי המערך שערכם אי-זוגי
        int i = 1;
        while (i < 6 && i % 2 != 0)
        {
            Console.Write("The indexers of arrays is {0} ", i);
            i += 2;
        }
        */

        Console.WriteLine();
        Console.ReadKey();
    }
}