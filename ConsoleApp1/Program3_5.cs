using System;

namespace ConsoleApp1
{
    public class Program3_5
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int sumNumbers = 0;
            int productNumbers = 0;
            Random random = new Random();
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = random.Next(0, 39);
            }

            int lastNumber = Convert.ToInt32(Console.ReadLine());
            int position = Convert.ToInt32(Console.ReadLine());

            if (position >= 0 && position < array.Length)
            {
                for (int i = array.Length - 1; i > position; i--)
                    array[i] = array[i - 1];
            }
            else
            {
                position = array.Length - 1;
            }

            array[position] = lastNumber;


            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}