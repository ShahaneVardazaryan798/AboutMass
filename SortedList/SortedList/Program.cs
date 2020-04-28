using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            WriteLine("Enter the size of Mass");
            int k = int.Parse(ReadLine());
            int[] arr = new int[k];
           

            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = rd.Next(-100, 100);
                Write(arr[i]+"\t");
            
               
            }
            ArrayList numbers = new ArrayList(arr.Length);
            WriteLine("\n Enter the index of Max");
            int max = -100;
            int a = 0;
            do
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > max)
                    {
                        max = arr[j];
                    }
                }
                WriteLine("\n" + "Max = " + max);

                
                
                numbers.RemoveAt(numbers.IndexOf(max));
                foreach (var n in numbers)
                {
                    Write(n);
                }
            } while (a<x);
            
            ReadLine();

        }
    }
}
