using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int sum = 0, i, numOfStudent;

        for (i = 1; i <= 7; i++)
        {
            Console.Write("Enter the number of students in bus number {0}  ", i);
            numOfStudent = int.Parse(Console.ReadLine());
            sum = sum + numOfStudent;
        }
        Console.WriteLine("\nThe number of students is: {0}", sum);

        Console.ReadKey();
    }
}