using System;

namespace ConsoleApp1
{
    public class Program2_1
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber1 = random.Next(4);
            int randomNumber2 = random.Next(4);
            Console.WriteLine($"Число {randomNumber1} {(randomNumber1 % 2 == 0 ? "Чётное" : "Нечётное")}\n" +
                              $"Число2 {randomNumber2} {(randomNumber2 % 2 == 0 ? "Чётное" : "Нечётное")}");
        }
    }
}