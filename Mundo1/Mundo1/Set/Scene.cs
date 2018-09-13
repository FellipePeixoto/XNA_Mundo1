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

            camera = new Camera(
                Vector3.Forward * 15 +  Vector3.Right * 15 + Vector3.Up * 15,
                new Vector3(0,-4,0) + Vector3.Left * 2);

            triangles = new List<Triangle>();

            #region Parede Frontal
            Color paredeFrontal = Color.Red;

            triangles.Add(
                    new Triangle(devicE,
                        new Vector3(-1.5f, 1.5f, -3.75f),
                        new Vector3(1.5f, 1.5f, -3.75f),
                        new Vector3(-1.5f, 0.5f, -3.75f),
                        paredeFrontal));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(1.5f, 1.5f, -3.75f),
                    new Vector3(1.5f, 0.5f, -3.75f),
                    new Vector3(-1.5f, 0.5f, -3.75f),
                    paredeFrontal));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(0.65f, 0.5f, -3.75f),
                    new Vector3(1.5f, 0.5f, -3.75f),
                    new Vector3(0.65f, -1.5f, -3.75f),
                    paredeFrontal));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(1.5f, 0.5f, -3.75f),
                    new Vector3(1.5f, -1.5f, -3.75f),
                    new Vector3(0.65f, -1.5f, -3.75f),
                    paredeFrontal));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(-1.5f, 0.5f, -3.75f),
                    new Vector3(-0.65f, 0.5f, -3.75f),
                    new Vector3(-0.65f, -1.5f, -3.75f),
                    paredeFrontal));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(-1.5f, 0.5f, -3.75f),
                    new Vector3(-0.65f, -1.5f, -3.75f),
                    new Vector3(-1.5f, -1.5f, -3.75f),
                    paredeFrontal));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(-1.5f, 1.5f, 3.75f),
                    new Vector3(1.5f, 1.5f, 3.75f),
                    new Vector3(-1.5f, -1.5f, 3.75f),
                    paredeFrontal));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(-1.5f, -1.5f, 3.75f),
                    new Vector3(1.5f, 1.5f, 3.75f),
                    new Vector3(1.5f, -1.5f, 3.75f),
                    paredeFrontal));
            #endregion

            #region Parede direita
            Color paredeDireita = Color.Blue;

            triangles.Add(
                    new Triangle(devicE,
                        new Vector3(-1.5f, 1.5f, 3.75f),
                        new Vector3(-1.5f, 1.5f, -3.75f),
                        new Vector3(-1.5f, 0.5f, -3.75f),
                        paredeDireita));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(-1.5f, 1.5f, 3.75f),
                    new Vector3(-1.5f, 0.5f, -3.75f),
                    new Vector3(-1.5f, 0.5f, 3.75f),
                    paredeDireita));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(-1.5f, -0.2f, 1.1f),
                    new Vector3(-1.5f, 0.5f, 1.1f),
                    new Vector3(-1.5f, 0.5f, -0.75f),
                    paredeDireita));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(-1.5f, -0.2f, 1.1f),
                    new Vector3(-1.5f, 0.5f, -0.75f),
                    new Vector3(-1.5f, -0.2f, -0.75f),
                    paredeDireita));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(-1.5f, -1.5f, 3.75f),
                    new Vector3(-1.5f, -0.2f, 3.75f),
                    new Vector3(-1.5f, -0.2f, -0.75f),
                    paredeDireita));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(-1.5f, -1.5f, 3.75f),
                    new Vector3(-1.5f, 0.2f, -0.75f),
                    new Vector3(-1.5f, -1.5f, -0.75f),
                    paredeDireita));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(-1.5f, -0.2f, 3.75f),
                    new Vector3(-1.5f, 0.5f, 3.75f),
                    new Vector3(-1.5f, 0.5f, 1.8f),
                    paredeDireita));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(-1.5f, -0.2f, 3.75f),
                    new Vector3(-1.5f, 0.5f, 1.8f),
                    new Vector3(-1.5f, -0.2f, 1.8f),
                    paredeDireita));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(-1.5f, -1.5f, -2.75f),
                    new Vector3(-1.5f, 0.5f, -2.75f),
                    new Vector3(-1.5f, 0.5f, -3.75f),
                    paredeDireita));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(-1.5f, -1.5f, -2.75f),
                    new Vector3(-1.5f, 0.5f, -3.75f),
                    new Vector3(-1.5f, -1.5f, -3.75f),
                    paredeDireita));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(-1.5f, -1.5f, -0.75f),
                    new Vector3(-1.5f, -0.5f, -0.75f),
                    new Vector3(-1.5f, -0.5f, -2.75f),
                    paredeDireita));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(-1.5f, -1.5f, -0.75f),
                    new Vector3(-1.5f, -0.5f, -2.75f),
                    new Vector3(-1.5f, -1.5f, -2.75f),
                    paredeDireita));

            #endregion

            #region Parede esquerda
            Color paredeEsquerda = Color.Brown;

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(1.5f, 1.5f, -3.75f),
                    new Vector3(1.5f, 1.5f, 3.75f),
                    new Vector3(1.5f, 0.5f, 3.75f),
                    paredeEsquerda));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(1.5f, 0.5f, -3.75f),
                    new Vector3(1.5f, 1.5f, -3.75f),
                    new Vector3(1.5f, 0.5f, 3.75f),
                    paredeEsquerda));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(1.5f, 0.3f, -1.4f),
                    new Vector3(1.5f, 0.5f, -1.4f),
                    new Vector3(1.5f, 0.5f, 1.1f),
                    paredeEsquerda));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(1.5f, 0.3f, -1.4f),
                    new Vector3(1.5f, 0.5f, 1.1f),
                    new Vector3(1.5f, 0.3f, 1.1f),
                    paredeEsquerda));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(1.5f, -1.5f, -2.1f),
                    new Vector3(1.5f, -0.2f, -2.1f),
                    new Vector3(1.5f, -0.2f, -1.4f),
                    paredeEsquerda));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(1.5f, -1.5f, -2.1f),
                    new Vector3(1.5f, -0.2f, -1.4f),
                    new Vector3(1.5f, -1.5f, -1.4f),
                    paredeEsquerda));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(1.5f, 0.3f, -1.4f),
                    new Vector3(1.5f, 0.3f, 1.8f),
                    new Vector3(1.5f, -1.5f, 1.8f),
                    paredeEsquerda));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(1.5f, 0.3f, -1.4f),
                    new Vector3(1.5f, -1.5f, 1.8f),
                    new Vector3(1.5f, -1.5f, -1.4f),
                    paredeEsquerda));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(1.5f, 0.5f, 1.8f),
                    new Vector3(1.5f, -1.5f, 1.8f),
                    new Vector3(1.5f, -1.5f, 3.75f),
                    paredeEsquerda));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(1.5f, 0.5f, 1.8f),
                    new Vector3(1.5f, 0.5f, 3.75f),
                    new Vector3(1.5f, -1.5f, 3.75f),
                    paredeEsquerda));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(1.5f, 0.5f, -3.75f),
                    new Vector3(1.5f, 0.5f, -2.1f),
                    new Vector3(1.5f, -1.5f, -2.1f),
                    paredeEsquerda)); 
            
            triangles.Add(
                new Triangle(devicE,
                    new Vector3(1.5f, -1.5f, -3.75f),
                    new Vector3(1.5f, 0.5f, -3.75f),
                    new Vector3(1.5f, -1.5f, -2.1f),
                    paredeEsquerda)); 

            #endregion

            #region Teto
            Color teto = Color.Brown;

            triangles.Add(
                    new Triangle(devicE,
                        new Vector3(-1.5f, 1.5f, 3.75f),
                        new Vector3(1.5f, 1.5f, 3.75f),
                        new Vector3(1.5f, 1.5f, -3.75f),
                        teto));

            triangles.Add(
                new Triangle(devicE,
                    new Vector3(-1.5f, 1.5f, 3.75f),
                    new Vector3(1.5f, 1.5f, -3.75f),
                    new Vector3(-1.5f, 1.5f, -3.75f),
                    teto)); 
            #endregion

            #region Chao
            Color chao = Color.Black;

            triangles.Add(
                    new Triangle(devicE,
                        new Vector3(-8.5f, -1.5f, -9),
                        new Vector3(8.5f, -1.5f, -9),
                        new Vector3(8.5f, -1.5f, 9),
                        chao));

            triangles.Add(
                    new Triangle(devicE,
                        new Vector3(-8.5f, -1.5f, -9),
                        new Vector3(-8.5f, -1.5f, 9),
                        new Vector3(8.5f, -1.5f, 9),
                        chao)); 
            #endregion

            #region porta
            Color porta = Color.BlueViolet;

            triangles.Add(
                    new Triangle(devicE,
                        new Vector3(-0.65f, -1.5f, -3.75f),
                        new Vector3(-0.65f, 0.5f, -3.75f),
                        new Vector3(0.65f, 0.5f, -3.75f),
                        porta));

            triangles.Add(
                    new Triangle(devicE,
                        new Vector3(-0.65f, -1.5f, -3.75f),
                        new Vector3(0.65f, -1.5f, -3.75f),
                        new Vector3(0.65f, 0.5f, -3.75f),
                        porta));

            #endregion

            #region janel 2 bandas
            Color janelaBanda = Color.Salmon;

            triangles.Add(
                    new Triangle(devicE,
                        new Vector3(-1.5f, -0.5f, -2.75f),
                        new Vector3(-1.5f, 0.5f, -2.75f),
                        new Vector3(-1.5f, 0.5f, -1.75f),
                        janelaBanda));

            triangles.Add(
                    new Triangle(devicE,
                        new Vector3(-1.5f, -0.5f, -2.75f),
                        new Vector3(-1.5f, -0.5f, -1.75f),
                        new Vector3(-1.5f, 0.5f, -1.75f),
                        janelaBanda));

            triangles.Add(
                    new Triangle(devicE,
                        new Vector3(-1.5f, -0.5f, -1.75f),
                        new Vector3(-1.5f, 0.5f, -1.75f),
                        new Vector3(-1.5f, 0.5f, -0.75f),
                        janelaBanda));

            triangles.Add(
                    new Triangle(devicE,
                        new Vector3(-1.5f, -0.5f, -1.75f),
                        new Vector3(-1.5f, -0.5f,-0.75f),
                        new Vector3(-1.5f, 0.5f, -0.75f),
                        janelaBanda));

            #endregion

            #region Janela q sobe
            Color janelaSobe = Color.RoyalBlue;

            triangles.Add(
                    new Triangle(devicE,
                        new Vector3(-1.5f, -0.2f, 1.1f),
                        new Vector3(-1.5f, 0.5f, 1.1f),
                        new Vector3(-1.5f, 0.5f, 1.8f),
                        janelaBanda));

            triangles.Add(
                    new Triangle(devicE,
                        new Vector3(-1.5f, -0.2f, 1.1f),
                        new Vector3(-1.5f, -0.2f, 1.8f),
                        new Vector3(-1.5f, 0.5f, 1.8f),
                        janelaBanda));

            triangles.Add(
                    new Triangle(devicE,
                        new Vector3(1.5f, 0.5f, -2.1f),
                        new Vector3(1.5f, -0.2f, -2.1f),
                        new Vector3(1.5f, -0.2f, -1.4f),
                        janelaBanda));

            triangles.Add(
                    new Triangle(devicE,
                        new Vector3(1.5f, 0.5f, -2.1f),
                        new Vector3(1.5f, 0.5f, -1.4f),
                        new Vector3(1.5f, -0.2f, -1.4f),
                        janelaBanda));
            #endregion

            #region Basculante
            Color basculante = Color.SeaGreen;

            triangles.Add(
                    new Triangle(devicE,
                        new Vector3(1.5f, .3f, 1.1f),
                        new Vector3(1.5f, 0.5f, 1.1f),
                        new Vector3(1.5f, 0.5f, 1.8f),
                        basculante));

            triangles.Add(
                    new Triangle(devicE,
                        new Vector3(1.5f, .3f, 1.1f),
                        new Vector3(1.5f, 0.3f, 1.8f),
                        new Vector3(1.5f, 0.5f, 1.8f),
                        basculante));
            #endregion
        }

        public static void Draw()
        {
            RasterizerState raster = new RasterizerState();
            raster.CullMode = CullMode.None;
            raster.FillMode = FillMode.WireFrame;
            devicE.RasterizerState = raster;

            foreach (Triangle i in triangles)
            {
                i.Draw(camera);
            }
        }
    }
}
