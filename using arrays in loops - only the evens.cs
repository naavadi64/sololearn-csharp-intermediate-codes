using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int count = 0;
            while (count <5)
            {
                numbers[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            //your code goes here
            int sum = 0;
            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                {
                    sum += n;
                }
            }
            Console.WriteLine(sum);
            
        }
    }
}