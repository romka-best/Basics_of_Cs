using System;


namespace ConsoleApp1
{
    public class SelectionSortClass
    {
        static void Main(string[] args)
        {
            int[] array = GetArray();
            long calcTime = DateTime.Now.Ticks;

            SelectionSort(array);

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

        public static void SelectionSort(int[] array)
        {
            for (int scanIndex = 0; scanIndex < array.Length; scanIndex++)
            {
                int minIndex = scanIndex;
                for (int compIndex = scanIndex + 1; compIndex < array.Length; compIndex++)
                {
                    if (array[compIndex] < array[minIndex])
                    {
                        minIndex = compIndex;
                    }
                }

                if (minIndex != scanIndex)
                {
                    (array[scanIndex], array[minIndex]) = (array[minIndex], array[scanIndex]);
                }
            }
        }
    }
}