using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        double midGrade, fracPositive, fracNegative, temp;
        int endGrade, tmp1, tmp2;

        Console.WriteLine("Enter the grade for student between (40 - 100)");

        Console.Write("\nEnter the grade of student ");
        midGrade = double.Parse(Console.ReadLine());
        Console.WriteLine();

        temp = midGrade;
        temp = temp * 10;

        tmp1 = (int)temp / 10; // divided number
        tmp2 = (int)temp % 10; // remained number

        if ((tmp2 % 2 == 0 && tmp2 >= 6) || (tmp2 >= 6)) // rak misparin zugiim 12, 14, 16,,,,,
        {
            endGrade = (int)Math.Round(midGrade);
            Console.WriteLine("Grade of student:\t\t" + endGrade);
            fracNegative = ((midGrade * 10) % 10) / 10;
            fracNegative = fracNegative - 1;
            Console.WriteLine("In the end of stdying add the:\t" + fracNegative);
        }
        else
        {
            if ((tmp1 + tmp2) % 2 != 0)   // Positive and odd numbers
            {
                endGrade = (int)Math.Round(midGrade);
                Console.WriteLine("Grade of student:\t\t" + endGrade);
                fracPositive = ((midGrade * 10) % 10) / 10;
                Console.WriteLine("In the end of stdying add the:\t" + fracPositive);
            }
            else   // Negative
            {
                if ((tmp1 + tmp2) % 2 == 0)
                {
                    if (tmp1 % 2 == 0 && tmp2 % 2 == 0)
                    {
                        endGrade = (int)Math.Round(midGrade);
                        Console.WriteLine("Grade of student:\t\t" + endGrade);
                        fracPositive = ((midGrade * 10) % 10) / 10;
                        Console.WriteLine("In the end of stdying add the:\t" + fracPositive);
                    }
                    else
                    {
                        endGrade = (int)Math.Round(midGrade);
                        Console.WriteLine("Grade of student:\t\t" + endGrade);
                        fracNegative = ((midGrade * 10) % 10) / 10;
                        fracNegative = fracNegative - 1;
                        Console.WriteLine("In the end of stdying add the:\t" + fracNegative);
                    }
                }
                else
                {
                    endGrade = (int)Math.Round(midGrade);
                    Console.WriteLine("Grade of student:\t\t" + endGrade);
                    fracPositive = ((midGrade * 10) % 10) / 10;
                    Console.WriteLine("In the end of stdying add the:\t" + fracPositive);
                }
            }
        }
        
        Console.ReadKey();
    }
}