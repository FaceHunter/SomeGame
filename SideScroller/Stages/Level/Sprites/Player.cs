using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SideScroller.Stages.Level.Sprites
{
    class Player : Sprite
    {
        public int X;
        public int Y;

        public int Size = 50;

        public Player(GraphicsDevice device)
        {
            shape = Shapes.GetCircle(device, Size);
            X = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 2;
            Y = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2;
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gametime)
        {
            spriteBatch.Draw(shape, new Rectangle(X - Size, Y - Size, Size, Size), Color.Blue);
        }

        public override void Load(ContentManager content)
        {
            
        }

        public override void Update(GameTime gametime)
        {
            
        }
    }
}
