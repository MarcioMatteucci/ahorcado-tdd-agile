using Ahorcado.App;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado.Test
{
    [TestFixture]
    public class TestWord
    {
        // Por ahora todo en la class Game
        /*
        private Word word;

        [SetUp]
        public void init()
        {
            word = new Word();
        }

        [TestCase("probando", ExpectedResult = 8)]
        [TestCase("probandoo", ExpectedResult = 9)]
        [TestCase("probandooo", ExpectedResult = 10)]
        [TestCase("probandoooo", ExpectedResult = 11)]
        public int Get_Cant_De_Letras(string palabra)
        {
            return word.getCantCaracteres(palabra);
        }

        [TestCase("probando", "p", ExpectedResult = true)]
        [TestCase("probando", "o", ExpectedResult = true)]
        [TestCase("probando", "z", ExpectedResult = false)]
        [TestCase("probando", "w", ExpectedResult = false)]
        public bool Pertenece_Letra_En_Palabra(string palabra, string letra)
        {
            return word.guardarLetraAcertada(palabra, letra);
        }

       /* [TestCase("probando", , ExpectedResult = true)]
        public bool Test_palabraAcertada(string palabra, ArrayList letras)
        {
            return word.palabraAcertada(palabra, letras);
        }        
        */


    }
}
