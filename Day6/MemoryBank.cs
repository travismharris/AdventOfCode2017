using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class MemoryBank
    {
        private int[] banks;
        private List<string> history = new List<string>();

        public MemoryBank(int[] array)
        {
            this.banks = array;
            history.Add(this.ToString());
        }

        public void BalanceMemory()
        {
            var done = false;
            var hops = 0;
            //var max = banks.Max();
            //int indexOfFirstMax = GetIndexOfFirstMax(max);
            int occurence1 = 0;
            int occurence2 = 0;

            while (!done)
            {

                var max = banks.Max();
                var indexOfFirstMax = GetIndexOfFirstMax(max);
                hops++;
                Redistribute(max, indexOfFirstMax);
                var newHistoryEntry = this.ToString();

                if (newHistoryEntry == "0 14 13 12 11 10 8 8 6 6 5 3 3 2 1 10 " && !history.Contains(newHistoryEntry))
                {
                    Console.WriteLine("First occurrence of offending value,\t" + this + ", at " + (hops) + " hops.");
                    occurence1 = hops;
                }
                if (history.Contains(newHistoryEntry))
                {
                    Console.WriteLine("Reoccurence of offending value,\t\t" + this + ", at " + (hops) + " hops.");
                    occurence2 = hops;
                    done = true;
                    Console.WriteLine("There were " + (occurence2 - occurence1) + " iterations between occurences.");
                }

                history.Add(newHistoryEntry);
            }
            
        }

        public int GetIndexOfFirstMax(int max)
        {
            int indexOfFirstMax = 0;
            for (int i = 0; i < banks.Count(); i++)
            {
                if (banks[i] == max)
                {
                    indexOfFirstMax = i;
                    break;
                }
            }
            return indexOfFirstMax;
        }

        public void Redistribute(int max, int index)
        {
            var numberToDistribute = max;
            banks[index] = 0;
            while (max > 0)
            {                
                if (index == 15)
                    index = 0;
                else
                    index++;

                banks[index] = banks[index] + 1;
                
                max--;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (int a in banks)
            {
                sb.Append(a + " ");
            }
            return sb.ToString();
        }
    }
}
