using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissileCommand
{
    class Missile: SpriteGameObject
    {
        public Missile(String assetName, Vector2 position, Vector2 velocity)
            :base (assetName)
        {
 
            this.position = position;
            this.velocity = velocity;
            //sprite = new SpriteSheet(assetName);
        }
    }
}
