using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location):base(game,location){}
        public override string Name { get { return "Miecz"; } }
        public override void Attack(Direction direction, Random random)
        {
            int directionNumber = (int)direction;
            if (!DamageEnemy(direction, 10,3,random))
            {
                if (!DamageEnemy((Direction)((directionNumber+1)%4), 10, 3, random))
                {
                    DamageEnemy((Direction)((directionNumber+2)%4),10,3,random);
                }
            }
        }

    }
}
