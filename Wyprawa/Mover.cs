using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Wyprawa
{
    abstract class Mover
    {
        private const int MoveInterval = 10;
        protected Point location;
        public Point Location { get { return location; } }
        public Game game;

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }

        public bool Nearby(Point locationToCheck, int distance)
        {
            return Nearby(this.location, locationToCheck, distance);            
        }

        public bool Nearby(Point location1, Point location2, int distance)
        {
            if (Math.Abs(location1.X - location2.X) < distance && (Math.Abs(location1.Y - location2.Y) < distance))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Point Move(Direction direction, Rectangle boundaries)
        {
            return Move(direction,this.location,boundaries);
        }
        

        public Point Move(Direction direction, Point target, Rectangle boundaries)
        {
            Point newLocation = target;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y-MoveInterval>=boundaries.Top)
                    {
                        newLocation.Y -= MoveInterval;
                    }
                    break;
                case Direction.Down:
                    if (newLocation.Y+MoveInterval<=boundaries.Bottom)
                    {
                        newLocation.Y += MoveInterval;
                    }
                    break;
                case Direction.Left:
                    if (newLocation.X-MoveInterval>=boundaries.Left)
                    {
                        newLocation.X -= MoveInterval;
                    }
                    break;
                case Direction.Right:
                    if (newLocation.X+MoveInterval<=boundaries.Right)
                    {
                        newLocation.X += MoveInterval;
                    }
                    break;
                default:
                    break;
            }
            return newLocation;
        }
        
    }
}
