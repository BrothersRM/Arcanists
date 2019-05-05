using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Arcanists
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        GameObjectManager objManager;                
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            objManager = new GameObjectManager();
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            objManager.AddGameObject(new Ball(new Vector2(0, 0)));
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            // TODO: use this.Content to load your game content here
            objManager.LoadGameObjects(this.Content);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            // TODO: Add your update logic here

            objManager.UpdateGameObjects(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            graphics.GraphicsDevice.Clear(Color.CornflowerBlue);

            //GraphicsDevice.Textures[0] = null;
            spriteBatch.Begin();
            objManager.RenderGameObjects( graphics, spriteBatch, gameTime );
            spriteBatch.End();

            base.Draw(gameTime);
        }


    }
}
