using System;

namespace ConsoleApp1
{
    public class Program1_1
    {
        static void Main(string[] args)
        {
            int value1 = 3;
            int value2 = 4;
            int value3;
            value3 = value2;
            value2 = value1;
            value1 = value3;
            Console.WriteLine($"value1 = {value1}, value2 = {value2}");
        }
    }
}