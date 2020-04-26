using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AboutSorts
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int[] arr = new int[10] ;
            for(int i=0; i<arr.Length;i++)
            {
                arr[i] = rd.Next(-100, 101);
                Write(arr[i]+"\t");

            }
            WriteLine("\nThe sorted list is");
            for (int j = 0; j < 9; j++)
            {
                int first = j;
                for (int x = j+1; x < 10; x++)
                {
                    if (arr[x] < arr[first])
                    {
                        first = x;
                    }
                }
                int temp = arr[j];
                arr[j] = arr[first];
                arr[first] = temp;
               
                Write(arr[j]+"\t");
            } 
        }
    }
}
