using System;

namespace Hotwist.Dominio.Interfaces
{
    [Flags]
    public enum Posição
    {
        Superior,
        Inferior,
        Esquerdo,
        Direito,
        Centro
    }
}