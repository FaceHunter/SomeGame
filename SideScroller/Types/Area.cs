using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SideScroller.Types
{
    class Area
    {
        public float XBegin;
        public float YBegin;
        public float XEnd;
        public float YEnd;

        public Area(float Xbegin, float Ybegin, float Xend, float Yend)
        {
            XBegin = Xbegin;
            YBegin = Ybegin;
            XEnd = Xend;
            YEnd = Yend;
        }

        public Area(Vector4 vector)
        {
            XBegin = vector.X;
            YBegin = vector.Y;
            XEnd = vector.X + vector.W;
            YEnd = vector.Y + vector.Z;
        }

        public Area(Vector2 begin, Vector2 end)
        {
            XBegin = begin.X;
            YBegin = begin.Y;
            XEnd = end.X;
            YEnd = end.Y;
        }

        public bool CheckIfInside(Point point)
        {
            return ((point.X >= XBegin) && (point.X <= XEnd) && (point.Y >= YBegin) && (point.Y <= YEnd));
        }
    }
}
