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
            //var array = new int[] { 0, 14, 13, 12, 11, 10, 8, 8, 6, 6, 5, 3, 3, 2, 1, 10 };
            var array = new int[] { 4, 1, 15, 12, 0, 9, 9, 5, 5, 8, 7, 3, 14, 5, 12, 3 };
            var memBank = new MemoryBank(array);
            //Console.WriteLine("Dup Max? " + memBank.DuplicateMaxValue());
            memBank.BalanceMemory();
            
            Console.ReadKey();
        }

    }
}
