using System;

namespace ConsoleApp1
{
    public class Program2_6
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Такого треугольника не существует");
            }
            else
            {
                if (a == b && b == c && c == a)
                {
                    Console.WriteLine("Равносторонний");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Равнобедренный");
                }
                else
                {
                    Console.WriteLine("Разносторонний");
                }
            }
        }
    }
}