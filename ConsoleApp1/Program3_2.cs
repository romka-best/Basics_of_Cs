using System;

namespace ConsoleApp1
{
    public class Program3_2
    {
        static void Main(string[] args)
        {
            int kol = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[kol];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}