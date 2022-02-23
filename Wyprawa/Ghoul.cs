using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location) : base(game, location, 10)
        {}
        public override void Move(Random random)
        {
            if (base.HitPoints >= 1)
            {
                int number = random.Next(1, 4);
                if (number == 1 || number == 2)
                {
                    base.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                }
                else
                {}

                if (NearPlayer())
                {
                    game.HitPlayer(4, random);
                }
            }

        }
    }
}
