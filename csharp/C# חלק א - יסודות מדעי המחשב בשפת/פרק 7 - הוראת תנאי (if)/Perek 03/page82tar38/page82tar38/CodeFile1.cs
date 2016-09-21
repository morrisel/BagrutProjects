using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        char ch1, ch2, ch3;
        //char temp;


        Console.WriteLine("Enter three any characters of abc's");

        Console.Write("The first character ch1: ");
        ch1 = char.Parse(Console.ReadLine());


        Console.Write("The second character ch2: ");
        ch2 = char.Parse(Console.ReadLine());


        Console.Write("The third character ch3: ");
        ch3 = char.Parse(Console.ReadLine());



        if ((ch1 < ch2 && ch1 < ch3) || (ch1 < ch2 && ch1 > ch3) || (ch1 > ch2 && ch1 < ch3))       // (ch1 small) and (ch2 small) or (ch3 small)
        {
            if (ch1 < ch2 && ch1 < ch3)        // (ch1  Smallest)
            {
                Console.WriteLine(ch1);
                if (ch2 < ch3)
                {
                    Console.WriteLine(ch2);
                    Console.WriteLine(ch3);
                }
                else
                {
                    Console.WriteLine(ch3);
                    Console.WriteLine(ch2);
                }
            }
            else     // (ch1 Medium)
            {
                if (ch1 < ch2 && ch1 > ch3)
                {
                    // ch2  Big
                    // ch1  Medium
                    // ch3  Small
                    Console.WriteLine(ch2);
                    Console.WriteLine(ch1);
                    Console.WriteLine(ch3);
                }
                else
                {
                    // ch3 Big
                    // ch1 Medium
                    // ch2 Small
                    Console.WriteLine(ch3);
                    Console.WriteLine(ch1);
                    Console.WriteLine(ch2);
                }
            }
        }
        else
        {
            if ((ch2 < ch1 && ch2 < ch3) || (ch2 < ch1 && ch2 > ch3) || (ch2 > ch1 && ch2 < ch3))       // (ch2 Small) and (ch1 Small) or (ch3 Small)
            {
                if (ch2 < ch1 && ch2 < ch3)     // (ch2 Smallest)
                {
                    Console.WriteLine(ch2);
                    if (ch1 < ch3)
                    {
                        Console.WriteLine(ch1);
                        Console.WriteLine(ch3);
                    }
                    else
                    {
                        Console.WriteLine(ch3);
                        Console.WriteLine(ch1);
                    }
                }
                else   // (ch2 Medium)
                {
                    if (ch2 < ch1 && ch2 > ch3)
                    {
                        // ch1 Big
                        // ch2 Medium
                        // ch3 Small
                        Console.WriteLine(ch3);
                        Console.WriteLine(ch2);
                        Console.WriteLine(ch1);
                    }
                    else
                    {
                        // ch3 Big
                        // ch2 Medium
                        // ch1 Small
                        Console.WriteLine(ch1);
                        Console.WriteLine(ch2);
                        Console.WriteLine(ch3);
                    }
                }
            }
            else
            {
                if ((ch3 < ch1 && ch3 < ch2) || (ch3 < ch1 && ch3 > ch2) || (ch3 > ch1 && ch3 < ch2))       // (ch3 Small) and (ch1 Small) or (ch2 Small)
                {
                    if (ch3 < ch1 && ch3 < ch2)     // (ch3 Smallest)
                    {
                        Console.WriteLine(ch3);
                        if (ch1 < ch2)
                        {
                            Console.WriteLine(ch1);
                            Console.WriteLine(ch2);
                        }
                        else
                        {
                            Console.WriteLine(ch2);
                            Console.WriteLine(ch1);
                        }
                    }
                    else   // (ch3 Medium)
                    {
                        if (ch3 < ch2 && ch3 > ch1)
                        {
                            // ch1 Big
                            // ch3 Medium
                            // ch2 Small
                            Console.WriteLine(ch1);
                            Console.WriteLine(ch3);
                            Console.WriteLine(ch2);
                        }
                        else   // ch2 Big
                        {
                            // ch2 Big
                            // ch3 Medium
                            // ch1 Small
                            Console.WriteLine(ch2);
                            Console.WriteLine(ch3);
                            Console.WriteLine(ch1);
                        }
                    }
                }
            }
        }


        Console.ReadKey();
    }
}