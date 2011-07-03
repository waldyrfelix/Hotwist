using System;
using System.Drawing;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Hotwist.Dominio;
using Hotwist.Dominio.Interfaces;
using NUnit.Framework;

namespace Hotwist.Tests
{
    [TestFixture]
    public class ServiçoDeImagensTest
    {
        [Test]
        public void Quando_Passo_Logo_No_Centro_Devolve_Coordenadas_Do_Centro_Horizontal_E_Vertical()
        {
            // arrange
            IServiçoDeImagens serviçoDeImagens = new ServiçoDeImagens();
            Size tamanhoImagem = new Size(100, 100);
            Size tamanhoLogo = new Size(30, 40);

            // act
            Point coordenadas = serviçoDeImagens.CalcularPosição(Posição.Centro, tamanhoImagem, tamanhoLogo);

            // assert
            Assert.AreEqual(35, coordenadas.X);
            Assert.AreEqual(30, coordenadas.Y);
        }

        [Test]
        public void Quando_Passo_Logo_Em_Cima_Devolve_Coordenadas_Do_Centro_Horizontal_E_Topo_Vertical()
        {
            // arrange
            IServiçoDeImagens serviçoDeImagens = new ServiçoDeImagens();
            Size tamanhoImagem = new Size(150, 120);
            Size tamanhoLogo = new Size(40, 40);

            // act
            Point coordenadas = serviçoDeImagens.CalcularPosição(Posição.Superior, tamanhoImagem, tamanhoLogo);

            // assert
            Assert.AreEqual(55, coordenadas.X);
            Assert.AreEqual(0, coordenadas.Y);
        }

        [Test]
        public void Quando_Passo_Logo_Em_Baixo_Devolve_Coordenadas_Do_Centro_Horizontal_E_Base_Vertical()
        {
            // arrange
            IServiçoDeImagens serviçoDeImagens = new ServiçoDeImagens();
            Size tamanhoImagem = new Size(90, 103);
            Size tamanhoLogo = new Size(20, 40);

            // act
            Point coordenadas = serviçoDeImagens.CalcularPosição(Posição.Inferior, tamanhoImagem, tamanhoLogo);

            // assert
            Assert.AreEqual(35, coordenadas.X);
            Assert.AreEqual(63, coordenadas.Y);
        }

        [Test]
        public void Quando_Passo_Logo_No_Lado_Esquerdo_Devolve_Coordenadas_Da_Esquerda_Horizontal_E_Centro_Vertical()
        {
            // arrange
            IServiçoDeImagens serviçoDeImagens = new ServiçoDeImagens();
            Size tamanhoImagem = new Size(190, 230);
            Size tamanhoLogo = new Size(25, 40);

            // act
            Point coordenadas = serviçoDeImagens.CalcularPosição(Posição.Esquerdo, tamanhoImagem, tamanhoLogo);

            // assert
            Assert.AreEqual(0, coordenadas.X);
            Assert.AreEqual(95, coordenadas.Y);
        }

        [Test]
        public void Quando_Passo_Logo_No_Lado_Direito_Devolve_Coordenadas_Da_Direita_Horizontal_E_Centro_Vertical()
        {
            // arrange
            IServiçoDeImagens serviçoDeImagens = new ServiçoDeImagens();
            Size tamanhoImagem = new Size(190, 230);
            Size tamanhoLogo = new Size(25, 40);

            // act
            Point coordenadas = serviçoDeImagens.CalcularPosição(Posição.Direito, tamanhoImagem, tamanhoLogo);

            // assert
            Assert.AreEqual(165, coordenadas.X);
            Assert.AreEqual(95, coordenadas.Y);
        }

        [Test]
        public void Quando_Passo_Logo_No_Canto_Superior_Esquerdo_Devolve_Coordenadas_Da_Esquerda_Horizontal_E_Topo_Vertical()
        {
            // arrange
            IServiçoDeImagens serviçoDeImagens = new ServiçoDeImagens();
            Size tamanhoImagem = new Size(300, 400);
            Size tamanhoLogo = new Size(30, 30);

            // act
            Point coordenadas = serviçoDeImagens.CalcularPosição(
                Posição.Esquerdo | Posição.Superior, tamanhoImagem, tamanhoLogo);

            // assert
            Assert.AreEqual(0, coordenadas.X);
            Assert.AreEqual(0, coordenadas.Y);
        }

        [Test]
        public void Quando_Passo_Logo_No_Canto_Inferior_Esquerdo_Devolve_Coordenadas_Da_Esquerda_Horizontal_E_Base_Vertical()
        {
            // arrange
            IServiçoDeImagens serviçoDeImagens = new ServiçoDeImagens();
            Size tamanhoImagem = new Size(300, 400);
            Size tamanhoLogo = new Size(30, 30);

            // act
            Point coordenadas = serviçoDeImagens.CalcularPosição(
                Posição.Esquerdo | Posição.Inferior, tamanhoImagem, tamanhoLogo);

            // assert
            Assert.AreEqual(0, coordenadas.X);
            Assert.AreEqual(370, coordenadas.Y);
        }

        [Test]
        public void Quando_Passo_Logo_No_Canto_Inferior_Direito_Devolve_Coordenadas_Da_Direita_Horizontal_E_Base_Vertical()
        {
            // arrange
            IServiçoDeImagens serviçoDeImagens = new ServiçoDeImagens();
            Size tamanhoImagem = new Size(300, 400);
            Size tamanhoLogo = new Size(30, 30);

            // act
            Point coordenadas = serviçoDeImagens.CalcularPosição(
                Posição.Direito | Posição.Inferior, tamanhoImagem, tamanhoLogo);

            // assert
            Assert.AreEqual(270, coordenadas.X);
            Assert.AreEqual(370, coordenadas.Y);
        }

        [Test]
        public void Quando_Passo_Logo_No_Canto_Superior_Direito_Devolve_Coordenadas_Da_Direita_Horizontal_E_Topo_Vertical()
        {
            // arrange
            IServiçoDeImagens serviçoDeImagens = new ServiçoDeImagens();
            Size tamanhoImagem = new Size(300, 400);
            Size tamanhoLogo = new Size(30, 30);

            // act
            Point coordenadas = serviçoDeImagens.CalcularPosição(
                Posição.Direito | Posição.Superior, tamanhoImagem, tamanhoLogo);

            // assert
            Assert.AreEqual(270, coordenadas.X);
            Assert.AreEqual(0, coordenadas.Y);
        }
    }
}
