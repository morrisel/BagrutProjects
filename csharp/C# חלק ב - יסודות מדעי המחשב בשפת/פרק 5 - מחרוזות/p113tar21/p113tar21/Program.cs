using System;

class StringOperation
{
    // 1 - פעולה המקבלת מחרוזת ותו ובודקת האם התו נמצא במחרוזת
    public static bool IsCharFinded(string str, char ch)
    {
        for (int i = 0; i < str.Length; i++)
            if (ch == str[i])
                return true;

        return false;
    }


    // 2 - פעולה המקבלת מחרוזת ותו ובודקת כמה פעמים התו מופיע במחרוזת
    public static int CharAmountInString(string str, char ch)
    {
        int count = 0;

        for (int i = 0; i < str.Length; i++)
            if (ch == str[i])
                count++;

        return count;
    }


    // 3 - פעולה המקבלת מחרוזת ותו ומוחקת את כל המופעים שלו מן המחרוזת
    public static string RemoveCharacter(string str, char ch)
    {
        string temp = str;

        for (int i = 0; i < temp.Length; i++)
        {
            if (ch == temp[i])
            {
                temp = temp.Remove(i, 1);
                i--;
            }
        }

        return temp;
    }


    // 4 - פעולה המקבלת מחרוזת ומחרוזת נוספת, ובודקת האם המחרוזת השנייה נמצאת
    //     ברצף כתת-מחרוזת במחרוזת הראשונה
    public static bool FindSubString(string sentence, string word)
    {
        string st = string.Empty;
        int location = sentence.IndexOf(word);

        if (sentence.Length - location == word.Length)
            st = sentence.Substring(location, word.Length);

        if (st.Equals(word)) return true;

        return false;
    }


    // 5 - פעולה המקבלת מחרוזת ומחזירה מחרוזת מצומצמת שלה, כך שמכל
    //     רצף של תווים זהים באורך כלשהו יישאר רק תו אחד
    public static string RemoveDuplicateContinuousCharacter(string sentence)
    {
        for (int i = 0; i < sentence.Length - 1; i++)
            if (sentence[i] == sentence[i + 1])
                sentence = sentence.Remove(i--, 1);

        return sentence;
    }
}

class Student
{
    // simulator for creates first name and last name
    public static string CreateAutomaticNames()
    {
        Random rnd = new Random();
        Random rndChar = new Random();

        string firstName = "", lastName = "";
        int lenStrName;

        lenStrName = rnd.Next(2, 8);
        for (int j = 0; j < lenStrName; j++)    // First name creator
            firstName = firstName + (char)rndChar.Next('a', 'z');

        lenStrName = rnd.Next(2, 8);
        for (int j = 0; j < lenStrName; j++)    // Last name creator
            lastName = lastName + (char)rndChar.Next('a', 'z');

        Console.WriteLine("First name is created: " + firstName);
        Console.WriteLine("Last name is created: " + lastName);

        return firstName + " " + lastName;
    }

    public static string CreateNames()
    {
        string firstName, lastName;

        Console.Write("Enter first name: ");
        firstName = Console.ReadLine();

        Console.Write("Enter last name: ");
        lastName = Console.ReadLine();

        return firstName + " " + lastName;
    }

    // הפעולה מחפשת אחת האותיות שלא תרינות עבור שם נתון
    // 'e', 'i', 'o', 'a', 'u'
    public static bool IsLetterForWrongName(string name)
    {
        int count = 0;

        for (int i = 0; i < name.Length - 1; i++)
        {
            switch (name[i])
            {
                case 'e': count++; break;
                case 'i': count++; break;
                case 'o': count++; break;
                case 'a': count++; break;
                case 'u': count++; break;
                default: count = 0; break;
            }

            if (count > 2) return true;
        }

        return false;
    }

    public static string[,] FindContinuousSpesialLetter(string[,] table)
    {
        bool f1, f2;
        string[,] tempTable = new string[table.GetLength(0), table.GetLength(1)];
        string firstName = "", lastName = "";
        int location = 0;

        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                location = table[i, j].IndexOf(' ');

                // find for first name
                firstName = table[i, j].Substring(0, location);
                f1 = IsLetterForWrongName(firstName);
                
                // find for last name 
                lastName = table[i, j].Substring(location + 1, table[i, j].Length - location - 1);
                f2 = IsLetterForWrongName(lastName);

                if (f1 || f2)
                    tempTable[i, j] = table[i, j];
            }
        }

        return tempTable;
    }
}


class Program
{
    static void PrintAllStudents(string[,] table)
    {
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                Console.Write("{0,16} ", table[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void PrintWrongNames(string[,] table)
    {
        for (int i = 0; i < table.GetLength(0); i++)
            for (int j = 0; j < table.GetLength(1); j++)
                if (table[i, j] != null)
                    Console.WriteLine("the name of student with wrong name in row {0} and column {1}, is: {2}",
                        j, i, table[i, j]);
    }

    // the method automatic creates all class members: first names and last names
    // and putted them in table string
    static string[,] FillClassMembers(string[,] table)
    {

        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                table[i, j] = Student.CreateAutomaticNames();
                
                Console.WriteLine("---------------------------");
            }
        }


        return table;
    }

    static void Main()
    {
        //string[,] table = new string[10, 4];
        string[,] table = new string[10, 4];

        table = FillClassMembers(table);

        Console.WriteLine("============================= Class Members =============================");
        PrintAllStudents(table);

        Console.WriteLine("\n===================== Class Members with Wrong Names =====================");

        table = Student.FindContinuousSpesialLetter(table);

        Console.WriteLine();
        PrintWrongNames(table);


        Console.ReadKey();
    }
}