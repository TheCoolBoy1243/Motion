using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motion
{
    class PinkBall : Ball
    {
        public Vector2 gravity;

        public PinkBall() : base("PinkSoftColorBall", new Vector2(0 + 30, GameEnvironment.Screen.Y - 30), new Vector2(100, -100), 30)
        {
            gravity = new Vector2(0, 10);
        }

        public override void Update(GameTime gameTime)
        {
            velocity += gravity;
            base.Update(gameTime);
        }
    }
}
