using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using SideScroller.Settings;
using SideScroller.Utilities;
using SideScroller.Types;
using System.Windows.Forms;

namespace SideScroller.Stages.Menu
{
    class Menu : Stage
    {
        public SpriteFont TitleFont;
        public TextButton button;
        public override void Draw(SpriteBatch batch)
        {
            
            string title = Language.GetString("Title");
            batch.DrawString(TitleFont, title, Calculators.CalculateTextLocation(TitleFont, title, 50, 20), Color.Black);
            batch.DrawString(button.Font, button.Text, button.Begin, Color.Green);
        }

        public override void Load(ContentManager content)
        {
            button = new TextButton() { Text = "TestButton" };
           
            button.Font = content.Load<SpriteFont>("Button");
            TitleFont = content.Load<SpriteFont>("TitleFont");

            button.CalcStuff(Calculators.CalculateTextLocation(button.Font, button.Text, 50, 30));

            InputManager.AddMouseHandler(new Area(button.Begin, button.End), MouseHandler);
        }

        private void MouseHandler(MouseEvent obj)
        {
            Cursor.Current = Cursors.Hand;
            if (obj.Type == MouseEvent.EventType.Click)
            {
                Log.Debug("Button pressed!");
                
            }
        }

        public override void Update(GameTime gametime)
        {

        }

        public override void Unload()
        {
            
        }
    }
}
