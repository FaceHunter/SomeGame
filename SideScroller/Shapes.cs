using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SideScroller
{
    enum EShapes
    {
        Pixel,
        Circle
    }

    class Shapes
    {
        public static Shape GetPixel(GraphicsDevice device)
        {
            Shape pixel = new Shape(device, 1, 1, EShapes.Pixel);
            pixel.SetData(new Color[] { Color.Black });
            return pixel;
        }

        public static Shape GetCircle(GraphicsDevice device, int radius)
        {
            Shape texture = new Shape(device, radius, radius, EShapes.Circle);
            Color[] colorData = new Color[radius * radius];

            float diam = radius / 2f;
            float diamsq = diam * diam;

            for (int x = 0; x < radius; x++)
            {
                for (int y = 0; y < radius; y++)
                {
                    int index = x * radius + y;
                    Vector2 pos = new Vector2(x - diam, y - diam);
                    if (pos.LengthSquared() <= diamsq)
                    {
                        colorData[index] = Color.White;
                    }
                    else
                    {
                        colorData[index] = Color.Transparent;
                    }
                }
            }

            texture.SetData(colorData);
            return texture;
        }
    }

    class Shape : Texture2D
    {
        public EShapes ShapeType;
        public Shape(GraphicsDevice device, int width, int height, EShapes shapetype) : base(device, width, height)
        {
            ShapeType = shapetype;
        }
    }
}
