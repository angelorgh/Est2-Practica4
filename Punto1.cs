using System;

namespace Est2_Practica4
{
    public class Punto1
    {
        public static int[] countingSort(int[] arr) 
        {
            var numbers = new int[100];

            for (int i = 0; i < arr.Length; i++)
            {
                numbers[arr[i]]++;
            }

            return numbers;
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