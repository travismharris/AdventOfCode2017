using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            //var rawTowerStringList = LoadPuzzle(@"..\Input\Day7Input.txt");
            var rawTowerStringList = LoadPuzzle(@"..\Input\TestInput.txt");

            Console.Write("There are " + rawTowerStringList.Count + " towers in the List");
            var towers = new List<Tower>();
            foreach(var a in rawTowerStringList)
            {
                towers.Add(new Tower(a));
            }


            bool noChanges = false;

            while (!noChanges)
            {

            }

            Console.Write("\n\nPress any key to exit");
            Console.ReadKey();
        }

        public static List<string[]> LoadPuzzle(string fileName)
        {
            List<string[]> towers = new List<string[]>();
            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                var a = line.Split();
                towers.Add(a);
            }
            return towers;
        }

    }
}
