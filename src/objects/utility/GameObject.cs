using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Arcanists
{

    public class GameObjectManager
    {
        public HashSet<GameObject> GameObjects { get; set; }   

        public GameObjectManager()
        {
            GameObjects = new HashSet<GameObject>();
        }
 
        public void AddGameObject(GameObject obj)
        {
            GameObjects.Add(obj);
        }

        public void RemoveGameObject(GameObject obj)
        {
            GameObjects.Remove(obj);
        }

        public void RenderGameObjects(GraphicsDeviceManager device, SpriteBatch batch, GameTime time)
        {
            foreach(GameObject obj in GameObjects)
            {
                obj.Draw(time, batch, device);
            }
        }

        public void UpdateGameObjects(GameTime time)
        {
            foreach(GameObject obj in GameObjects)
            {
                obj.Update(time);
            }
        }

        public void LoadGameObjects(ContentManager content)
        {
            foreach(GameObject obj in GameObjects)
            {
                obj.Load(content);
            }
        }
    }

    public abstract class GameObject : IUpdatable, IDrawable, ICollidable
    {
        public Rectangle BoundingBox { get; set; } = new Rectangle();
        public Texture2D Texture { get; set; }
        public Vector2 Position { get; set; }
        public abstract string SpriteFileName { get; set; }   
        public GameObject(Vector2 position)
        {
            Position = position;
        }

        public abstract void Update(GameTime time);

        public abstract void Draw(GameTime time, SpriteBatch batch, GraphicsDeviceManager device);
        public void Load(ContentManager manager)
        {
            if(!String.IsNullOrEmpty(SpriteFileName))
            {
                try
                {
                    Texture = manager.Load<Texture2D>(SpriteFileName);
                    OnLoad();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }
        protected abstract void OnLoad();
    }
}