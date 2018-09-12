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
    class Triangle
    {
        protected GraphicsDevice device;
        protected Matrix world;
        VertexPositionColor[] verts = new VertexPositionColor[3];
        VertexBuffer vertexBuffer;
        BasicEffect effect;

        public Triangle(GraphicsDevice device, Vector3 p1, Vector3 p2, Vector3 p3, Color color)
        {
            this.device = device;
            world = Matrix.Identity;

            verts[0] = new VertexPositionColor(p1, color);
            verts[1] = new VertexPositionColor(p2, color);
            verts[2] = new VertexPositionColor(p3, color);

            vertexBuffer = new VertexBuffer(device, typeof(VertexPositionColor), verts.Length, BufferUsage.WriteOnly);
            vertexBuffer.SetData<VertexPositionColor>(verts);

            effect = new BasicEffect(this.device);
        }

        public virtual void Draw(Camera camera)
        {
            device.SetVertexBuffer(this.vertexBuffer);

            effect.World = world;
            effect.View = camera.GetView();
            effect.Projection = camera.GetProjection();
            effect.VertexColorEnabled = true;

            foreach (EffectPass i in this.effect.CurrentTechnique.Passes)
            {
                i.Apply();
                this.device.DrawUserPrimitives<VertexPositionColor>(PrimitiveType.TriangleStrip, verts, 0, 1);
            }
        }
    }
}
