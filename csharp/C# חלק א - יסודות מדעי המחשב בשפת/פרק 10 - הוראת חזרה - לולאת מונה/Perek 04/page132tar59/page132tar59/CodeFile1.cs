using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int n, num = 0;

        n = int.Parse(Console.ReadLine());

        for (int i=0 ; i <= n; i++)
        {
            num = num + i;
            Console.WriteLine(num);
        }
        Console.WriteLine("--------------\n");
        Console.WriteLine(num);
        Console.ReadKey();
    }
}