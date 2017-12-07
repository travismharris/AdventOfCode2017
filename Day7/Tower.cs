using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class Tower
    {
        public string Name { get; set; }

        public int Weight { get; set; }

        public List<Tower> TowersISupport = new List<Tower>();

        public bool IsSupporting { get; set; }

        public bool Remove { get; set; }

        public Tower(string[] rawTowerData)
        {
            Name = rawTowerData[0];
            AssignWeight(rawTowerData[1]);
            Remove = false;
            if (rawTowerData.Length > 2)
            {
                IsSupporting = true;
                for (int i = 3; i < rawTowerData.Length; i++)
                    AssignTowersISupport(rawTowerData[i]);
            }

        }


        public Tower(string name)
        {
            if(name.Contains(","))
                name = name.Remove(name.IndexOf(','), 1);

            this.Name = name;
        }

        public void AssignWeight(string weight)
        {
            weight = weight.Remove(weight.IndexOf('('), 1);
            weight = weight.Remove(weight.IndexOf(')'), 1);
            
            Weight = int.Parse(weight);
        }

        public void AssignTowersISupport(string tower)
        {
            TowersISupport.Add(new Tower(tower));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Name: ");
            sb.Append(Name);
            sb.Append("  Weight: ");
            sb.Append(Weight);
            sb.Append("  Supporting ");
            sb.Append(TowersISupport.Count);

            return sb.ToString();
        }

    }
}
