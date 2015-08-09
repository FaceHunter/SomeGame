using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace SideScroller.Stages
{
    abstract class Sprite
    {
        public Shape shape;
        public abstract void Load(ContentManager content);
        public abstract void Draw(SpriteBatch spriteBatch, GameTime gametime);
        public abstract void Update(GameTime gametime);
    }
}
