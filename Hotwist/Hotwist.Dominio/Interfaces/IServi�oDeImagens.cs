using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Hotwist.Dominio.Interfaces
{
    interface IServiçoDeImagens
    {
        Stream GerarThumbnail(Stream imagemOriginal, Size proporção);
        Stream ColocarLogoAImagem(Stream imagem, Stream logo, Posição posição);
    }
}
