using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motion
{
    class GreenBall : Ball
    {
        public Vector2 accelaration;
        public GreenBall() : base("GreenSoftColorBall", new Vector2(0 + 30, GameEnvironment.Screen.Y / 2), new Vector2(0, 0), 30)
        {
            accelaration = new Vector2(10, 0);
        }

        public override void Update(GameTime gameTime)
        {
            velocity += accelaration;
            base.Update(gameTime);
        }
    }
}
