using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace MissileCommand
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class MissileCommand : GameEnvironment
    {

        public MissileCommand()
        {
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            screen = new Point(800, 600);
            SetFullScreen(false);
            IsMouseVisible = true;

            // TODO: use this.Content to load your game content here      
            GameStateManager.AddGameState("PlayingState", new PlayingState());
            GameStateManager.AddGameState("TitleScreenState", new TitleScreenState());
            GameStateManager.SwitchTo("TitleScreenState");
        }

    }
}
