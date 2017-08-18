using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissileCommand
{
    class Cannon: RotatingSpriteGameObject
    {

        public Cannon()
            :base ("spr_cannon")
        {
            position = new Vector2(384, 504);
            origin = new Vector2(16, 16);
        }
        
    }
}
