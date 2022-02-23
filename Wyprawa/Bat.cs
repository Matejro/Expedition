using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    class Bat:Enemy 
    {
        public Bat(Game game, Point location) : base(game, location, 6)
        {}
        public override void Move(Random random)
        {
            if (base.HitPoints>=1)
            {
                int number = random.Next(1, 3);
                if (number == 1)
                {
                    base.location = Move((Direction)random.Next(1,4),game.Boundaries);
                }
                else
                {
                    base.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                }

                if (NearPlayer())
                {
                    game.HitPlayer(2, random);
                }
            }
            
        }
    }
    
}
