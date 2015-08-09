using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SideScroller.Types
{
    class TextButton
    {
        public SpriteFont Font;
        public Vector2 Begin;
        public Vector2 End;
        public string Text;

        public void CalcStuff(Vector2 begin)
        {
            Begin = begin;
            End = begin + Font.MeasureString(Text);
        }
    }
}
