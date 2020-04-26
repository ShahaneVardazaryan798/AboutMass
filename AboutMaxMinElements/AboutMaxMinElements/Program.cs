using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AboutMaxMinElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            WriteLine("Enter the size of mass");
            int k = int.Parse(ReadLine());
            int[] arr = new int[k];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = rd.Next(-100, 100);
                Write(arr[i]+"\t");
            }
            int max = -1;
            for(int j=0;j<arr.Length;j++)
            {
                if(arr[j]>max)
                {
                    max = arr[j]; 
                }
            }
            WriteLine("max=" + max+"\n");
            int min = 1;
            for(int x=0;x<arr.Length;x++)
            {
             if(arr[x]<min)
             {
                    min = arr[x];
             }
            }
            WriteLine("min=" + min + "\n");
            ReadLine();
            WriteLine("The sorted list is");
            for (int a = 0; a <k-1; a++)
            {
                int iMin = a;
                for(int b=a+1;b<k;b++)
                {
                    if(arr[b]>arr[iMin])
                    {
                        iMin = b;  
                    }
                }
                int temp = arr[a];
                arr[a] = arr[iMin];
                arr[iMin] = temp;
                Write(arr[a]+"\t");
            }
            ReadLine();
            WriteLine("Enter the number of Max");
            int d = int.Parse(ReadLine());
            for (int c = 0; c < arr.Length; c++)
            {
                 do
                 {
                    break;
                 }
                 while (c == d);
                 WriteLine($"The {d}rd Max = " + arr[d-1]);
                 ReadLine();
            }
            ReadLine();

          
            
          

                


        } 
    }
}
