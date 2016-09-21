using System;

class Program
{
    public static int CheckName(string[] c, string name)
    {
        string temp;
        name = " " + name + " ";
        for (int i = 0; i < c.Length; i++)
        {
            temp = " " + c[i] + " ";

            if (temp.IndexOf(name) == -1)
            {
                return i;
            }
        }

        return -1;
    }

    static void Main()
    {
        Console.WriteLine("Enter number of classes:");
        string[] namesArr = new string[int.Parse(Console.ReadLine())];
        int classNum;
        string stuName;
        for (int i = 0; i < namesArr.Length; i++)
        {
            Console.WriteLine("Insert names of students in class number " + (i + 1) + ":");
            namesArr[i] = Console.ReadLine();
        }

        Console.WriteLine("Insert new student name:");
        stuName = Console.ReadLine();
        classNum = CheckName(namesArr, stuName);

        if (classNum == -1)
        {
            Console.WriteLine("There is a student with name " + stuName + " in each class");
        }
        else
        {
            namesArr[classNum] = namesArr[classNum] + " " + stuName;
            Console.WriteLine("The student in class " + (classNum + 1) + " are: " + namesArr[classNum]);
        }

        Console.ReadKey();
    }
}