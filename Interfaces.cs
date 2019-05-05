using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Arcanists 
{

    public interface IUpdatable
    {
        void Update(GameTime time);
    }

    public interface Drawable
    {
        Texture2D Texture { get; set; }
        Vector2 Position {get; set;}
        void Draw(GameTime time, SpriteBatch batch, GraphicsDeviceManager device);
    }

    public interface Collidable
    {
        Rectangle BoundingBox { get; set; }
    }
}