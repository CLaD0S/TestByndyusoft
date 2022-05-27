using System;

namespace TaskFromByndyusoft
{
    internal class Program
    {
        static void Main()
        {
            Console.ReadKey();
        }
    }
    public static class Utilities
    {
        public static int SumMin(int[] array)
        {
            if (array.Length == 0) return 0;
            if (array.Length == 1) return array[0];

            int min1 = int.MaxValue;
            int min2 = int.MaxValue;

            foreach (int i in array)
            {
                if (i < min1 || i < min2)
                    if (min1 < min2)
                        min2 = i;
                    else
                        min1 = i;
            }
            return min1 + min2;
        }
    }
}