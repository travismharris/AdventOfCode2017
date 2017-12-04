using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] test = new string[]{"aa", "bb", "cc", "dd", "ee"};
            //string[] test1 = new string[] { "aa", "bb", "cc", "dd", "aa" };
            //string[] test2 = new string[] { "aa", "bb", "cc", "dd", "aaa" };

            //var passPhrases = new List<string[]>(){test, test1, test2 };
            var passPhrases = LoadPuzzle(@"..\Input\Day4Input.txt");
            //var acceptablePassPhrases = CheckCharacters(passPhrases);
            var acceptablePassPhrases = new List<string[]>();
            foreach (var phrase in passPhrases)
            {
                if (!CheckPhrase(phrase))
                {
                    acceptablePassPhrases.Add(phrase);
                }
            }

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

        public static bool CheckPhrase(string[] phrases)
        {
            bool remove = false;
            for (int i = 0; i < phrases.Length; i++)
            {
                var checkPhraseArray = phrases[i].ToCharArray();
                Array.Sort(checkPhraseArray);
                var checkPhrase = new string(checkPhraseArray);
                for (int j = i + 1; j < phrases.Length; j++)
                {
                    var internalPhraseArray = phrases[j].ToCharArray();
                    Array.Sort(internalPhraseArray);
                    var internalPhrase = new string(internalPhraseArray);
                    if (checkPhrase == internalPhrase)
                    {
                        remove = true;
                        break;
                    }
                }
                if (remove)
                    break;
            }
            return remove;
        }

    }
}
