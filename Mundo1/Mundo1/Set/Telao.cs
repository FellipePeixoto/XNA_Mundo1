#region a
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
    public class Telao
    {
        private int WIDTH;
        private int HEIGHT;
        private static Telao instance;

        public static Telao GetInstance()
        {
            if (instance == null)
            {
                instance = new Telao();
            }

            return instance;
        }

        public void SetWidth(int width)
        {
            WIDTH = width;
        }

        public int GetWidth()
        {
            return WIDTH;
        }

        public void SetHeight(int height)
        {
            HEIGHT = height;
        }

        public int GetHeight()
        {
            return HEIGHT;
        }
    }
}
