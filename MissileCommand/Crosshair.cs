using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissileCommand
{
    class Crosshair : SpriteGameObject
    {
        public Crosshair()
        : base("spr_crosshair")
        {
            this.origin = this.Center;
        }

        public override void HandleInput(InputHelper inputHelper)
        {

            position = inputHelper.MousePosition;
            base.HandleInput(inputHelper);
        }

    }
}
