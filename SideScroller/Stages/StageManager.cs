using SideScroller.Stages.Level.Sprites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace SideScroller.Stages
{
    class StageManager
    {
        public static Dictionary<string, Stage> Stages = new Dictionary<string, Stage>();
        public static Stage CurrentStage;

        private static bool Loaded;

        public static void Initialize()
        {
            Stages.Add("menu", new Menu.Menu());
        }

        public static void LoadStage(string StageName, ContentManager content)
        {
            if(!Stages.ContainsKey(StageName))
            {
                Log.Error("Tried to load a not existing stage :\\");
                throw new Exception("Tried to load a not existing stage");
            }
            CurrentStage = Stages[StageName];
            CurrentStage.Load(content);
            
        }

        public static void UnloadStage(string StageName)
        {
            CurrentStage.Unload();
        }

        internal static void Update(GameTime gameTime)
        {

            CurrentStage.Update(gameTime);
        }

        internal static void Draw(SpriteBatch batch)
        {

            CurrentStage.Draw(batch);
        }

        internal static void Load(ContentManager content)
        {
            CurrentStage.Load(content);
            Loaded = true;

        }
    }
}
