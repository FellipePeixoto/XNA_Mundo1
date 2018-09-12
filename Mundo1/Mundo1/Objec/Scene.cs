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
#endregion

namespace WindowsGame1.Objec
{
    public static class Scene
    {
        private static List<Triangle> triangles;

        static Telao telao;
        static Camera camera;

        public static void Initialize(GraphicsDevice device, int screenWidth, int screeHeight)
        {
            camera = new Camera();
            telao = new Telao();

            telao.SetWidth(screenWidth);
            telao.SetHeight(screeHeight);

            triangles = new List<Triangle>();

            triangles.Add(new Triangle(
                device,
                new Vector3(0, 1, 0),
                new Vector3(-1, -1, 0),
                new Vector3(1, -1, 0), Color.Red));

            //new Vector3(0.0f, 1.0f, 0.0f), Color.Red),
            //new Vector3(-1.0f, -1.0f, 0.0f), Color.Red),
            //new Vector3(1.0f, -1.0f, 0.0f), Color.Red)
        }

        public static void Draw()
        {
            foreach (Triangle i in triangles)
            {
                i.Draw(camera);
            }
        }
    }
}
