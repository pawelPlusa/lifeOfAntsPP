using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfAnts
{
    class Cell
    {
        private HiveMap _actualMap;
        public Cell(HiveMap actualMap, int x, int y)
        {
            _actualMap = actualMap;
            X = x;
            Y = y;
        }

        public int  X{ get; set; }
        public int  Y{ get; set; }
        public HiveMap ActualMap { get => _actualMap; }

        public Cell GetNeighbor(int dx, int dy)
        {
            return _actualMap.GetCell(X + dx, Y + dy);
        }

        /// <summary>
        /// Returns a cell in the given distance
        /// </summary>
        /// <returns>The cell</returns>
        /// 
        public Cell GetCell()
        {
            return _actualMap.GetCell(X, Y);
        }
    }
}
