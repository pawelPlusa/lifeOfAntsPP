using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfAnts.Logic.Actors
{
    class Queen:Ant
    {
        public Queen(Cell cell) : base(cell) { }

        public override bool IsNotPassable => true;

        public override char Symbol => 'Q';

        public override Tuple<int, int> PlanMove()
        {
            throw new NotImplementedException();
        }
        public new bool Move() {
            //instead of move Queen has mood generator
            return true;
        }


    }
}
