using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Arcanists
{
    public class Terrain : GameObject
    {
        public bool[,] Mesh;

        public Terrain(Vector2 position) : base(position)
        {

        }

        public Rectangle Bounds { get; set; }      
        public override string SpriteFileName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public static bool[,] DeformMap(bool[,] map, bool[,] deformation, int topleftx, int toplefty)
        {
            var deformed = map.Clone() as bool[,];
            for(int x = 0; x < deformation.GetLength(0); x++)
            {
                for(int y = 0; y < deformation.GetLength(1); y++)
                {
                    deformed[topleftx + x,toplefty + y] = deformation[x,y];
                }
            }
            return deformed;
        }

        public override void Draw(GameTime time, SpriteBatch batch, GraphicsDeviceManager device)
        {
            throw new NotImplementedException();
        }

        public override void Update(GameTime time)
        {
            throw new NotImplementedException();
        }

        protected override void OnLoad()
        {
            throw new NotImplementedException();
        }
    }
}