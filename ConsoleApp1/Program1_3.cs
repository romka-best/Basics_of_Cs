using System;

namespace ConsoleApp1
{
    public class Program1_3
    {
        static void Main(string[] args)
        {
            int priceMilk = Convert.ToInt32(Console.ReadLine());
            int priceMatches = Convert.ToInt32(Console.ReadLine());
            int kolMilk = Convert.ToInt32(Console.ReadLine());
            int kolMathes = Convert.ToInt32(Console.ReadLine());
            int total = priceMatches * kolMathes + priceMilk * kolMilk;
            Console.WriteLine($"{total}");
        }
    }
}