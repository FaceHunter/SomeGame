using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using SideScroller.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SideScroller
{
    class InputManager
    {
        private static Dictionary<Keys, List<Action>> KeyListeners = new Dictionary<Keys, List<Action>>();
        private static Dictionary<Area, Action<MouseEvent>> MouseListeners = new Dictionary<Area, Action<MouseEvent>>();

        public static void AddKeyHandler(Keys key, Action Handler)
        {
            
            if(!KeyListeners.ContainsKey(key))
            {
                KeyListeners.Add(key, new List<Action>() { Handler });
            }
            else
            {
                KeyListeners[key].Add(Handler);
            }
        }

        public static void AddMouseHandler(Area area, Action<MouseEvent> action)
        {
            MouseListeners.Add(area, action);
        }

        public static void Update(GameTime gametime)
        {
            #region KeyBoard
            List<Keys> pressed = Keyboard.GetState().GetPressedKeys().ToList();
            if (pressed.Count != 0)
            {
                Log.Data("Keys pressed: " + string.Join(", ", pressed));

                foreach (Keys key in pressed)
                {
                    if (KeyListeners.ContainsKey(key))
                    {
                        KeyListeners[key].ForEach(func => func.Invoke());
                    }
                }
            }
            #endregion

            #region Mouse
            Point pos = Mouse.GetState().Position;
            bool Click = Mouse.GetState().LeftButton == ButtonState.Pressed;
            foreach (Area area in MouseListeners.Keys)
            {
                if (area.CheckIfInside(pos))
                {
                    MouseListeners[area].Invoke(new MouseEvent() { Location = pos, Type = (Click ? MouseEvent.EventType.Click : MouseEvent.EventType.Hover) });
                }

            }
            #endregion
        }
    }

    class MouseEvent
    {
        public enum EventType
        {
            Hover,
            Click
        }

        public EventType Type;
        public Point Location;
    }
}
