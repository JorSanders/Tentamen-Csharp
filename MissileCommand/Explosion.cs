using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissileCommand
{
    class Explosion: SpriteGameObject
    {
        int explosionDuration;

        public Explosion()
            :base ("spr_explosion")
        {
            this.Origin = this.Center;
            Visible = false;
        }

        public void Detonate(Vector2 position)
        {
            this.position = position;
            explosionDuration = 60;
            visible = true;
        }

        public override void Update(GameTime gameTime)
        {
               base.Update(gameTime);
               explosionDuration--;

               if (explosionDuration <= 0)
               {
                   visible = false;
               }
        }

    }
}
