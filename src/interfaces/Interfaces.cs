using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Arcanists
{

    public interface IUpdatable
    {
        void Update(GameTime time);
    }

    public interface IDrawable
    {
        Texture2D Texture { get; set; }
        Vector2 Position { get; set; }
        void Draw(GameTime time, SpriteBatch batch, GraphicsDeviceManager device);
    }

    public interface ICollidable
    {
        Rectangle BoundingBox { get; set; }
    }

    public interface IControllable
    {
        Dictionary<Keys, Action> OnKeyAction { get; set; }
    }
}