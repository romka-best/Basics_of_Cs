using System;


namespace ConsoleApp1
{
    public class QuickSortClass
    {
        static void Main(string[] args)
        {
            int[] array = GetArray();
            long calcTime = DateTime.Now.Ticks;

            QuickSort(array, 0, array.Length - 1);

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

        public static int Partition(int[] array, int left, int right)
        {
            int pivot = array[left];
            int lIndex = left + 1;
            int rIndex = right;
            while (true)
            {
                while (lIndex <= rIndex && array[lIndex] <= pivot)
                {
                    lIndex += 1;
                }

                while (rIndex >= lIndex && array[rIndex] >= pivot)
                {
                    rIndex -= 1;
                }

                if (rIndex <= lIndex)
                {
                    break;
                }

                (array[lIndex], array[rIndex]) = (array[rIndex], array[lIndex]);
            }

            (array[left], array[rIndex]) = (array[rIndex], array[left]);
            return rIndex;
        }

        public static int[] QuickSort(int[] array, int left, int right)
        {
            if (right <= left)
            {
                return array;
            }
            else
            {
                int pivot = Partition(array, left, right);
                QuickSort(array, left, pivot - 1);
                QuickSort(array, pivot + 1, right);
            }

            return array;
        }
    }
}