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
            string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" };

            //your code goes here
            string input = Console.ReadLine();
            
            int option = Int32.Parse(input);
            if (option >= 0 && option < 5)
            {
                Console.WriteLine(games[option]);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            
            
        }
    }
}