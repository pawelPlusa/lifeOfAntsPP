using System;

namespace LifeOfAnts
{
    public class Program
    {
        private HiveMap _map;
        private int roundCounter;

        public static void Main()
        {
            new Program();
        }

        private Program()
        {
            PopulateMap test1 = new PopulateMap();
            //foreach(string test111 in test1.allFieldsType)
            //{
            //    Console.WriteLine(test111);
            //}
            //_map = new HiveMap(203,203);

        }
    }
}
