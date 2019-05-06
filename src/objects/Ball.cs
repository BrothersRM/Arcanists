using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Arcanists
{
    public class Ball : DrawableGameComponent
    {
        public Dictionary<Keys, Action> OnKeyAction { get; set; }


        public Ball(Game game) : base(game)
        {
            
        }
    }
}