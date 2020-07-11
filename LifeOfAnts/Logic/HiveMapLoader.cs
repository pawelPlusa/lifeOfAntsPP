using LifeOfAnts.Logic.Actors;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfAnts.Logic
{
    public static class HiveMapLoader
    {
        public static HiveMap InitiateMap(int dimensions)
        {

            HiveMap map = new HiveMap(dimensions);
            Cell queenCell = map.GetCell(dimensions / 2, dimensions / 2);
            queenCell.Ant = new Queen(queenCell);
            queenCell.PrintCoords();
            //why i cannot acces queen methods when queenCell.Ant = new Queen(..)
            queenCell.Ant.GenerateAnts(ref map);
            return map;
        }

        public static HiveMap UpdateMap(HiveMap map)
        {
            HiveMap updatedMap = map;
            return updatedMap;
        }

    }
}
