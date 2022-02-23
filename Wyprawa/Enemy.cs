using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    abstract class Enemy : Mover
    {
        private const int NearPlayerDistance = 25;
        //protected int hitPoints;
        public int HitPoints { get; private set; }
        public bool Dead 
        { get
            {
                if (HitPoints <= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public Enemy(Game game, Point location, int hitPoints):base(game,location)
        {
            this.HitPoints = hitPoints;
        }

        public abstract void Move(Random random);

        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }

        protected bool NearPlayer()
        {
            return Nearby(game.PlayerLocation, NearPlayerDistance);
        }

        protected Direction FindPlayerDirection(Point playerLocation)
        {
            Direction directiontoMove;
            if (playerLocation.X>location.X+10)
            {
                directiontoMove = Direction.Right;
            }
            else if (playerLocation.X<location.X-10)
            {
                directiontoMove = Direction.Left;
            }
            else if (playerLocation.Y<location.Y-10)
            {
                directiontoMove = Direction.Up;
            }
            else
            {
                directiontoMove = Direction.Down;
            }
            return directiontoMove;
        }

    }
}
