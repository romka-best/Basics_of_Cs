using System;

namespace ConsoleApp1
{
    public class Program2_5
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                Console.WriteLine("Год високосный");
            }
            else
            {
                Console.WriteLine("Год невисокосный");
            }
        }
    }
}