using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();

            while (q.Count<3)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                //your code goes here
                q.Enqueue(num);
            }

            Console.Write("Queue: ");
            foreach (int i in q)
                Console.Write(i + " ");
            Console.WriteLine();
            
            Console.Write("Sorted: ");
            //your code goes here
            List<int> sorted = new List<int>();
            foreach (int i in q)
            {
                sorted.Add(i);
            }
            sorted.Sort();
            foreach (int i in sorted)
                Console.Write(i + " ");
        }
    }
}