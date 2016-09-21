using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        double jump, maxJump;
        int count = 1, countJump = 0;

        Console.Write("Enter the jump height: ");
        jump = double.Parse(Console.ReadLine());
        maxJump = jump;

        for (int i = 2; i <= 8; i++)
        {
            Console.Write("Enter the jump height: ");
            jump = double.Parse(Console.ReadLine());

            count++;

            if (jump > maxJump)
            {
                maxJump = jump;
                countJump = count;
            }
        }

        Console.WriteLine("\n\nThe maximum jump is: {0}, and the serial number of jumper is: {1}", maxJump, countJump);


        Console.ReadKey();
    }
}