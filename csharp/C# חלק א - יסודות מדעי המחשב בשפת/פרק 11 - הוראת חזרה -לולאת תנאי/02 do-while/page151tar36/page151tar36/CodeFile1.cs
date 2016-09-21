using System;

//The programm check if the figure is in the number
class CodeFile1
{
    static void Main(string[] args)
    {
        int dig, rem, temp, fig;
        bool flag = false;

        Console.Write("Enter a number: ");
        dig = int.Parse(Console.ReadLine());

        Console.Write("Enter a figure: ");
        fig = int.Parse(Console.ReadLine());

        temp = dig;

        do
        {
            rem = dig % 10;
            if (rem == fig)
            {
                flag = true;
            }
            else
            {
                dig = dig / 10;
                if (dig == 0)
                {
                    flag = true;
                    dig = temp * 10 + fig;
                }
            }
        }
        while (!flag);
        
        if (dig > temp)
            Console.WriteLine("Figure didn't finded, it was added to the number:  {0}", dig);
        else
            Console.WriteLine("Figue finded in the number, it wasn't added to the number:  {0}", temp);

        Console.ReadKey();
    }
}