using System;

namespace ConsoleApp1
{
    public class Program3_4
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int sumNumbers = 0;
            int productNumbers = 0;
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-6, 10);
            }

            for (int i = 0; i < array.Length; i++)
            {
                sumNumbers += array[i];
                productNumbers *= array[i];
            }
            Console.WriteLine($"Сумма: {sumNumbers}\nПроизведение: {productNumbers}");
        }
    }
}