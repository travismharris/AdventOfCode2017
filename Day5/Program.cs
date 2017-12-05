using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = LoadPuzzle(@"..\Input\Day5Input.txt");
            //int[] inputArray = new int[]{0, 3, 0, 1, -3};
            Console.WriteLine("There are " + inputArray.Length + " ints in the array.");
            //Console.WriteLine("It took " + ProcessArray(inputArray) + " jumps to process array.");
            Console.WriteLine("It took " + AlternateProcessArray(inputArray) + " jumps to process array.");

            Console.ReadKey();

        }

        public static int[] LoadPuzzle(string fileName)
        {
            List<int> intList = new List<int>();
            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                intList.Add(int.Parse(line));
            }
            return intList.ToArray();
        }

        public static int ProcessArray(int[] input)
        {
            int jumpCount = 0;
            int index = 0;
            while (index < input.Length)
            {
                var currentItem = input[index];
                var newCurrentItemValue = currentItem + 1;
                input[index] = newCurrentItemValue;
                index = index + currentItem;

                if (index < 0)
                    index = 0;

                jumpCount++;
            }

            return jumpCount;
        }

        public static int AlternateProcessArray(int[] input)
        {
            int jumpCount = 0;
            int index = 0;
            while (index < input.Length)
            {
                int newCurrentItemValue;
                var currentItem = input[index];
                if (currentItem >= 3)
                {
                    newCurrentItemValue = currentItem - 1;
                }
                else
                {
                    newCurrentItemValue = currentItem + 1;
                }
                input[index] = newCurrentItemValue;
                index = index + currentItem;

                if (index < 0)
                    index = 0;

                jumpCount++;
            }

            return jumpCount;
        }
    }
}
