using System;

namespace ConsoleApp1
{
    public class Program3_3
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-6, 10);
            }

            int maxMinus = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < maxMinus)
                {
                    maxMinus = array[i];
                }
            }

            if (maxMinus == 0)
            {
                Console.WriteLine("Таких элементов нет");
            }
            else
            {
                Console.WriteLine($"Найден элемент {maxMinus}");
            }
        }
    }
}