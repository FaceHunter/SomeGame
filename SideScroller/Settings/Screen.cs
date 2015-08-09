using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SideScroller.Settings
{
    class Screen
    {
        public static GraphicsDeviceManager graphics;
        public static void SetScreenMetrics(int width, int height, bool fullscreen = false)
        {
            graphics.PreferredBackBufferWidth = width;
            graphics.PreferredBackBufferHeight = height;
            graphics.IsFullScreen = fullscreen;
            graphics.ApplyChanges();
        }
    }
}
