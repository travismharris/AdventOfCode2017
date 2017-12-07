using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 4, 1, 15, 12, 0, 9, 9, 5, 5, 8, 7, 3, 14, 5, 12, 3 };

            var memBank = new MemoryBank(array);
            
            memBank.BalanceMemory();

            Console.Write("\nPress any key to exit"); Console.ReadKey();
        }

    }
}
