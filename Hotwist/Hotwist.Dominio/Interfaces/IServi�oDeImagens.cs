using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Hotwist.Dominio.Interfaces
{
    public interface IServiçoDeImagens
    {
        Image ColocarLogoAImagem(Image imagem, Image logo, Posição posição);
        Point CalcularPosição(Posição posição, Size tamanhoImage, Size tamanhoLogo);
    }
}
