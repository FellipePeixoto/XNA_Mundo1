#region using
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Mundo1.Set;
#endregion

namespace Mundo1.Object
{
    class Quad
    {
        Triangle a;
        Triangle b;

        public Quad(GraphicsDevice device, Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4, Color color)
        {
            a = new Triangle(device, p1, p2, p3, color);
            b = new Triangle(device, p3, p2, p4, color);
        }

        public void Draw(Camera camera)
        {
            a.Draw(camera);
            b.Draw(camera);
        }
    }
}
