using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    class BluePotion : Weapon, IPotion
    {
        public bool Used { get; private set; }
        public BluePotion(Game game, Point location) : base(game, location)
        {
            Used = false;
        }

        public override string Name { get { return "Niebieska mikstura"; } }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(5, random);
            Used = true;
        }
    }
}
