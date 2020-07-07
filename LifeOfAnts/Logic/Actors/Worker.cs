using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfAnts.Logic.Actors
{
    class Worker:Ant
    {
        public Worker(Cell cell) : base(cell) { }


        public override bool IsNotPassable => true;

        public override char Symbol => 'w';

        public override Tuple<int, int> PlanMove()
        {
            throw new NotImplementedException();
        }
    }
}
