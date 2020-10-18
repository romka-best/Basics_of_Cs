using System;

namespace ConsoleApp1
{
    public class Program2_2
    {
        static void Main(string[] args)
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            if (number1 >= number3 && number1 >= number2)
            {
                Console.WriteLine($"Число {number1} самое большое");
            }
            else if (number2 >= number1 && number2 >= number3)
            {
                Console.WriteLine($"Число {number2} самое большое");
            }
            else if (number3 >= number1 && number3 >= number2)
            {
                Console.WriteLine($"Число {number3} самое большое");
            }
        }
    }
}