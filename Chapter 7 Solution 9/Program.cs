using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Solution_9
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            int maxSumEndingHere = arr[0];
            int maxSumTotal = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                maxSumEndingHere = Math.Max(arr[i], maxSumEndingHere + arr[i]);
                maxSumTotal = Math.Max(maxSumEndingHere, maxSumTotal);
            }

            Console.WriteLine("Result is {0}. ", maxSumTotal);
        }
    }
}
