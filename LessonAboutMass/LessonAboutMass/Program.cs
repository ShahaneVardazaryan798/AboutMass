using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LessonAboutMass
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
            WriteLine("\n Display a pair of mass elements");

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] % 2 == 0)
                {
                    Write(arr[j] + "\t");
                }
                else
                {
                    arr[j] = 0;
                    Write(arr[j] + "\t");
                }
            }
            WriteLine("\n Show the sum of all elements");
            int a = 0;
            double x = 0;
            for (int z = 0; z < arr.Length; z++)
            {
                a += arr[z];

            }
            x = a / k;
            WriteLine("The sum=" + a);
            WriteLine("The middle value =" + x);
            ReadLine();
        }
    }
}
