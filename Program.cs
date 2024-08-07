using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter day: ");
        int day = int.Parse(Console.ReadLine());

        Console.Write("Enter month: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        bool isLeapYear = false;

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            isLeapYear = true;
        }

        // Output the result
        if (isLeapYear)
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }
    }
}