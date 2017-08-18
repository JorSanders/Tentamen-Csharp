using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissileCommand
{
    class TitleScreenState : GameObjectList
    {
        public TitleScreenState()
        {
            TextGameObject txt = new TextGameObject("GameFont");
            txt.Text = "Press the left mouse button to (re)start!";
            Add(txt);

        }

        public override void HandleInput(InputHelper inputHelper)
        {
            if (inputHelper.MouseLeftButtonPressed())
                MissileCommand.GameStateManager.SwitchTo("PlayingState");

            base.HandleInput(inputHelper);
        }
    }
}
