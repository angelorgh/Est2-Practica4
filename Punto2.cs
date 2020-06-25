using System;

namespace Est2_Practica4
{
    public class Punto2
    {
        static int[] countingSort(int[] arr) 
        {
            var numbers = new int[100];
            var result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                numbers[arr[i]]++;
            }

            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int n = numbers[i];
                for (int j = 0; j < n; j++)
                {
                    result[count] = i;
                    count++;
                }
            }

            return result;
        }

        public static void Execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int[] result = countingSort(arr);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}