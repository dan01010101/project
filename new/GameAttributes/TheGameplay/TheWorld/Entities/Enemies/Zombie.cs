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
    public class Zombie : TheEnemy
    {

        public Zombie(Vector2 POS, int OWNERID)
            : base("Zombie1", POS, new Vector2(28, 28), OWNERID)
        {
            speed = 1.7f;
        }

        public override void Update(Vector2 OFFSET, Player ENEMY)
        {


            base.Update(OFFSET, ENEMY);
        }

        public override void Draw(Vector2 OFFSET)
        {
            base.Draw(OFFSET);
        }
    }
}
