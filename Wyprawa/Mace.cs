using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    class Mace : Weapon
    {
        public Mace(Game game, Point location) : base(game, location) { }
        public override string Name { get { return "Buława"; } }

        public override void Attack(Direction direction, Random random)
        {
            int directionNumber = (int)direction;
            if (!DamageEnemy(direction, 20, 6, random))
            {
                if (!DamageEnemy((Direction)((directionNumber + 1) % 4), 20, 6, random))
                {
                   if(!DamageEnemy((Direction)((directionNumber + 2) % 4), 20, 6, random))
                    {
                        DamageEnemy((Direction)((directionNumber + 3) % 4), 20, 6, random);
                    }
                }
            }
        }
    }
}
