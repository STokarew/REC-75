using System;
using System.Linq;

namespace REC_76
{
    class Program
    {
        static int SumRecursion(int[] arr , int i=0)
        {
            if (i >= arr.Length)
                return 0;
            int sum = SumRecursion(arr, i+1);
            return arr[i] + sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите числа через запятую: ");
            var ARR = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            Console.Write(SumRecursion(ARR));
            Console.ReadKey();
        }
    }
}