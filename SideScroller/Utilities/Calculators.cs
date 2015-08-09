using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SideScroller.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SideScroller.Utilities
{
    class Calculators
    {
        public static Vector2 CalculateTextLocation(SpriteFont font, string text, int XPercentage, int YPercentage)
        {
            float width = Screen.graphics.PreferredBackBufferWidth;
            width /= 100;
            width *= XPercentage;
            width -= (font.MeasureString(text).X / 2);

            float height = Screen.graphics.PreferredBackBufferHeight;
            height /= 100;
            height *= YPercentage;
            height -= (font.MeasureString(text).X / 2);

            return new Vector2(width, height);
        }
    }
}
