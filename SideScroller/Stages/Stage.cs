using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SideScroller.Stages
{
    abstract class Stage
    {
        public abstract void Update(GameTime gametime);
        public abstract void Draw(SpriteBatch batch);
        public abstract void Load(ContentManager content);
        public abstract void Unload();
    }
}
