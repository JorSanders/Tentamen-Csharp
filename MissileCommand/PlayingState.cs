using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissileCommand
{
    class PlayingState: GameObjectList
    {
        SpriteGameObject background = new SpriteGameObject("spr_background", 0, "background");
        Cannon cannon = new Cannon();
        Crosshair crosshair = new Crosshair();
        GameObjectList friendlyMissiles = new GameObjectList();
        GameObjectList enemyMissiles = new GameObjectList();
        Explosion explosion = new Explosion();
        Score score = new Score();

        public int ScoreGotten { get; private set; }

        Random random = new Random();

        public PlayingState()
        {
            ScoreGotten = 0;

            this.Add(background);
            this.Add(cannon);
            this.Add(crosshair);
            this.Add(explosion);
            this.Add(score);
            this.Add(friendlyMissiles);
            this.Add(enemyMissiles);
            

            for (int i = 0; i < 50; i++)
            {
                enemyMissiles.Add(new Missile(
                    "spr_dotred",
                    new Vector2(random.Next(0, 800), random.Next(-1000, -10)), 
                    new Vector2(random.Next(-10, 10), 30)));
            }
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            if (inputHelper.MouseLeftButtonDown())
            {
               
               friendlyMissiles.Add(new Missile("spr_dotgreen", cannon.Position, cannon.AngularDirection*200));
            }

            base.HandleInput(inputHelper);
        }

        public override void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {
            base.Update(gameTime);

            cannon.LookAt(crosshair);


            foreach (Missile eMissile in enemyMissiles.Objects)
            {
                foreach (Missile fMissile in friendlyMissiles.Objects)
                {
                    if(fMissile.CollidesWith(eMissile))
                    {
                        explosion.Detonate(eMissile.Position);
                    }                    
                }
                if (eMissile.CollidesWith(explosion))
                {
                    eMissile.Visible = false;
                    ScoreGotten += 10;
                }
            }
            score.ScoreAmount = ScoreGotten;
        }

            
    

    }
}
