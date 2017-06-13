using Ahorcado.App;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado.Test
{
    [TestFixture]
    public class TestGame
    {
        Game game = new Game();

        [SetUp]
        public void init()
        {
            game = new Game();
        }

        [TestCase("palabratest", ExpectedResult = true)]
        [TestCase("palabratestt", ExpectedResult = false)]
        public bool TestArriesgaPalabra(string palabra)
        {
            game.PalabraAdivinar = "palabratest";
            return game.arriegaPalabra(palabra);
        }
        
        public void TestInitPalabraMostrada()
        {
            game.PalabraAdivinar = "palabratest";
            StringAssert.AreEqualIgnoringCase("***********", game.PalabraMostrada);
        }

        [TestCase('p', ExpectedResult = true)]
        [TestCase('o', ExpectedResult = true)]
        [TestCase('z', ExpectedResult = false)]
        [TestCase('w', ExpectedResult = false)]
        public bool TestContieneLetra(char letra)
        {
            game.PalabraAdivinar = "probando";
            return game.contieneLetra(letra);
        }
    }
}
