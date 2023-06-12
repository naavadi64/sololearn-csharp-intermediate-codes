using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //your code goes here
            int[] arr = new int[5];
            for (int i=0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int min = arr.Min();
            int max = arr.Max();
            Console.WriteLine(min+max);
            
        }
    }
}