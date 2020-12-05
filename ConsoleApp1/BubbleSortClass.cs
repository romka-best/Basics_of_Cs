using System;


namespace ConsoleApp1
{
    public class BubbleSortClass
    {
        static void Main(string[] args)
        {
            int[] array = GetArray();
            long calcTime = DateTime.Now.Ticks;

            BubbleSort(array);

            calcTime -= DateTime.Now.Ticks;

            Console.Write(MathF.Abs(calcTime));
        }

        public static int[] GetArray()
        {
            int[] array = new int[100000];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 101);
            }

            return array;
        }

        public static void PrintArray(int[] arr)
        {
            foreach (var a in arr)
            {
                Console.Write(a + " ");
            }

            Console.WriteLine();
        }

        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }
        }
    }
}