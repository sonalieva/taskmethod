using System;

namespace methodtask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40 };
            int max = largest(arr);
            Console.WriteLine(max);


            static int largest(int[] arr)
            {
                int max = arr[0];
                for (int i = 1; i < arr.Length; i++)
                    if (arr[i] > max)
                        max = arr[i];
                return max;

            }
        }
    }
}
