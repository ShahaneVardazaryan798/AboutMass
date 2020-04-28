using System;
using static System.Console;

namespace AddMassElement
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
                Write(arr[i]+"\t");
            }
            
            WriteLine("Enter the value for new element");
            int x = int.Parse(ReadLine());
            WriteLine("Enter the index of new element");
            int y = int.Parse(ReadLine());
            WriteLine("Show the new array");
            
            int[] Arr = new int[k + 1];
            Arr[y] = x;
            for (int c = 0; c < k-(k-y); c++)
            {
                Arr[c] = arr[c];
                Write(Arr[c]+"\t");
            }
            WriteLine("enter the Enter to continue ");
            ReadLine();
          
            for (int z = 0; z <k-(k-y-1); z++)
            {
                arr[y] =Arr[y];
                Arr[y] = x;
                Arr[z] = arr[z];
                Write(Arr[z]+"\t");
                
            }
            WriteLine("The end of elements");
            ReadLine();
            for (int s = y; s <k+1; s++)
            {
                
                Arr[s] = arr[s];
                Write(Arr[s]+"\t");
            }
            WriteLine("Arr.lenght");
            for (int j = 0; j <Arr.Length; j++)
            {
                Write("Arr[]=" + Arr[j]);
            }

           
            

        }
    }
}
