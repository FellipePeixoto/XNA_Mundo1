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
            this.world = Matrix.Identity;

            this.verts[0] = new VertexPositionColor(p1, color);
            this.verts[1] = new VertexPositionColor(p2, color);
            this.verts[2] = new VertexPositionColor(p3, color);

            this.vertexBuffer = new VertexBuffer(device, typeof(VertexPositionColor), verts.Length, BufferUsage.None);
            this.vertexBuffer.SetData<VertexPositionColor>(verts);

            this.effect = new BasicEffect(this.device);
        }

        public virtual void Draw(Camera camera)
        {
            RasterizerState rs = new RasterizerState();
            rs.CullMode = CullMode.None;
            this.device.RasterizerState = rs;

            this.device.SetVertexBuffer(this.vertexBuffer);

            this.effect.World = this.world;
            this.effect.View = camera.GetView();
            this.effect.Projection = camera.GetProjection();
            this.effect.VertexColorEnabled = true;

            foreach (EffectPass i in this.effect.CurrentTechnique.Passes)
            {
                i.Apply();
                this.device.DrawUserPrimitives<VertexPositionColor>(PrimitiveType.TriangleStrip, verts, 0, 1);
            }
        }
    }
}
