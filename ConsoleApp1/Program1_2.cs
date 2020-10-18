using System;

namespace ConsoleApp1
{
    public class Program1_2
    {
        static void Main(string[] args)
        {
            int value1 = Convert.ToInt32(Console.ReadLine());
            int value2 = Convert.ToInt32(Console.ReadLine());
            string str1 = "";
            value1 *= 3;
            value2 += 12;
            Console.WriteLine($"value1 = {value1}, value2 = {value2}, str1= {str1}");
        }
    }
}