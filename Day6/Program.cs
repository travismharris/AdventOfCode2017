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
            var originalArray = new int[] { 4, 1, 15, 12, 0, 9, 9, 5, 5, 8, 7, 3, 14, 5, 12, 3 };
            var trackList = new List<int[]>();
            trackList.Add(originalArray);
        }

        public static int[] ShiftAndCapture(int[] array)
        {
            var max = array.Max();
            var dupes = array.Where(a == max);
        }


    }
}
