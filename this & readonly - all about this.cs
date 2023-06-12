using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            Avg avg = new Avg(num1, num2);

            Console.WriteLine(avg.GetAvg());
        }
    }

    class Avg
    {
        double num1;
        double num2;
        
        public Avg(double a, double b)
        {
            this.num1 = a;
            this.num2 = b;
        }
        

        public double GetAvg()
        {
            return (num1 + num2)/2;
        }
    }
}

/*
class Person {
  private readonly string name = "John"; 
  public Person(string name) {
    this.name = name; 
  }
}

readonly string name; // OK
const double PI; // Error

readonly double a = Math.Sin(60); // OK
const double b = Math.Sin(60); // Error! 
*/