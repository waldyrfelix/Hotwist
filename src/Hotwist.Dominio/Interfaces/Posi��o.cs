using System;

namespace Hotwist.Dominio.Interfaces
{
    [Flags]
    public enum Posição
    {
        Superior = 1,
        Inferior = 2,
        Esquerdo = 4,
        Direito  = 8,
        Centro   = 16
    }
}