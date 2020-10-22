using System;

namespace ConsoleApp1
{
    public class Program3_6
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();
            short kolPol = 0;
            short kolOtr = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-6, 10);
                if (array[i] >= 0)
                {
                    kolPol++;
                }
                else
                {
                    kolOtr++;
                }
            }

            int[] arrayPol = new int[kolPol];
            int[] arrayOtr = new int[kolOtr];
            short curIndexPol = 0;
            short curIndexOtr = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    arrayPol[curIndexPol] = array[i];
                    curIndexPol++;
                }
                else
                {
                    arrayOtr[curIndexOtr] = array[i];
                    curIndexOtr++;
                }
            }
            
            Console.WriteLine("Положительные: ");
            for (int i = 0; i < arrayPol.Length; i++)
            {
                Console.Write($"{arrayPol[i]} ");
                if (i == arrayPol.Length - 1)
                {
                    Console.Write("\n");
                }
            }
            Console.WriteLine("Отрицательные: ");
            for (int i = 0; i < arrayOtr.Length; i++)
            {
                Console.Write($"{arrayOtr[i]} ");
            }
        }
    }
}