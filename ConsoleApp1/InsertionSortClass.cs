using System;


namespace ConsoleApp1
{
    public class InsertionSortClass
    {
        static void Main(string[] args)
        {
            int[] array = GetArray();
            long calcTime = DateTime.Now.Ticks;

            InsertionSort(array);

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

        public static void InsertionSort(int[] array)
        {
            for (int scanIndex = 1; scanIndex < array.Length; scanIndex++)
            {
                int temp = array[scanIndex];

                int minIndex = scanIndex;
                while (minIndex > 0 && temp < array[minIndex - 1])
                {
                    array[minIndex] = array[minIndex - 1];
                    minIndex -= 1;
                }

                array[minIndex] = temp;
            }
        }
    }
}