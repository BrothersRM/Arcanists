using System;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Arcanists
{
    public class Ball : GameObject
    {
        public Ball(Vector2 position) : base(position)
        {
        }

        public override void Draw(GameTime time, SpriteBatch batch, GraphicsDeviceManager device)
        {
            batch.Draw(Texture, BoundingBox, Color.White);
        }

        public override void Update(GameTime time)
        {
            var state = Keyboard.GetState();
            if(state.IsKeyDown(Keys.W))
            {
                Position = new Vector2(Position.X, Position.Y - 3);
            }
            if( state.IsKeyDown(Keys.A) )
            {
                Position = new Vector2(Position.X - 3, Position.Y);
            }
            if(state.IsKeyDown(Keys.S))
            {
                Position = new Vector2(Position.X, Position.Y + 3);
            }
            if(state.IsKeyDown(Keys.D))
            {
                Position = new Vector2(Position.X + 3, Position.Y);
            }

            BoundingBox = new Rectangle((int)Position.X, (int)Position.Y, BoundingBox.Width, BoundingBox.Height);

        }

        public override void Load(ContentManager content)
        {
            Texture = content.Load<Texture2D>(@"sprites\circle");
            BoundingBox = new Rectangle((int)Position.X, (int)Position.Y, Texture.Width, Texture.Height);
        }
    }
}