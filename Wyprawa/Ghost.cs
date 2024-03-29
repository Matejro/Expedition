﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    class Ghost:Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 8)
        { }
        public override void Move(Random random)
        {
            if (base.HitPoints >= 1)
            {
                int number = random.Next(1,4);
                if (number == 1 || number ==2)
                {}
                else 
                {
                    base.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                }

                if (NearPlayer())
                {
                    game.HitPlayer(3, random);
                }
            }

        }



    }
}
