using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using Hotwist.Dominio.Interfaces;

namespace Hotwist.Dominio
{
    public class ServiçoDeImagens : IServiçoDeImagens
    {
        #region Implementation of IServiçoDeImagens

        public Image ColocarLogoAImagem(Image imagem, Image logo, Posição posição)
        {
            using (Graphics g = Graphics.FromImage(imagem))
            {
                Point coordenadas = CalcularPosição(posição, imagem.Size, logo.Size);
                g.DrawImage(logo, new Rectangle(coordenadas, logo.Size));
                g.Save();
            }

            return imagem;
        }

        public Point CalcularPosição(Posição posição, Size tamanhoImage, Size tamanhoLogo)
        {
            int largura, altura;

            // calcula posição do Y
            if ((posição & Posição.Superior) == Posição.Superior)
                altura = 0;
            else if ((posição & Posição.Inferior) == Posição.Inferior)
                altura = tamanhoImage.Height - tamanhoLogo.Height;
            else
                altura = (tamanhoImage.Height / 2) - (tamanhoLogo.Height / 2);

            // calcula posição do X
            if ((posição & Posição.Esquerdo) == Posição.Esquerdo)
                largura = 0;
            else if ((posição & Posição.Direito) == Posição.Direito)
                largura = tamanhoImage.Width - tamanhoLogo.Width;
            else
                largura = (tamanhoImage.Width / 2) - (tamanhoLogo.Width / 2);
            

            return new Point(new Size(largura,altura));
        }

        #endregion
    }
}
