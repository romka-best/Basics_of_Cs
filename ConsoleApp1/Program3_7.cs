using System;

namespace ConsoleApp1
{
    public class Program3_7
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();
            short kolPol = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-6, 10);
                if (array[i] >= 0)
                {
                    kolPol++;
                }
            }

            int[] arrayPol = new int[kolPol];
            short curIndexPol = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    arrayPol[curIndexPol] = i;
                    curIndexPol++;
                }
            }

            Console.WriteLine("Положительные индексы: ");
            for (int i = 0; i < arrayPol.Length; i++)
            {
                Console.Write($"{arrayPol[i]} ");
            }
        }
    }
}