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

            var towers = new Towers(rawTowerStringList);

            for (int i = 0; i < towers.TowersList.Count; i++)
            {
                if (towers.TowersList[i].IsSupporting)
                    towers.AddSupportedTowers(towers.TowersList[i]);
            }

            for(int i = towers.TowersList.Count-1; i >= 0; i--)
            {
                if (towers.TowersList[i].Remove)
                {
                    towers.TowersList.RemoveAt(i);
                }
            }

            Console.WriteLine("The program at the bottom is " + towers.TowersList[0].Name);

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
