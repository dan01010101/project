using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Nightmare
{
    public class GamePlay
    {
        int playState;

        TheWorld world;

        public GamePlay()
        {
            playState = 0;

            ResetWorld(null);
        }

        public virtual void Update()
        {
            if (playState == 0)
            {
                world.Update();
            }
        }

        public virtual void ResetWorld(object INFO)
        {
            world = new TheWorld(ResetWorld);

        }

        public virtual void Draw()
        {
            if (playState == 0)
            {
                world.Draw(Vector2.Zero);
            }
        }
    }
}
