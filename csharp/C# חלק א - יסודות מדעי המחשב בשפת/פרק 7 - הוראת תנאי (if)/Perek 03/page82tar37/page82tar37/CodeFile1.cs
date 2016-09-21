using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        float amount;
        float bankZero = 0;

        Console.Write("Enter an amount on bank account of Yossi: ");
        amount = float.Parse(Console.ReadLine());

        if (bankZero < amount || bankZero == amount)
        {
            if (bankZero < amount)
            {
                Console.WriteLine("Yossin in a plus of his bank account");
            }
            else
            {
                Console.WriteLine("Yossi have a zero money on his bank account");
            }
        }
        else
        {
            Console.WriteLine("Yossi in a debt, he need deposit money on his bank account");
        }

        Console.ReadKey();
    }
}