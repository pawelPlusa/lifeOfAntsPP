using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeOfAnts
{
    class PopulateMap
    {
        public List<string> allFieldsType = new List<string>();

        public PopulateMap() {
            allFieldsType = PopulateList();
             }

        //public List<string> AllFieldsType { get;  }
        public List<string> PopulateList()
        {
            var dataToPopulate = new Dictionary<string, int>()
            {
            {"drone", 100 },
            {"worker", 600 },
            {"soldier", 300 },
            {"empty", 40615 }
            };
            foreach (KeyValuePair<string, int> kvp in dataToPopulate)
            {

                for (int i = 0; i < kvp.Value; i++)
                {
                    allFieldsType.Add(kvp.Key);
                }
            }
            List<string> shuffledAllFieldsType = allFieldsType.OrderBy(x => Guid.NewGuid()).ToList();
            shuffledAllFieldsType.Insert(20807, "queen");
            //Console.WriteLine(shuffledAllFieldsType.Count());
            return shuffledAllFieldsType;
            

        }


    }
}
