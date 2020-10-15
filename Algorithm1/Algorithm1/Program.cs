using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4,2,1};
            printOdd();
            printArrayValue(arr);
        }

        // Printing Odd numbers 1 to 20
        public static void printOdd()
        {
           
           
            for (int i = 1; i <20; i++)
            {
                if (i%2 == 1)
                {
                    Console.WriteLine(i +" is an odd num ");
                }
            }
            Console.ReadLine();
        }
        

        // Printin each array value and the sum so far
        public static void printArrayValue(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
                Console.WriteLine( "num" + arr[i]+",Sum"+ sum);
            }
            Console.ReadLine();
        }

    }

   
}
