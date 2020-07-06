using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfAnts.Logic.Actors
{
    public abstract class Actor:IDrawable
    {

        public Cell Cell { get; protected set; }
        public Actor(Cell cell)
        {
            Cell = cell;
            Cell.Actor = this;
        }
       

        public abstract bool IsNotPassable { get; }

        /// <summary>
        /// Gets the X position
        /// </summary>
        public int X => Cell.X;

        /// <summary>
        /// Gets the Y position
        /// </summary>
        public int Y => Cell.Y;

        public string Tilename => "actor";
    }
}
