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

namespace Mundo1.Set
{
    public class Camera
    {
        private Matrix view;
        private Matrix projection;

        private Vector3 position;
        private Vector3 target;
        private Vector3 up;

        public Camera()
        {

            position = Vector3.Backward * 20;
            target = Vector3.Zero;
            up = Vector3.Up;
            SetupView(position, target, up);

            SetupProjection();
        }

        public void SetupView(Vector3 position, Vector3 target, Vector3 up)
        {
            view = Matrix.CreateLookAt(position, target, up);
        }

        public void SetupProjection()
        {
            Telao telao = Telao.GetInstance();

            projection = Matrix.CreatePerspectiveFieldOfView(MathHelper.PiOver4,
                                                                  telao.GetWidth() / (float)telao.GetHeight(),
                                                                  0.0000001f,
                                                                  1000);
        }

        public Matrix GetView()
        {
            return view;
        }

        public Matrix GetProjection()
        {
            return projection;
        }
    }
}
