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
using Mundo1.Object;
#endregion

namespace Mundo1.Set
{
    public static class Scene
    {
        private static List<Triangle> triangles;

        static Telao telao;
        static Camera camera;
        static GraphicsDevice devicE;

        public static void Initialize(GraphicsDevice device, int screenWidth, int screeHeight)
        {
            devicE = device;

            telao = Telao.GetInstance();
            telao.SetWidth(screenWidth);
            telao.SetHeight(screeHeight);

            camera = new Camera();

            triangles = new List<Triangle>();

            triangles.Add(new Triangle(
                device,
                new Vector3(3, 1, 0),
                new Vector3(3, -1, 0),
                new Vector3(-3, -1, 0),
                Color.Red));

            triangles.Add(new Triangle(
                device,
                new Vector3(-3, 1, 0),
                new Vector3(3, 1, 0),
                new Vector3(-3, -1, 0),
                Color.Red));

            triangles.Add(new Triangle(
                device,
                new Vector3(0.5f, -1, 0),
                new Vector3(3, -1, 0),
                new Vector3(3, -4, 0),
                Color.Red));

            triangles.Add(new Triangle(
                device,
                new Vector3(0.5f, -1, 0),
                new Vector3(3, -4, 0),
                new Vector3(0.5f, -4, 0),
                Color.Red));

            triangles.Add(new Triangle(
                device,
                new Vector3(-3, -1, 0),
                new Vector3(-2, -1, 0),
                new Vector3(-3, -4, 0),
                Color.Red));

            triangles.Add(new Triangle(
                device,
                new Vector3(-3, -4, 0),
                new Vector3(-2, -1, 0),
                new Vector3(-2, -4, 0),
                Color.Red));
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
