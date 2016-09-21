using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int n1, n2, n3;
        bool sort;

        Console.WriteLine("Enter three numbers");
        Console.WriteLine("\nOrder the numbers in increasing order");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());

        sort = (n1 < n2 && n2 < n3);

        if (sort)
            Console.WriteLine(sort);
        else
            Console.WriteLine(sort);

        
        Console.ReadKey();
    }
}