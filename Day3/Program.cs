using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            char quit = 'q';
            do
            {
                Console.Write("Enter number to find ring:  ");
                var num = int.Parse(Console.ReadLine());
                var ring = new Ring(num);
                Console.WriteLine(ring);

                Console.WriteLine("\n\nq to quit");
                quit = Console.ReadKey().KeyChar;
            } while (quit != 'q');
            
        }



    }
}
