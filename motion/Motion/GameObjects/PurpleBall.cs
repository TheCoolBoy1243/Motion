using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motion
{
    class PurpleBall : Ball
    {
        public Vector2 gravity;
        public PurpleBall() : base("PurpleSoftColorBall", new Vector2(GameEnvironment.Screen.X / 2, 0 + 30), new Vector2(0, 0), 30)
        {
            gravity = new Vector2(0, 10);
        }

        public override void Update(GameTime gameTime)
        {
            velocity += gravity;
            if(position.Y > GameEnvironment.Screen.Y - radius)
            {
                velocity *= 0.75f;
            }
            base.Update(gameTime);
        }
    }
}
