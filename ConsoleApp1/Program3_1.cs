using System;

namespace ConsoleApp1
{
    public class Program3_1
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(4);
                if (array[i] == 0)
                {
                    array[i] = 2;
                }
            }
        }
    }
}