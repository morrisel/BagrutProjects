using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int Niv, Dana, Naama;
        Console.WriteLine("The elections of Niv, Dana and Naama");
        Console.WriteLine("Enter three different numbers for Niv, Dana and Naama\n");

        Console.Write("How many points geted Niv?\t");
        Niv = int.Parse(Console.ReadLine());
        Console.Write("How many points geted Dana?\t");
        Dana = int.Parse(Console.ReadLine());
        Console.Write("How many points geted Naama?\t");
        Naama = int.Parse(Console.ReadLine());

        if (Niv > Dana && Niv > Naama)
        {
            Console.WriteLine("\nNiv have a\t{0} points", Niv);
            if (Dana > Naama)
            {
                Console.WriteLine("Dana have a\t{0} points", Dana);
                Console.WriteLine("Naama have a\t{0} points", Naama);
            }
            else
            {
                Console.WriteLine("Naama have a\t{0} points", Naama);
                Console.WriteLine("Dana have a\t{0} points", Dana);
            }
        }
        else
        {
            if ((Niv > Dana && Niv < Naama) || (Niv < Dana && Niv > Naama))
            {
                if (Niv > Dana && Niv < Naama)
                {
                    Console.WriteLine("\nNaama have a\t{0} points", Naama);
                    Console.WriteLine("Niv have a\t{0} points", Niv);
                    Console.WriteLine("Dana have a\t{0} points", Dana);
                }
                else
                {
                    Console.WriteLine("\nDana have a\t{0} points", Dana);
                    Console.WriteLine("Niv have a\t{0} points", Niv);
                    Console.WriteLine("Naama have a\t{0} points", Naama);
                }
            }
            else
            {
                if (Dana > Niv && Dana > Naama)
                {
                    Console.WriteLine("\nDana have a\t{0} points", Dana);
                    if (Niv > Naama)
                    {
                        Console.WriteLine("Niv have a\t{0} points", Niv);
                        Console.WriteLine("Naama have a\t{0} points", Naama);
                    }
                    else
                    {
                        Console.WriteLine("Naama have a\t{0} points", Naama);
                        Console.WriteLine("Niv have a\t{0} points", Niv);
                    }
                }
                else
                {
                    if ((Dana > Niv && Dana < Naama) || (Dana < Niv && Dana > Naama))
                    {
                        if (Dana > Niv && Dana < Naama)
                        {
                            Console.WriteLine("\nNaama have a\t{0} points", Naama);
                            Console.WriteLine("Dana have a\t{0} points", Dana);
                            Console.WriteLine("Niv have a\t{0} points", Niv);
                        }
                        else
                        {
                            Console.WriteLine("\nNiv have a\t{0} points", Niv);
                            Console.WriteLine("Dana have a\t{0} points", Dana);
                            Console.WriteLine("Naama have a\t{0} points", Naama);
                        }
                    }
                    else
                    {
                        if (Naama > Niv && Naama > Dana)
                        {
                            Console.WriteLine("\nNaama have a\t{0} points", Naama);
                            if (Niv > Dana)
                            {
                                Console.WriteLine("Niv have a\t{0} points", Niv);
                                Console.WriteLine("Dana have a\t{0} points", Dana);
                            }
                            else
                            {
                                Console.WriteLine("Dana have a\t{0} points", Dana);
                                Console.WriteLine("Niv have a\t{0} points", Niv);
                            }
                        }
                        else
                        {
                            if ((Naama > Niv && Naama < Dana) || (Naama < Niv && Naama > Dana))
                            {
                                if (Naama > Niv && Naama < Dana)
                                {
                                    Console.WriteLine("\nDana have a\t{0} points", Dana);
                                    Console.WriteLine("Naama have a\t{0} points", Naama);
                                    Console.WriteLine("Niv have a\t{0} points", Niv);
                                }
                                else
                                {
                                    Console.WriteLine("\nNiv have a\t{0} points", Niv);
                                    Console.WriteLine("Naama have a\t{0} points", Naama);
                                    Console.WriteLine("Dana have a\t{0} points", Dana);
                                }
                            }
                            else
                            {
                            }
                        }
                    }
                }
            }
        }


        Console.ReadKey();
    }
}