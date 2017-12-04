using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            var passPhrases = LoadPuzzle(@"..\Input\Day4Input.txt");
            var acceptablePassPhrases = CheckCharacters(passPhrases);

            Console.WriteLine("Was " + passPhrases.Count + " now " + acceptablePassPhrases.Count);
            Console.ReadKey();
        }

        public static List<string[]> LoadPuzzle(string fileName)
        {
            List<string[]> passPhraseList = new List<string[]>();
            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                var a = line.Split();
                passPhraseList.Add(a);
            }
            return passPhraseList;
        }

        public static List<string[]> CheckCharacters(List<string[]> checkCharacters)
        {
            var goodChars = new List<string[]>();
            bool containsAtLeastOneUppercase = false;
            foreach(var part in checkCharacters)
            {
                foreach(var inner in part)
                {
                    if (inner.Any(char.IsUpper))
                    {
                        containsAtLeastOneUppercase = true;
                    }
                }
                if(!containsAtLeastOneUppercase)
                {
                    goodChars.Add(part);
                }
            }

            return goodChars;
        }

    }
}
