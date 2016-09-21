using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int num, sum = 0;

        Console.WriteLine("Enter a numbers more 2 or equals to 2");
        Console.WriteLine("--------------------------------------\n");

        for (int i = 2; i <= 10; i++)
        {
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0 && num >= 2)
            {
                Console.WriteLine("\nThe even number is: {0}", num);
                sum = sum + num;
            }
        }
        Console.WriteLine("\nThe sum of even numbers is: {0}", sum);

        Console.ReadKey();
    }
}