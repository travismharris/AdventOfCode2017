using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class Tower
    {
        private string name;
        private int weight;
        private List<Tower> towersISupport = new List<Tower>();
        private bool isSupporting;

        public Tower(string[] rawTowerData)
        {
            this.name = rawTowerData[0];
            AssignWeight(rawTowerData[1]);
            if (rawTowerData.Length > 2)
            {
                this.isSupporting = true;
                for (int i = 3; i < rawTowerData.Length; i++)
                    AssignTowersISupport(rawTowerData[i]);
            }

        }

        public Tower(string name)
        {
            this.name = name;
        }

        public void AssignWeight(string weight)
        {
            weight = weight.Remove(weight.IndexOf('('), 1);
            weight = weight.Remove(weight.IndexOf(')'), 1);
            
            this.weight = int.Parse(weight);
        }

        public void AssignTowersISupport(string tower)
        {
            towersISupport.Add(new Tower(tower));
        }

    }
}
