using System.Collections.Generic;
using System.Linq;

namespace Day7
{
    public class Towers
    {
        public List<Tower> TowersList { get; set; }

        public Towers(List<string[]> rawTowers)
        {
            TowersList = new List<Tower>();
            foreach (var a in rawTowers)
            {
                TowersList.Add(new Tower(a));
            }

        }

        public List<int> FindSupportedTowers(Tower t)
        {
            var indices = new List<int>();
            var lookups = t.TowersISupport;
            foreach(var lookup in lookups)
            {
                indices.Add(TowersList.FindIndex(n => n.Name == lookup.Name));
            }
            return indices;
        }

        public void AddSupportedTowers(Tower t)
        {
            var supportedTowers = FindSupportedTowers(t);
            foreach(var index in supportedTowers)
            {
                string name = TowersList[index].Name;
                t.TowersISupport.RemoveAll(a => a.Name == name);
                if (TowersList[index].IsSupporting)
                    AddSupportedTowers(TowersList[index]);

                t.TowersISupport.Add(TowersList[index]);
                t.Weight += TowersList[index].Weight;

                TowersList[index].Remove = true;
            }
            
        }

            
    }
}
