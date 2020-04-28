using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Signature
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            WriteLine("Enter the size of array");
            int k = int.Parse(ReadLine());
            int[] arr = new int[k];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(-100, 100);
                Write(arr[i] + "\t");
            }

            WriteLine("Enter the value for new element");
            int x = int.Parse(ReadLine());
            WriteLine("Enter the index of new element");
            int y = int.Parse(ReadLine());
            WriteLine("Show the new array");

            int[] Arr = new int[k + 1];
            for (int j = 0; j < k + 1; j++)
            {
                if (j < y - 1)
                    Arr[j] = arr[j];
                ////else if (j == y - 1)
                ////    Arr[j] = x;
                ////else
                ////    Arr[j] = arr[j - 1];
                
            }ReadLine();

           
            for (int c = 0; c < k + 1; c++)
                Console.Write(Arr[c] + " ");
            Console.WriteLine();
        }

    }
    
}
