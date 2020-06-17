using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfAnts
{
    class HiveMap
    {
        private readonly Cell[,] _cells;
        public HiveMap(int width, int height)
        {
            Width = width;
            Height = height;
            _cells = new Cell[width, height];
            for (var x = 0; x < width; x++)
            {
                for (var y = 0; y < height; y++)
                {
                    _cells[x, y] = new Cell(this, x, y);
                }
            }
        }
        public Cell GetCell(int x, int y) => _cells[x, y];
        public int Width { get; }
        public int Height { get; }
    }

}
